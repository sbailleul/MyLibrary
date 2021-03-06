/* 
 * Library API
 *
 * Through this API you can access authors and their books
 *
 * OpenAPI spec version: 1.0
 * Contact: bailleul.sacha@gmail.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Defines CallingConventions
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
        public enum CallingConventions
    {
        /// <summary>
        /// Enum NUMBER_1 for value: 1
        /// </summary>
        [EnumMember(Value = "1")]
        NUMBER_1 = 1,
        /// <summary>
        /// Enum NUMBER_2 for value: 2
        /// </summary>
        [EnumMember(Value = "2")]
        NUMBER_2 = 2,
        /// <summary>
        /// Enum NUMBER_3 for value: 3
        /// </summary>
        [EnumMember(Value = "3")]
        NUMBER_3 = 3,
        /// <summary>
        /// Enum NUMBER_32 for value: 32
        /// </summary>
        [EnumMember(Value = "32")]
        NUMBER_32 = 4,
        /// <summary>
        /// Enum NUMBER_64 for value: 64
        /// </summary>
        [EnumMember(Value = "64")]
        NUMBER_64 = 5    }
}
