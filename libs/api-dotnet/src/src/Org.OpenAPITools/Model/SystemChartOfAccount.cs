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
    /// SystemChartOfAccount
    /// </summary>
    [DataContract(Name = "SystemChartOfAccount")]
    public partial class SystemChartOfAccount : IEquatable<SystemChartOfAccount>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemChartOfAccount" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SystemChartOfAccount() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemChartOfAccount" /> class.
        /// </summary>
        /// <param name="chartOfAccountId">chartOfAccountId.</param>
        /// <param name="companyId">companyId (required).</param>
        /// <param name="systemCode">systemCode (required).</param>
        /// <param name="chartOfAccount">chartOfAccount.</param>
        /// <param name="chartOfAccountIdCredit">chartOfAccountIdCredit.</param>
        public SystemChartOfAccount(long chartOfAccountId = default(long), long companyId = default(long), int systemCode = default(int), OneOfChartOfAccount chartOfAccount = default(OneOfChartOfAccount), long? chartOfAccountIdCredit = default(long?))
        {
            this.CompanyId = companyId;
            this.SystemCode = systemCode;
            this.ChartOfAccountId = chartOfAccountId;
            this.ChartOfAccount = chartOfAccount;
            this.ChartOfAccountIdCredit = chartOfAccountIdCredit;
        }

        /// <summary>
        /// Gets or Sets ChartOfAccountId
        /// </summary>
        [DataMember(Name = "chartOfAccountId", EmitDefaultValue = false)]
        public long ChartOfAccountId { get; set; }

        /// <summary>
        /// Gets or Sets CompanyId
        /// </summary>
        [DataMember(Name = "companyId", IsRequired = true, EmitDefaultValue = false)]
        public long CompanyId { get; set; }

        /// <summary>
        /// Gets or Sets SystemCode
        /// </summary>
        [DataMember(Name = "systemCode", IsRequired = true, EmitDefaultValue = false)]
        public int SystemCode { get; set; }

        /// <summary>
        /// Gets or Sets ChartOfAccount
        /// </summary>
        [DataMember(Name = "chartOfAccount", EmitDefaultValue = true)]
        public OneOfChartOfAccount ChartOfAccount { get; set; }

        /// <summary>
        /// Gets or Sets ChartOfAccountIdCredit
        /// </summary>
        [DataMember(Name = "chartOfAccountIdCredit", EmitDefaultValue = true)]
        public long? ChartOfAccountIdCredit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SystemChartOfAccount {\n");
            sb.Append("  ChartOfAccountId: ").Append(ChartOfAccountId).Append("\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
            sb.Append("  SystemCode: ").Append(SystemCode).Append("\n");
            sb.Append("  ChartOfAccount: ").Append(ChartOfAccount).Append("\n");
            sb.Append("  ChartOfAccountIdCredit: ").Append(ChartOfAccountIdCredit).Append("\n");
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
            return this.Equals(input as SystemChartOfAccount);
        }

        /// <summary>
        /// Returns true if SystemChartOfAccount instances are equal
        /// </summary>
        /// <param name="input">Instance of SystemChartOfAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SystemChartOfAccount input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ChartOfAccountId == input.ChartOfAccountId ||
                    this.ChartOfAccountId.Equals(input.ChartOfAccountId)
                ) && 
                (
                    this.CompanyId == input.CompanyId ||
                    this.CompanyId.Equals(input.CompanyId)
                ) && 
                (
                    this.SystemCode == input.SystemCode ||
                    this.SystemCode.Equals(input.SystemCode)
                ) && 
                (
                    this.ChartOfAccount == input.ChartOfAccount ||
                    (this.ChartOfAccount != null &&
                    this.ChartOfAccount.Equals(input.ChartOfAccount))
                ) && 
                (
                    this.ChartOfAccountIdCredit == input.ChartOfAccountIdCredit ||
                    (this.ChartOfAccountIdCredit != null &&
                    this.ChartOfAccountIdCredit.Equals(input.ChartOfAccountIdCredit))
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
                hashCode = (hashCode * 59) + this.ChartOfAccountId.GetHashCode();
                hashCode = (hashCode * 59) + this.CompanyId.GetHashCode();
                hashCode = (hashCode * 59) + this.SystemCode.GetHashCode();
                if (this.ChartOfAccount != null)
                {
                    hashCode = (hashCode * 59) + this.ChartOfAccount.GetHashCode();
                }
                if (this.ChartOfAccountIdCredit != null)
                {
                    hashCode = (hashCode * 59) + this.ChartOfAccountIdCredit.GetHashCode();
                }
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
