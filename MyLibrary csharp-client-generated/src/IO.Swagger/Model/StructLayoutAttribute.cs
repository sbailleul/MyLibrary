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
    /// StructLayoutAttribute
    /// </summary>
    [DataContract]
        public partial class StructLayoutAttribute :  IEquatable<StructLayoutAttribute>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StructLayoutAttribute" /> class.
        /// </summary>
        public StructLayoutAttribute()
        {
        }
        
        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public  Value { get; private set; }

        /// <summary>
        /// Gets or Sets TypeId
        /// </summary>
        [DataMember(Name="typeId", EmitDefaultValue=false)]
        public Object TypeId { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StructLayoutAttribute {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  TypeId: ").Append(TypeId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as StructLayoutAttribute);
        }

        /// <summary>
        /// Returns true if StructLayoutAttribute instances are equal
        /// </summary>
        /// <param name="input">Instance of StructLayoutAttribute to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StructLayoutAttribute input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Value == input.Value ||
                    this.Value != null &&
                    input.Value != null &&
                    this.Value.SequenceEqual(input.Value)
                ) && 
                (
                    this.TypeId == input.TypeId ||
                    (this.TypeId != null &&
                    this.TypeId.Equals(input.TypeId))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.TypeId != null)
                    hashCode = hashCode * 59 + this.TypeId.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
