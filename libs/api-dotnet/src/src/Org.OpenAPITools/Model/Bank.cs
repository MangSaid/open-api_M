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
    /// Bank
    /// </summary>
    [DataContract(Name = "Bank")]
    public partial class Bank : IEquatable<Bank>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Bank" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Bank() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Bank" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="countryCode">countryCode.</param>
        /// <param name="id">id.</param>
        /// <param name="bankCode">bankCode (required).</param>
        /// <param name="isDelete">isDelete.</param>
        /// <param name="orderNumber">orderNumber.</param>
        /// <param name="url">url.</param>
        /// <param name="isCustomBank">isCustomBank.</param>
        /// <param name="bankAccount">bankAccount.</param>
        /// <param name="reconciledDocument">reconciledDocument.</param>
        public Bank(string name = default(string), string countryCode = default(string), int id = default(int), string bankCode = default(string), bool isDelete = default(bool), int orderNumber = default(int), string url = default(string), bool isCustomBank = default(bool), List<BankAccount> bankAccount = default(List<BankAccount>), List<ReconciledDocument> reconciledDocument = default(List<ReconciledDocument>))
        {
            // to ensure "name" is required (not null)
            if (name == null) {
                throw new ArgumentNullException("name is a required property for Bank and cannot be null");
            }
            this.Name = name;
            // to ensure "bankCode" is required (not null)
            if (bankCode == null) {
                throw new ArgumentNullException("bankCode is a required property for Bank and cannot be null");
            }
            this.BankCode = bankCode;
            this.CountryCode = countryCode;
            this.Id = id;
            this.IsDelete = isDelete;
            this.OrderNumber = orderNumber;
            this.Url = url;
            this.IsCustomBank = isCustomBank;
            this.BankAccount = bankAccount;
            this.ReconciledDocument = reconciledDocument;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets CountryCode
        /// </summary>
        [DataMember(Name = "countryCode", EmitDefaultValue = true)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets BankCode
        /// </summary>
        [DataMember(Name = "bankCode", IsRequired = true, EmitDefaultValue = false)]
        public string BankCode { get; set; }

        /// <summary>
        /// Gets or Sets IsDelete
        /// </summary>
        [DataMember(Name = "isDelete", EmitDefaultValue = true)]
        public bool IsDelete { get; set; }

        /// <summary>
        /// Gets or Sets OrderNumber
        /// </summary>
        [DataMember(Name = "orderNumber", EmitDefaultValue = false)]
        public int OrderNumber { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name = "url", EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets IsCustomBank
        /// </summary>
        [DataMember(Name = "isCustomBank", EmitDefaultValue = true)]
        public bool IsCustomBank { get; set; }

        /// <summary>
        /// Gets or Sets BankAccount
        /// </summary>
        [DataMember(Name = "bankAccount", EmitDefaultValue = true)]
        public List<BankAccount> BankAccount { get; set; }

        /// <summary>
        /// Gets or Sets ReconciledDocument
        /// </summary>
        [DataMember(Name = "reconciledDocument", EmitDefaultValue = true)]
        public List<ReconciledDocument> ReconciledDocument { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Bank {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  BankCode: ").Append(BankCode).Append("\n");
            sb.Append("  IsDelete: ").Append(IsDelete).Append("\n");
            sb.Append("  OrderNumber: ").Append(OrderNumber).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  IsCustomBank: ").Append(IsCustomBank).Append("\n");
            sb.Append("  BankAccount: ").Append(BankAccount).Append("\n");
            sb.Append("  ReconciledDocument: ").Append(ReconciledDocument).Append("\n");
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
            return this.Equals(input as Bank);
        }

        /// <summary>
        /// Returns true if Bank instances are equal
        /// </summary>
        /// <param name="input">Instance of Bank to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Bank input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.CountryCode == input.CountryCode ||
                    (this.CountryCode != null &&
                    this.CountryCode.Equals(input.CountryCode))
                ) && 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.BankCode == input.BankCode ||
                    (this.BankCode != null &&
                    this.BankCode.Equals(input.BankCode))
                ) && 
                (
                    this.IsDelete == input.IsDelete ||
                    this.IsDelete.Equals(input.IsDelete)
                ) && 
                (
                    this.OrderNumber == input.OrderNumber ||
                    this.OrderNumber.Equals(input.OrderNumber)
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.IsCustomBank == input.IsCustomBank ||
                    this.IsCustomBank.Equals(input.IsCustomBank)
                ) && 
                (
                    this.BankAccount == input.BankAccount ||
                    this.BankAccount != null &&
                    input.BankAccount != null &&
                    this.BankAccount.SequenceEqual(input.BankAccount)
                ) && 
                (
                    this.ReconciledDocument == input.ReconciledDocument ||
                    this.ReconciledDocument != null &&
                    input.ReconciledDocument != null &&
                    this.ReconciledDocument.SequenceEqual(input.ReconciledDocument)
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.CountryCode != null)
                {
                    hashCode = (hashCode * 59) + this.CountryCode.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
                if (this.BankCode != null)
                {
                    hashCode = (hashCode * 59) + this.BankCode.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsDelete.GetHashCode();
                hashCode = (hashCode * 59) + this.OrderNumber.GetHashCode();
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsCustomBank.GetHashCode();
                if (this.BankAccount != null)
                {
                    hashCode = (hashCode * 59) + this.BankAccount.GetHashCode();
                }
                if (this.ReconciledDocument != null)
                {
                    hashCode = (hashCode * 59) + this.ReconciledDocument.GetHashCode();
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
            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            // CountryCode (string) maxLength
            if (this.CountryCode != null && this.CountryCode.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CountryCode, length must be less than 50.", new [] { "CountryCode" });
            }

            // CountryCode (string) minLength
            if (this.CountryCode != null && this.CountryCode.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CountryCode, length must be greater than 0.", new [] { "CountryCode" });
            }

            // BankCode (string) maxLength
            if (this.BankCode != null && this.BankCode.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BankCode, length must be less than 20.", new [] { "BankCode" });
            }

            // BankCode (string) minLength
            if (this.BankCode != null && this.BankCode.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BankCode, length must be greater than 0.", new [] { "BankCode" });
            }

            // Url (string) maxLength
            if (this.Url != null && this.Url.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Url, length must be less than 255.", new [] { "Url" });
            }

            // Url (string) minLength
            if (this.Url != null && this.Url.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Url, length must be greater than 0.", new [] { "Url" });
            }

            yield break;
        }
    }

}
