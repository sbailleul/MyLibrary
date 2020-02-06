﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Library.API.OperationFilters
{
    public class GetBookOperationFilter: IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            if (operation.OperationId != "GetBook")
            {
                return;
            }
            operation.Responses[StatusCodes.Status200OK.ToString()].Content.Add("application/vnd.marvin.bookwithconcatenatedauthorname+json", new OpenApiMediaType()
            {
                Schema = context.SchemaGenerator.GenerateSchema(typeof(BookWithConcatenatedAuthorName), context.SchemaRepository)
            });
        }
    }
}
