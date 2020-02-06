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
    /// MemberInfo
    /// </summary>
    [DataContract]
        public partial class MemberInfo :  IEquatable<MemberInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MemberInfo" /> class.
        /// </summary>
        public MemberInfo()
        {
        }
        
        /// <summary>
        /// Gets or Sets MemberType
        /// </summary>
        [DataMember(Name="memberType", EmitDefaultValue=false)]
        public  MemberType { get; private set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; private set; }

        /// <summary>
        /// Gets or Sets DeclaringType
        /// </summary>
        [DataMember(Name="declaringType", EmitDefaultValue=false)]
        public  DeclaringType { get; private set; }

        /// <summary>
        /// Gets or Sets ReflectedType
        /// </summary>
        [DataMember(Name="reflectedType", EmitDefaultValue=false)]
        public  ReflectedType { get; private set; }

        /// <summary>
        /// Gets or Sets Module
        /// </summary>
        [DataMember(Name="module", EmitDefaultValue=false)]
        public  Module { get; private set; }

        /// <summary>
        /// Gets or Sets CustomAttributes
        /// </summary>
        [DataMember(Name="customAttributes", EmitDefaultValue=false)]
        public List<CustomAttributeData> CustomAttributes { get; private set; }

        /// <summary>
        /// Gets or Sets IsCollectible
        /// </summary>
        [DataMember(Name="isCollectible", EmitDefaultValue=false)]
        public bool? IsCollectible { get; private set; }

        /// <summary>
        /// Gets or Sets MetadataToken
        /// </summary>
        [DataMember(Name="metadataToken", EmitDefaultValue=false)]
        public int? MetadataToken { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MemberInfo {\n");
            sb.Append("  MemberType: ").Append(MemberType).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DeclaringType: ").Append(DeclaringType).Append("\n");
            sb.Append("  ReflectedType: ").Append(ReflectedType).Append("\n");
            sb.Append("  Module: ").Append(Module).Append("\n");
            sb.Append("  CustomAttributes: ").Append(CustomAttributes).Append("\n");
            sb.Append("  IsCollectible: ").Append(IsCollectible).Append("\n");
            sb.Append("  MetadataToken: ").Append(MetadataToken).Append("\n");
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
            return this.Equals(input as MemberInfo);
        }

        /// <summary>
        /// Returns true if MemberInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of MemberInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MemberInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MemberType == input.MemberType ||
                    this.MemberType != null &&
                    input.MemberType != null &&
                    this.MemberType.SequenceEqual(input.MemberType)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.DeclaringType == input.DeclaringType ||
                    this.DeclaringType != null &&
                    input.DeclaringType != null &&
                    this.DeclaringType.SequenceEqual(input.DeclaringType)
                ) && 
                (
                    this.ReflectedType == input.ReflectedType ||
                    this.ReflectedType != null &&
                    input.ReflectedType != null &&
                    this.ReflectedType.SequenceEqual(input.ReflectedType)
                ) && 
                (
                    this.Module == input.Module ||
                    this.Module != null &&
                    input.Module != null &&
                    this.Module.SequenceEqual(input.Module)
                ) && 
                (
                    this.CustomAttributes == input.CustomAttributes ||
                    this.CustomAttributes != null &&
                    input.CustomAttributes != null &&
                    this.CustomAttributes.SequenceEqual(input.CustomAttributes)
                ) && 
                (
                    this.IsCollectible == input.IsCollectible ||
                    (this.IsCollectible != null &&
                    this.IsCollectible.Equals(input.IsCollectible))
                ) && 
                (
                    this.MetadataToken == input.MetadataToken ||
                    (this.MetadataToken != null &&
                    this.MetadataToken.Equals(input.MetadataToken))
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
                if (this.MemberType != null)
                    hashCode = hashCode * 59 + this.MemberType.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.DeclaringType != null)
                    hashCode = hashCode * 59 + this.DeclaringType.GetHashCode();
                if (this.ReflectedType != null)
                    hashCode = hashCode * 59 + this.ReflectedType.GetHashCode();
                if (this.Module != null)
                    hashCode = hashCode * 59 + this.Module.GetHashCode();
                if (this.CustomAttributes != null)
                    hashCode = hashCode * 59 + this.CustomAttributes.GetHashCode();
                if (this.IsCollectible != null)
                    hashCode = hashCode * 59 + this.IsCollectible.GetHashCode();
                if (this.MetadataToken != null)
                    hashCode = hashCode * 59 + this.MetadataToken.GetHashCode();
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