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
    /// EventInfo
    /// </summary>
    [DataContract]
        public partial class EventInfo :  IEquatable<EventInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventInfo" /> class.
        /// </summary>
        public EventInfo()
        {
        }
        
        /// <summary>
        /// Gets or Sets MemberType
        /// </summary>
        [DataMember(Name="memberType", EmitDefaultValue=false)]
        public  MemberType { get; private set; }

        /// <summary>
        /// Gets or Sets Attributes
        /// </summary>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public  Attributes { get; private set; }

        /// <summary>
        /// Gets or Sets IsSpecialName
        /// </summary>
        [DataMember(Name="isSpecialName", EmitDefaultValue=false)]
        public bool? IsSpecialName { get; private set; }

        /// <summary>
        /// Gets or Sets AddMethod
        /// </summary>
        [DataMember(Name="addMethod", EmitDefaultValue=false)]
        public  AddMethod { get; private set; }

        /// <summary>
        /// Gets or Sets RemoveMethod
        /// </summary>
        [DataMember(Name="removeMethod", EmitDefaultValue=false)]
        public  RemoveMethod { get; private set; }

        /// <summary>
        /// Gets or Sets RaiseMethod
        /// </summary>
        [DataMember(Name="raiseMethod", EmitDefaultValue=false)]
        public  RaiseMethod { get; private set; }

        /// <summary>
        /// Gets or Sets IsMulticast
        /// </summary>
        [DataMember(Name="isMulticast", EmitDefaultValue=false)]
        public bool? IsMulticast { get; private set; }

        /// <summary>
        /// Gets or Sets EventHandlerType
        /// </summary>
        [DataMember(Name="eventHandlerType", EmitDefaultValue=false)]
        public  EventHandlerType { get; private set; }

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
            sb.Append("class EventInfo {\n");
            sb.Append("  MemberType: ").Append(MemberType).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  IsSpecialName: ").Append(IsSpecialName).Append("\n");
            sb.Append("  AddMethod: ").Append(AddMethod).Append("\n");
            sb.Append("  RemoveMethod: ").Append(RemoveMethod).Append("\n");
            sb.Append("  RaiseMethod: ").Append(RaiseMethod).Append("\n");
            sb.Append("  IsMulticast: ").Append(IsMulticast).Append("\n");
            sb.Append("  EventHandlerType: ").Append(EventHandlerType).Append("\n");
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
            return this.Equals(input as EventInfo);
        }

        /// <summary>
        /// Returns true if EventInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of EventInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EventInfo input)
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
                    this.Attributes == input.Attributes ||
                    this.Attributes != null &&
                    input.Attributes != null &&
                    this.Attributes.SequenceEqual(input.Attributes)
                ) && 
                (
                    this.IsSpecialName == input.IsSpecialName ||
                    (this.IsSpecialName != null &&
                    this.IsSpecialName.Equals(input.IsSpecialName))
                ) && 
                (
                    this.AddMethod == input.AddMethod ||
                    this.AddMethod != null &&
                    input.AddMethod != null &&
                    this.AddMethod.SequenceEqual(input.AddMethod)
                ) && 
                (
                    this.RemoveMethod == input.RemoveMethod ||
                    this.RemoveMethod != null &&
                    input.RemoveMethod != null &&
                    this.RemoveMethod.SequenceEqual(input.RemoveMethod)
                ) && 
                (
                    this.RaiseMethod == input.RaiseMethod ||
                    this.RaiseMethod != null &&
                    input.RaiseMethod != null &&
                    this.RaiseMethod.SequenceEqual(input.RaiseMethod)
                ) && 
                (
                    this.IsMulticast == input.IsMulticast ||
                    (this.IsMulticast != null &&
                    this.IsMulticast.Equals(input.IsMulticast))
                ) && 
                (
                    this.EventHandlerType == input.EventHandlerType ||
                    this.EventHandlerType != null &&
                    input.EventHandlerType != null &&
                    this.EventHandlerType.SequenceEqual(input.EventHandlerType)
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
                if (this.Attributes != null)
                    hashCode = hashCode * 59 + this.Attributes.GetHashCode();
                if (this.IsSpecialName != null)
                    hashCode = hashCode * 59 + this.IsSpecialName.GetHashCode();
                if (this.AddMethod != null)
                    hashCode = hashCode * 59 + this.AddMethod.GetHashCode();
                if (this.RemoveMethod != null)
                    hashCode = hashCode * 59 + this.RemoveMethod.GetHashCode();
                if (this.RaiseMethod != null)
                    hashCode = hashCode * 59 + this.RaiseMethod.GetHashCode();
                if (this.IsMulticast != null)
                    hashCode = hashCode * 59 + this.IsMulticast.GetHashCode();
                if (this.EventHandlerType != null)
                    hashCode = hashCode * 59 + this.EventHandlerType.GetHashCode();
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
