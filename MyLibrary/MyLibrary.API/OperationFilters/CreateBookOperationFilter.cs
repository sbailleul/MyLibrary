using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Library.API.OperationFilters
{
    public class CreateBookOperationFilter: IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            if (operation.OperationId != "CreateBook") return;

            operation.RequestBody.Content.Add("application/vnd.martin.bookforcreationwithamountofpages+json", new OpenApiMediaType()
            {
                Schema = context.SchemaGenerator.GenerateSchema(typeof(BookForCreationWithAmountOfPages), context.SchemaRepository)
            });
        }
    }
}
