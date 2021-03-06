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
    /// Assembly
    /// </summary>
    [DataContract]
        public partial class Assembly :  IEquatable<Assembly>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Assembly" /> class.
        /// </summary>
        public Assembly()
        {
        }
        
        /// <summary>
        /// Gets or Sets DefinedTypes
        /// </summary>
        [DataMember(Name="definedTypes", EmitDefaultValue=false)]
        public List<TypeInfo> DefinedTypes { get; private set; }

        /// <summary>
        /// Gets or Sets ExportedTypes
        /// </summary>
        [DataMember(Name="exportedTypes", EmitDefaultValue=false)]
        public List<Type> ExportedTypes { get; private set; }

        /// <summary>
        /// Gets or Sets CodeBase
        /// </summary>
        [DataMember(Name="codeBase", EmitDefaultValue=false)]
        public string CodeBase { get; private set; }

        /// <summary>
        /// Gets or Sets EntryPoint
        /// </summary>
        [DataMember(Name="entryPoint", EmitDefaultValue=false)]
        public  EntryPoint { get; private set; }

        /// <summary>
        /// Gets or Sets FullName
        /// </summary>
        [DataMember(Name="fullName", EmitDefaultValue=false)]
        public string FullName { get; private set; }

        /// <summary>
        /// Gets or Sets ImageRuntimeVersion
        /// </summary>
        [DataMember(Name="imageRuntimeVersion", EmitDefaultValue=false)]
        public string ImageRuntimeVersion { get; private set; }

        /// <summary>
        /// Gets or Sets IsDynamic
        /// </summary>
        [DataMember(Name="isDynamic", EmitDefaultValue=false)]
        public bool? IsDynamic { get; private set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public string Location { get; private set; }

        /// <summary>
        /// Gets or Sets ReflectionOnly
        /// </summary>
        [DataMember(Name="reflectionOnly", EmitDefaultValue=false)]
        public bool? ReflectionOnly { get; private set; }

        /// <summary>
        /// Gets or Sets IsCollectible
        /// </summary>
        [DataMember(Name="isCollectible", EmitDefaultValue=false)]
        public bool? IsCollectible { get; private set; }

        /// <summary>
        /// Gets or Sets IsFullyTrusted
        /// </summary>
        [DataMember(Name="isFullyTrusted", EmitDefaultValue=false)]
        public bool? IsFullyTrusted { get; private set; }

        /// <summary>
        /// Gets or Sets CustomAttributes
        /// </summary>
        [DataMember(Name="customAttributes", EmitDefaultValue=false)]
        public List<CustomAttributeData> CustomAttributes { get; private set; }

        /// <summary>
        /// Gets or Sets EscapedCodeBase
        /// </summary>
        [DataMember(Name="escapedCodeBase", EmitDefaultValue=false)]
        public string EscapedCodeBase { get; private set; }

        /// <summary>
        /// Gets or Sets ManifestModule
        /// </summary>
        [DataMember(Name="manifestModule", EmitDefaultValue=false)]
        public  ManifestModule { get; private set; }

        /// <summary>
        /// Gets or Sets Modules
        /// </summary>
        [DataMember(Name="modules", EmitDefaultValue=false)]
        public List<Module> Modules { get; private set; }

        /// <summary>
        /// Gets or Sets GlobalAssemblyCache
        /// </summary>
        [DataMember(Name="globalAssemblyCache", EmitDefaultValue=false)]
        public bool? GlobalAssemblyCache { get; private set; }

        /// <summary>
        /// Gets or Sets HostContext
        /// </summary>
        [DataMember(Name="hostContext", EmitDefaultValue=false)]
        public long? HostContext { get; private set; }

        /// <summary>
        /// Gets or Sets SecurityRuleSet
        /// </summary>
        [DataMember(Name="securityRuleSet", EmitDefaultValue=false)]
        public  SecurityRuleSet { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Assembly {\n");
            sb.Append("  DefinedTypes: ").Append(DefinedTypes).Append("\n");
            sb.Append("  ExportedTypes: ").Append(ExportedTypes).Append("\n");
            sb.Append("  CodeBase: ").Append(CodeBase).Append("\n");
            sb.Append("  EntryPoint: ").Append(EntryPoint).Append("\n");
            sb.Append("  FullName: ").Append(FullName).Append("\n");
            sb.Append("  ImageRuntimeVersion: ").Append(ImageRuntimeVersion).Append("\n");
            sb.Append("  IsDynamic: ").Append(IsDynamic).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  ReflectionOnly: ").Append(ReflectionOnly).Append("\n");
            sb.Append("  IsCollectible: ").Append(IsCollectible).Append("\n");
            sb.Append("  IsFullyTrusted: ").Append(IsFullyTrusted).Append("\n");
            sb.Append("  CustomAttributes: ").Append(CustomAttributes).Append("\n");
            sb.Append("  EscapedCodeBase: ").Append(EscapedCodeBase).Append("\n");
            sb.Append("  ManifestModule: ").Append(ManifestModule).Append("\n");
            sb.Append("  Modules: ").Append(Modules).Append("\n");
            sb.Append("  GlobalAssemblyCache: ").Append(GlobalAssemblyCache).Append("\n");
            sb.Append("  HostContext: ").Append(HostContext).Append("\n");
            sb.Append("  SecurityRuleSet: ").Append(SecurityRuleSet).Append("\n");
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
            return this.Equals(input as Assembly);
        }

        /// <summary>
        /// Returns true if Assembly instances are equal
        /// </summary>
        /// <param name="input">Instance of Assembly to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Assembly input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DefinedTypes == input.DefinedTypes ||
                    this.DefinedTypes != null &&
                    input.DefinedTypes != null &&
                    this.DefinedTypes.SequenceEqual(input.DefinedTypes)
                ) && 
                (
                    this.ExportedTypes == input.ExportedTypes ||
                    this.ExportedTypes != null &&
                    input.ExportedTypes != null &&
                    this.ExportedTypes.SequenceEqual(input.ExportedTypes)
                ) && 
                (
                    this.CodeBase == input.CodeBase ||
                    (this.CodeBase != null &&
                    this.CodeBase.Equals(input.CodeBase))
                ) && 
                (
                    this.EntryPoint == input.EntryPoint ||
                    this.EntryPoint != null &&
                    input.EntryPoint != null &&
                    this.EntryPoint.SequenceEqual(input.EntryPoint)
                ) && 
                (
                    this.FullName == input.FullName ||
                    (this.FullName != null &&
                    this.FullName.Equals(input.FullName))
                ) && 
                (
                    this.ImageRuntimeVersion == input.ImageRuntimeVersion ||
                    (this.ImageRuntimeVersion != null &&
                    this.ImageRuntimeVersion.Equals(input.ImageRuntimeVersion))
                ) && 
                (
                    this.IsDynamic == input.IsDynamic ||
                    (this.IsDynamic != null &&
                    this.IsDynamic.Equals(input.IsDynamic))
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.ReflectionOnly == input.ReflectionOnly ||
                    (this.ReflectionOnly != null &&
                    this.ReflectionOnly.Equals(input.ReflectionOnly))
                ) && 
                (
                    this.IsCollectible == input.IsCollectible ||
                    (this.IsCollectible != null &&
                    this.IsCollectible.Equals(input.IsCollectible))
                ) && 
                (
                    this.IsFullyTrusted == input.IsFullyTrusted ||
                    (this.IsFullyTrusted != null &&
                    this.IsFullyTrusted.Equals(input.IsFullyTrusted))
                ) && 
                (
                    this.CustomAttributes == input.CustomAttributes ||
                    this.CustomAttributes != null &&
                    input.CustomAttributes != null &&
                    this.CustomAttributes.SequenceEqual(input.CustomAttributes)
                ) && 
                (
                    this.EscapedCodeBase == input.EscapedCodeBase ||
                    (this.EscapedCodeBase != null &&
                    this.EscapedCodeBase.Equals(input.EscapedCodeBase))
                ) && 
                (
                    this.ManifestModule == input.ManifestModule ||
                    this.ManifestModule != null &&
                    input.ManifestModule != null &&
                    this.ManifestModule.SequenceEqual(input.ManifestModule)
                ) && 
                (
                    this.Modules == input.Modules ||
                    this.Modules != null &&
                    input.Modules != null &&
                    this.Modules.SequenceEqual(input.Modules)
                ) && 
                (
                    this.GlobalAssemblyCache == input.GlobalAssemblyCache ||
                    (this.GlobalAssemblyCache != null &&
                    this.GlobalAssemblyCache.Equals(input.GlobalAssemblyCache))
                ) && 
                (
                    this.HostContext == input.HostContext ||
                    (this.HostContext != null &&
                    this.HostContext.Equals(input.HostContext))
                ) && 
                (
                    this.SecurityRuleSet == input.SecurityRuleSet ||
                    this.SecurityRuleSet != null &&
                    input.SecurityRuleSet != null &&
                    this.SecurityRuleSet.SequenceEqual(input.SecurityRuleSet)
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
                if (this.DefinedTypes != null)
                    hashCode = hashCode * 59 + this.DefinedTypes.GetHashCode();
                if (this.ExportedTypes != null)
                    hashCode = hashCode * 59 + this.ExportedTypes.GetHashCode();
                if (this.CodeBase != null)
                    hashCode = hashCode * 59 + this.CodeBase.GetHashCode();
                if (this.EntryPoint != null)
                    hashCode = hashCode * 59 + this.EntryPoint.GetHashCode();
                if (this.FullName != null)
                    hashCode = hashCode * 59 + this.FullName.GetHashCode();
                if (this.ImageRuntimeVersion != null)
                    hashCode = hashCode * 59 + this.ImageRuntimeVersion.GetHashCode();
                if (this.IsDynamic != null)
                    hashCode = hashCode * 59 + this.IsDynamic.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.ReflectionOnly != null)
                    hashCode = hashCode * 59 + this.ReflectionOnly.GetHashCode();
                if (this.IsCollectible != null)
                    hashCode = hashCode * 59 + this.IsCollectible.GetHashCode();
                if (this.IsFullyTrusted != null)
                    hashCode = hashCode * 59 + this.IsFullyTrusted.GetHashCode();
                if (this.CustomAttributes != null)
                    hashCode = hashCode * 59 + this.CustomAttributes.GetHashCode();
                if (this.EscapedCodeBase != null)
                    hashCode = hashCode * 59 + this.EscapedCodeBase.GetHashCode();
                if (this.ManifestModule != null)
                    hashCode = hashCode * 59 + this.ManifestModule.GetHashCode();
                if (this.Modules != null)
                    hashCode = hashCode * 59 + this.Modules.GetHashCode();
                if (this.GlobalAssemblyCache != null)
                    hashCode = hashCode * 59 + this.GlobalAssemblyCache.GetHashCode();
                if (this.HostContext != null)
                    hashCode = hashCode * 59 + this.HostContext.GetHashCode();
                if (this.SecurityRuleSet != null)
                    hashCode = hashCode * 59 + this.SecurityRuleSet.GetHashCode();
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
