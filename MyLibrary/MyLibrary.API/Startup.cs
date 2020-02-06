using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using AutoMapper;
using Library.API.Authentication;
using Library.API.Contexts;
using Library.API.Helpers;
using Library.API.OperationFilters;
using Library.API.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json.Serialization;
using Swashbuckle.AspNetCore.SwaggerGen;
using Swashbuckle.AspNetCore.SwaggerUI;

// [assembly: ApiConventionType(typeof(DefaultApiConventions))]

namespace Library.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers(setupAction =>
                {
                    setupAction.Filters.Add(new AuthorizeFilter());
                    setupAction.Filters.Add(new ProducesDefaultResponseTypeAttribute());
                    setupAction.Filters.Add(new ProducesResponseTypeAttribute(StatusCodes.Status400BadRequest));
                    setupAction.Filters.Add(new ProducesResponseTypeAttribute(StatusCodes.Status401Unauthorized));
                    setupAction.Filters.Add(new ProducesResponseTypeAttribute(StatusCodes.Status406NotAcceptable));
                    setupAction.Filters.Add(
                        new ProducesResponseTypeAttribute(StatusCodes.Status500InternalServerError));
                    setupAction.ReturnHttpNotAcceptable = true;
                    setupAction.OutputFormatters.RemoveType<SystemTextJsonOutputFormatter>();
                }).AddNewtonsoftJson(setupAction =>
                    setupAction.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver())
                .AddXmlSerializerFormatters();

            // register the DbContext on the container, getting the connection string from
            // appSettings (note: use this during development; in a production environment,
            // it's better to store the connection string in an environment variable)
            var connectionString = Configuration["ConnectionStrings:LibraryDBConnectionString"];
            services.AddDbContext<LibraryContext>(o => o.UseSqlServer(connectionString));
            
            services.Configure<ApiBehaviorOptions>(options =>
            {
                options.InvalidModelStateResponseFactory = actionContext =>
                {
                    var actionExecutingContext =
                        actionContext as ActionExecutingContext;

                    // if there are modelstate errors & all keys were correctly
                    // found/parsed we're dealing with validation errors
                    if (actionContext.ModelState.ErrorCount > 0
                        && actionExecutingContext?.ActionArguments.Count ==
                        actionContext.ActionDescriptor.Parameters.Count)
                        return new UnprocessableEntityObjectResult(actionContext.ModelState);

                    // if one of the keys wasn't correctly found / couldn't be parsed
                    // we're dealing with null/unparsable input
                    return new BadRequestObjectResult(actionContext.ModelState);
                };
            });

            services.Configure<MvcOptions>(config =>
            {
                var newtonJsonOutputFormatter =
                    config.OutputFormatters.OfType<NewtonsoftJsonOutputFormatter>()?.FirstOrDefault();
                newtonJsonOutputFormatter?.SupportedMediaTypes.TryRemove("text/json");
            });
                
            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<IAuthorRepository, AuthorRepository>();

            services.AddVersionedApiExplorer(setupAction => { setupAction.GroupNameFormat = "'v'VV"; });

            services.AddAuthentication("Basic")
                .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("Basic", null);

            services.AddApiVersioning(setupAction =>
            {
                setupAction.AssumeDefaultVersionWhenUnspecified = true;
                setupAction.DefaultApiVersion = new ApiVersion(1,0);
                setupAction.ReportApiVersions = true;
                // setupAction.ApiVersionReader = new HeaderApiVersionReader("api-version");
                // setupAction.ApiVersionReader = new MediaTypeApiVersionReader();
            });
            var apiVersionDescriptionProvider =
                services.BuildServiceProvider().GetService<IApiVersionDescriptionProvider>();

            services.AddSwaggerGen(setupAction => { SetupSwaggerOptions(setupAction, apiVersionDescriptionProvider); });
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }



        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IApiVersionDescriptionProvider apiVersionDescriptionProvider)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();
            else
                // The default HSTS value is 30 days. 
                // You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();

            app.UseHttpsRedirection();
            app.UseSwagger();
            app.UseSwaggerUI(setupAction =>
            {
                setupAction.InjectStylesheet("/Assets/custom-ui.css");
                foreach (var apiVersionDescription in apiVersionDescriptionProvider.ApiVersionDescriptions)
                {
                    setupAction.SwaggerEndpoint($"/swagger/LibraryOpenAPISpecification{apiVersionDescription.GroupName}/swagger.json", apiVersionDescription.GroupName.ToLowerInvariant());
                    setupAction.RoutePrefix = ""; //Available at root path
                }
                setupAction.DefaultModelExpandDepth(2);
                setupAction.DefaultModelRendering(ModelRendering.Model);
                setupAction.DocExpansion(DocExpansion.None);
                setupAction.EnableDeepLinking();
                setupAction.DisplayOperationId();
            });
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
            // app.UseMvc();
        }

        private static void SetupSwaggerOptions(SwaggerGenOptions setupAction,
    IApiVersionDescriptionProvider apiVersionDescriptionProvider)
        {
            setupAction.AddSecurityDefinition("basicAuth", new OpenApiSecurityScheme()
            {
                Type = SecuritySchemeType.Http,
                Scheme = "basic",
                Description = "Input your username and password to access this API"
            });

            setupAction.AddSecurityRequirement(new OpenApiSecurityRequirement
            {
                {
                    new OpenApiSecurityScheme()
                    {
                        Reference = new OpenApiReference
                        {
                            Type = ReferenceType.SecurityScheme,
                            Id="basicAuth"
                        }
                    },new List<string>() }
            });

            foreach (var apiVersionDescription in apiVersionDescriptionProvider.ApiVersionDescriptions)
            {
                setupAction.SwaggerDoc($"LibraryOpenAPISpecification{apiVersionDescription.GroupName}",
                    new OpenApiInfo
                    {
                        Title = "Library API",
                        Version = apiVersionDescription.ApiVersion.ToString(),
                        Description = "Through this API you can access authors and their books",
                        Contact = new OpenApiContact
                        {
                            Name = "Sacha Bailleul",
                            Email = "bailleul.sacha@gmail.com",
                            Url = new Uri("https://www.linkedin.com/in/sacha-bailleul-a83762105/")
                        },
                        License = new OpenApiLicense
                        {
                            Name = "MIT License",
                            Url = new Uri("https://opensource.org/licenses/MIT")
                        }
                    });
                setupAction.DocInclusionPredicate((documentName, apiDescription) =>
                {
                    var actionApiVersionModel =
                        apiDescription.ActionDescriptor.GetApiVersionModel(
                            ApiVersionMapping.Explicit | ApiVersionMapping.Implicit);

                    if (actionApiVersionModel == null)
                    {
                        return true;
                    }

                    if (actionApiVersionModel.DeclaredApiVersions.Any())
                    {
                        return actionApiVersionModel.DeclaredApiVersions.Any(v =>
                            $"LibraryOpenAPISpecificationv{v.ToString()}" == documentName);
                    }

                    return actionApiVersionModel.ImplementedApiVersions.Any(v =>
                        $"LibraryOpenAPISpecificationv{v.ToString()}" == documentName);
                });
            }


            // setupAction.ResolveConflictingActions(apiDescriptions =>
            // {
            //     // var firstDescription = apiDescriptions.First();
            //     // firstDescription.SupportedResponseTypes.AddRange(apiDescriptions.Skip(1)?.
            //     //     SelectMany(description => description.SupportedResponseTypes.
            //     //     Where(resType => resType.StatusCode == 200)));
            //     // return firstDescription;
            // });
            setupAction.OperationFilter<GetBookOperationFilter>();
            setupAction.OperationFilter<CreateBookOperationFilter>();
            var xmlCommentFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
            var xmlCommentPath = Path.Combine(AppContext.BaseDirectory, xmlCommentFile);
            setupAction.IncludeXmlComments(xmlCommentPath);
        }
    }
}