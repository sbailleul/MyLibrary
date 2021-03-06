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
    /// Exception
    /// </summary>
    [DataContract]
        public partial class Exception :  IEquatable<Exception>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Exception" /> class.
        /// </summary>
        /// <param name="helpLink">helpLink.</param>
        /// <param name="source">source.</param>
        /// <param name="hResult">hResult.</param>
        public Exception(string helpLink = default(string), string source = default(string), int? hResult = default(int?))
        {
            this.HelpLink = helpLink;
            this.Source = source;
            this.HResult = hResult;
        }
        
        /// <summary>
        /// Gets or Sets TargetSite
        /// </summary>
        [DataMember(Name="targetSite", EmitDefaultValue=false)]
        public  TargetSite { get; private set; }

        /// <summary>
        /// Gets or Sets StackTrace
        /// </summary>
        [DataMember(Name="stackTrace", EmitDefaultValue=false)]
        public string StackTrace { get; private set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; private set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public Dictionary<string, Object> Data { get; private set; }

        /// <summary>
        /// Gets or Sets InnerException
        /// </summary>
        [DataMember(Name="innerException", EmitDefaultValue=false)]
        public  InnerException { get; private set; }

        /// <summary>
        /// Gets or Sets HelpLink
        /// </summary>
        [DataMember(Name="helpLink", EmitDefaultValue=false)]
        public string HelpLink { get; set; }

        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public string Source { get; set; }

        /// <summary>
        /// Gets or Sets HResult
        /// </summary>
        [DataMember(Name="hResult", EmitDefaultValue=false)]
        public int? HResult { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Exception {\n");
            sb.Append("  TargetSite: ").Append(TargetSite).Append("\n");
            sb.Append("  StackTrace: ").Append(StackTrace).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  InnerException: ").Append(InnerException).Append("\n");
            sb.Append("  HelpLink: ").Append(HelpLink).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  HResult: ").Append(HResult).Append("\n");
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
            return this.Equals(input as Exception);
        }

        /// <summary>
        /// Returns true if Exception instances are equal
        /// </summary>
        /// <param name="input">Instance of Exception to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Exception input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TargetSite == input.TargetSite ||
                    this.TargetSite != null &&
                    input.TargetSite != null &&
                    this.TargetSite.SequenceEqual(input.TargetSite)
                ) && 
                (
                    this.StackTrace == input.StackTrace ||
                    (this.StackTrace != null &&
                    this.StackTrace.Equals(input.StackTrace))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Data == input.Data ||
                    this.Data != null &&
                    input.Data != null &&
                    this.Data.SequenceEqual(input.Data)
                ) && 
                (
                    this.InnerException == input.InnerException ||
                    this.InnerException != null &&
                    input.InnerException != null &&
                    this.InnerException.SequenceEqual(input.InnerException)
                ) && 
                (
                    this.HelpLink == input.HelpLink ||
                    (this.HelpLink != null &&
                    this.HelpLink.Equals(input.HelpLink))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.HResult == input.HResult ||
                    (this.HResult != null &&
                    this.HResult.Equals(input.HResult))
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
                if (this.TargetSite != null)
                    hashCode = hashCode * 59 + this.TargetSite.GetHashCode();
                if (this.StackTrace != null)
                    hashCode = hashCode * 59 + this.StackTrace.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.InnerException != null)
                    hashCode = hashCode * 59 + this.InnerException.GetHashCode();
                if (this.HelpLink != null)
                    hashCode = hashCode * 59 + this.HelpLink.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.HResult != null)
                    hashCode = hashCode * 59 + this.HResult.GetHashCode();
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
