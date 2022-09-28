/*
 * FlowAccount Open API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// UpgradeDocument
    /// </summary>
    [DataContract(Name = "UpgradeDocument")]
    public partial class UpgradeDocument : IEquatable<UpgradeDocument>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpgradeDocument" /> class.
        /// </summary>
        /// <param name="recordId">recordId.</param>
        /// <param name="referenceDocumentSerial">referenceDocumentSerial.</param>
        /// <param name="referenceDocumentType">referenceDocumentType.</param>
        public UpgradeDocument(long recordId = default(long), string referenceDocumentSerial = default(string), long referenceDocumentType = default(long))
        {
            this.RecordId = recordId;
            this.ReferenceDocumentSerial = referenceDocumentSerial;
            this.ReferenceDocumentType = referenceDocumentType;
        }

        /// <summary>
        /// Gets or Sets RecordId
        /// </summary>
        [DataMember(Name = "recordId", EmitDefaultValue = false)]
        public long RecordId { get; set; }

        /// <summary>
        /// Gets or Sets ReferenceDocumentSerial
        /// </summary>
        [DataMember(Name = "referenceDocumentSerial", EmitDefaultValue = true)]
        public string ReferenceDocumentSerial { get; set; }

        /// <summary>
        /// Gets or Sets ReferenceDocumentType
        /// </summary>
        [DataMember(Name = "referenceDocumentType", EmitDefaultValue = false)]
        public long ReferenceDocumentType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpgradeDocument {\n");
            sb.Append("  RecordId: ").Append(RecordId).Append("\n");
            sb.Append("  ReferenceDocumentSerial: ").Append(ReferenceDocumentSerial).Append("\n");
            sb.Append("  ReferenceDocumentType: ").Append(ReferenceDocumentType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpgradeDocument);
        }

        /// <summary>
        /// Returns true if UpgradeDocument instances are equal
        /// </summary>
        /// <param name="input">Instance of UpgradeDocument to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpgradeDocument input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.RecordId == input.RecordId ||
                    this.RecordId.Equals(input.RecordId)
                ) && 
                (
                    this.ReferenceDocumentSerial == input.ReferenceDocumentSerial ||
                    (this.ReferenceDocumentSerial != null &&
                    this.ReferenceDocumentSerial.Equals(input.ReferenceDocumentSerial))
                ) && 
                (
                    this.ReferenceDocumentType == input.ReferenceDocumentType ||
                    this.ReferenceDocumentType.Equals(input.ReferenceDocumentType)
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
                hashCode = (hashCode * 59) + this.RecordId.GetHashCode();
                if (this.ReferenceDocumentSerial != null)
                {
                    hashCode = (hashCode * 59) + this.ReferenceDocumentSerial.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ReferenceDocumentType.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
