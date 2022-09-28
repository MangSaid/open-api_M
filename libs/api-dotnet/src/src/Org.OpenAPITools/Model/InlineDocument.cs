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
    /// InlineDocument
    /// </summary>
    [DataContract(Name = "InlineDocument")]
    public partial class InlineDocument : IEquatable<InlineDocument>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineDocument" /> class.
        /// </summary>
        /// <param name="recordId">recordId.</param>
        /// <param name="contactCode">contactCode.</param>
        /// <param name="contactName">contactName.</param>
        /// <param name="contactAddress">contactAddress.</param>
        /// <param name="contactTaxId">contactTaxId.</param>
        /// <param name="contactBranch">contactBranch.</param>
        /// <param name="contactPerson">contactPerson.</param>
        /// <param name="contactEmail">contactEmail.</param>
        /// <param name="contactNumber">contactNumber.</param>
        /// <param name="contactZipCode">contactZipCode.</param>
        /// <param name="contactGroup">contactGroup.</param>
        /// <param name="publishedOn">publishedOn.</param>
        /// <param name="creditType">creditType.</param>
        /// <param name="creditDays">creditDays.</param>
        /// <param name="dueDate">dueDate.</param>
        /// <param name="salesName">salesName.</param>
        /// <param name="projectName">projectName.</param>
        /// <param name="reference">reference.</param>
        /// <param name="isVatInclusive">isVatInclusive.</param>
        /// <param name="useReceiptDeduction">useReceiptDeduction.</param>
        /// <param name="subTotal">subTotal.</param>
        /// <param name="discountPercentage">discountPercentage.</param>
        /// <param name="discountAmount">discountAmount.</param>
        /// <param name="totalAfterDiscount">totalAfterDiscount.</param>
        /// <param name="isVat">isVat.</param>
        /// <param name="vatAmount">vatAmount.</param>
        /// <param name="grandTotal">grandTotal.</param>
        /// <param name="documentShowWithholdingTax">documentShowWithholdingTax.</param>
        /// <param name="documentWithholdingTaxPercentage">documentWithholdingTaxPercentage.</param>
        /// <param name="documentWithholdingTaxAmount">documentWithholdingTaxAmount.</param>
        /// <param name="documentDeductionType">documentDeductionType.</param>
        /// <param name="documentDeductionAmount">documentDeductionAmount.</param>
        /// <param name="remarks">remarks.</param>
        /// <param name="internalNotes">internalNotes.</param>
        /// <param name="showSignatureOrStamp">showSignatureOrStamp.</param>
        /// <param name="documentStructureType">documentStructureType.</param>
        /// <param name="externalId">externalId.</param>
        /// <param name="saleAndPurchaseChannel">saleAndPurchaseChannel.</param>
        /// <param name="rowIndex">rowIndex.</param>
        /// <param name="discountType">discountType.</param>
        /// <param name="useInlineDiscount">useInlineDiscount.</param>
        /// <param name="useInlineVat">useInlineVat.</param>
        /// <param name="exemptAmount">exemptAmount.</param>
        /// <param name="vatableAmount">vatableAmount.</param>
        /// <param name="items">items.</param>
        /// <param name="documentReference">documentReference.</param>
        public InlineDocument(long recordId = default(long), string contactCode = default(string), string contactName = default(string), string contactAddress = default(string), string contactTaxId = default(string), string contactBranch = default(string), string contactPerson = default(string), string contactEmail = default(string), string contactNumber = default(string), string contactZipCode = default(string), int contactGroup = default(int), DateTime publishedOn = default(DateTime), int creditType = default(int), int creditDays = default(int), DateTime dueDate = default(DateTime), string salesName = default(string), string projectName = default(string), string reference = default(string), bool isVatInclusive = default(bool), bool useReceiptDeduction = default(bool), decimal subTotal = default(decimal), int discountPercentage = default(int), decimal discountAmount = default(decimal), decimal totalAfterDiscount = default(decimal), bool isVat = default(bool), decimal vatAmount = default(decimal), decimal grandTotal = default(decimal), bool documentShowWithholdingTax = default(bool), int documentWithholdingTaxPercentage = default(int), decimal documentWithholdingTaxAmount = default(decimal), int documentDeductionType = default(int), decimal documentDeductionAmount = default(decimal), string remarks = default(string), string internalNotes = default(string), bool showSignatureOrStamp = default(bool), string documentStructureType = default(string), string externalId = default(string), string saleAndPurchaseChannel = default(string), string rowIndex = default(string), int discountType = default(int), bool useInlineDiscount = default(bool), bool useInlineVat = default(bool), decimal? exemptAmount = default(decimal?), decimal? vatableAmount = default(decimal?), List<InlineProductItem> items = default(List<InlineProductItem>), List<UpgradeDocument> documentReference = default(List<UpgradeDocument>))
        {
            this.RecordId = recordId;
            this.ContactCode = contactCode;
            this.ContactName = contactName;
            this.ContactAddress = contactAddress;
            this.ContactTaxId = contactTaxId;
            this.ContactBranch = contactBranch;
            this.ContactPerson = contactPerson;
            this.ContactEmail = contactEmail;
            this.ContactNumber = contactNumber;
            this.ContactZipCode = contactZipCode;
            this.ContactGroup = contactGroup;
            this.PublishedOn = publishedOn;
            this.CreditType = creditType;
            this.CreditDays = creditDays;
            this.DueDate = dueDate;
            this.SalesName = salesName;
            this.ProjectName = projectName;
            this.Reference = reference;
            this.IsVatInclusive = isVatInclusive;
            this.UseReceiptDeduction = useReceiptDeduction;
            this.SubTotal = subTotal;
            this.DiscountPercentage = discountPercentage;
            this.DiscountAmount = discountAmount;
            this.TotalAfterDiscount = totalAfterDiscount;
            this.IsVat = isVat;
            this.VatAmount = vatAmount;
            this.GrandTotal = grandTotal;
            this.DocumentShowWithholdingTax = documentShowWithholdingTax;
            this.DocumentWithholdingTaxPercentage = documentWithholdingTaxPercentage;
            this.DocumentWithholdingTaxAmount = documentWithholdingTaxAmount;
            this.DocumentDeductionType = documentDeductionType;
            this.DocumentDeductionAmount = documentDeductionAmount;
            this.Remarks = remarks;
            this.InternalNotes = internalNotes;
            this.ShowSignatureOrStamp = showSignatureOrStamp;
            this.DocumentStructureType = documentStructureType;
            this.ExternalId = externalId;
            this.SaleAndPurchaseChannel = saleAndPurchaseChannel;
            this.RowIndex = rowIndex;
            this.DiscountType = discountType;
            this.UseInlineDiscount = useInlineDiscount;
            this.UseInlineVat = useInlineVat;
            this.ExemptAmount = exemptAmount;
            this.VatableAmount = vatableAmount;
            this.Items = items;
            this.DocumentReference = documentReference;
        }

        /// <summary>
        /// Gets or Sets RecordId
        /// </summary>
        [DataMember(Name = "recordId", EmitDefaultValue = false)]
        public long RecordId { get; set; }

        /// <summary>
        /// Gets or Sets ContactCode
        /// </summary>
        [DataMember(Name = "contactCode", EmitDefaultValue = true)]
        public string ContactCode { get; set; }

        /// <summary>
        /// Gets or Sets ContactName
        /// </summary>
        [DataMember(Name = "contactName", EmitDefaultValue = true)]
        public string ContactName { get; set; }

        /// <summary>
        /// Gets or Sets ContactAddress
        /// </summary>
        [DataMember(Name = "contactAddress", EmitDefaultValue = true)]
        public string ContactAddress { get; set; }

        /// <summary>
        /// Gets or Sets ContactTaxId
        /// </summary>
        [DataMember(Name = "contactTaxId", EmitDefaultValue = true)]
        public string ContactTaxId { get; set; }

        /// <summary>
        /// Gets or Sets ContactBranch
        /// </summary>
        [DataMember(Name = "contactBranch", EmitDefaultValue = true)]
        public string ContactBranch { get; set; }

        /// <summary>
        /// Gets or Sets ContactPerson
        /// </summary>
        [DataMember(Name = "contactPerson", EmitDefaultValue = true)]
        public string ContactPerson { get; set; }

        /// <summary>
        /// Gets or Sets ContactEmail
        /// </summary>
        [DataMember(Name = "contactEmail", EmitDefaultValue = true)]
        public string ContactEmail { get; set; }

        /// <summary>
        /// Gets or Sets ContactNumber
        /// </summary>
        [DataMember(Name = "contactNumber", EmitDefaultValue = true)]
        public string ContactNumber { get; set; }

        /// <summary>
        /// Gets or Sets ContactZipCode
        /// </summary>
        [DataMember(Name = "contactZipCode", EmitDefaultValue = true)]
        public string ContactZipCode { get; set; }

        /// <summary>
        /// Gets or Sets ContactGroup
        /// </summary>
        [DataMember(Name = "contactGroup", EmitDefaultValue = false)]
        public int ContactGroup { get; set; }

        /// <summary>
        /// Gets or Sets PublishedOn
        /// </summary>
        [DataMember(Name = "publishedOn", EmitDefaultValue = false)]
        public DateTime PublishedOn { get; set; }

        /// <summary>
        /// Gets or Sets CreditType
        /// </summary>
        [DataMember(Name = "creditType", EmitDefaultValue = false)]
        public int CreditType { get; set; }

        /// <summary>
        /// Gets or Sets CreditDays
        /// </summary>
        [DataMember(Name = "creditDays", EmitDefaultValue = false)]
        public int CreditDays { get; set; }

        /// <summary>
        /// Gets or Sets DueDate
        /// </summary>
        [DataMember(Name = "dueDate", EmitDefaultValue = false)]
        public DateTime DueDate { get; set; }

        /// <summary>
        /// Gets or Sets SalesName
        /// </summary>
        [DataMember(Name = "salesName", EmitDefaultValue = true)]
        public string SalesName { get; set; }

        /// <summary>
        /// Gets or Sets ProjectName
        /// </summary>
        [DataMember(Name = "projectName", EmitDefaultValue = true)]
        public string ProjectName { get; set; }

        /// <summary>
        /// Gets or Sets Reference
        /// </summary>
        [DataMember(Name = "reference", EmitDefaultValue = true)]
        public string Reference { get; set; }

        /// <summary>
        /// Gets or Sets IsVatInclusive
        /// </summary>
        [DataMember(Name = "isVatInclusive", EmitDefaultValue = true)]
        public bool IsVatInclusive { get; set; }

        /// <summary>
        /// Gets or Sets UseReceiptDeduction
        /// </summary>
        [DataMember(Name = "useReceiptDeduction", EmitDefaultValue = true)]
        public bool UseReceiptDeduction { get; set; }

        /// <summary>
        /// Gets or Sets SubTotal
        /// </summary>
        [DataMember(Name = "subTotal", EmitDefaultValue = false)]
        public decimal SubTotal { get; set; }

        /// <summary>
        /// Gets or Sets DiscountPercentage
        /// </summary>
        [DataMember(Name = "discountPercentage", EmitDefaultValue = false)]
        public int DiscountPercentage { get; set; }

        /// <summary>
        /// Gets or Sets DiscountAmount
        /// </summary>
        [DataMember(Name = "discountAmount", EmitDefaultValue = false)]
        public decimal DiscountAmount { get; set; }

        /// <summary>
        /// Gets or Sets TotalAfterDiscount
        /// </summary>
        [DataMember(Name = "totalAfterDiscount", EmitDefaultValue = false)]
        public decimal TotalAfterDiscount { get; set; }

        /// <summary>
        /// Gets or Sets IsVat
        /// </summary>
        [DataMember(Name = "isVat", EmitDefaultValue = true)]
        public bool IsVat { get; set; }

        /// <summary>
        /// Gets or Sets VatAmount
        /// </summary>
        [DataMember(Name = "vatAmount", EmitDefaultValue = false)]
        public decimal VatAmount { get; set; }

        /// <summary>
        /// Gets or Sets GrandTotal
        /// </summary>
        [DataMember(Name = "grandTotal", EmitDefaultValue = false)]
        public decimal GrandTotal { get; set; }

        /// <summary>
        /// Gets or Sets DocumentShowWithholdingTax
        /// </summary>
        [DataMember(Name = "documentShowWithholdingTax", EmitDefaultValue = true)]
        public bool DocumentShowWithholdingTax { get; set; }

        /// <summary>
        /// Gets or Sets DocumentWithholdingTaxPercentage
        /// </summary>
        [DataMember(Name = "documentWithholdingTaxPercentage", EmitDefaultValue = false)]
        public int DocumentWithholdingTaxPercentage { get; set; }

        /// <summary>
        /// Gets or Sets DocumentWithholdingTaxAmount
        /// </summary>
        [DataMember(Name = "documentWithholdingTaxAmount", EmitDefaultValue = false)]
        public decimal DocumentWithholdingTaxAmount { get; set; }

        /// <summary>
        /// Gets or Sets DocumentDeductionType
        /// </summary>
        [DataMember(Name = "documentDeductionType", EmitDefaultValue = false)]
        public int DocumentDeductionType { get; set; }

        /// <summary>
        /// Gets or Sets DocumentDeductionAmount
        /// </summary>
        [DataMember(Name = "documentDeductionAmount", EmitDefaultValue = false)]
        public decimal DocumentDeductionAmount { get; set; }

        /// <summary>
        /// Gets or Sets Remarks
        /// </summary>
        [DataMember(Name = "remarks", EmitDefaultValue = true)]
        public string Remarks { get; set; }

        /// <summary>
        /// Gets or Sets InternalNotes
        /// </summary>
        [DataMember(Name = "internalNotes", EmitDefaultValue = true)]
        public string InternalNotes { get; set; }

        /// <summary>
        /// Gets or Sets ShowSignatureOrStamp
        /// </summary>
        [DataMember(Name = "showSignatureOrStamp", EmitDefaultValue = true)]
        public bool ShowSignatureOrStamp { get; set; }

        /// <summary>
        /// Gets or Sets DocumentStructureType
        /// </summary>
        [DataMember(Name = "documentStructureType", EmitDefaultValue = true)]
        public string DocumentStructureType { get; set; }

        /// <summary>
        /// Gets or Sets ExternalId
        /// </summary>
        [DataMember(Name = "externalId", EmitDefaultValue = true)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Gets or Sets SaleAndPurchaseChannel
        /// </summary>
        [DataMember(Name = "saleAndPurchaseChannel", EmitDefaultValue = true)]
        public string SaleAndPurchaseChannel { get; set; }

        /// <summary>
        /// Gets or Sets RowIndex
        /// </summary>
        [DataMember(Name = "rowIndex", EmitDefaultValue = true)]
        public string RowIndex { get; set; }

        /// <summary>
        /// Gets or Sets DiscountType
        /// </summary>
        [DataMember(Name = "discountType", EmitDefaultValue = false)]
        public int DiscountType { get; set; }

        /// <summary>
        /// Gets or Sets UseInlineDiscount
        /// </summary>
        [DataMember(Name = "useInlineDiscount", EmitDefaultValue = true)]
        public bool UseInlineDiscount { get; set; }

        /// <summary>
        /// Gets or Sets UseInlineVat
        /// </summary>
        [DataMember(Name = "useInlineVat", EmitDefaultValue = true)]
        public bool UseInlineVat { get; set; }

        /// <summary>
        /// Gets or Sets ExemptAmount
        /// </summary>
        [DataMember(Name = "exemptAmount", EmitDefaultValue = true)]
        public decimal? ExemptAmount { get; set; }

        /// <summary>
        /// Gets or Sets VatableAmount
        /// </summary>
        [DataMember(Name = "vatableAmount", EmitDefaultValue = true)]
        public decimal? VatableAmount { get; set; }

        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name = "items", EmitDefaultValue = true)]
        public List<InlineProductItem> Items { get; set; }

        /// <summary>
        /// Gets or Sets DocumentReference
        /// </summary>
        [DataMember(Name = "documentReference", EmitDefaultValue = true)]
        public List<UpgradeDocument> DocumentReference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InlineDocument {\n");
            sb.Append("  RecordId: ").Append(RecordId).Append("\n");
            sb.Append("  ContactCode: ").Append(ContactCode).Append("\n");
            sb.Append("  ContactName: ").Append(ContactName).Append("\n");
            sb.Append("  ContactAddress: ").Append(ContactAddress).Append("\n");
            sb.Append("  ContactTaxId: ").Append(ContactTaxId).Append("\n");
            sb.Append("  ContactBranch: ").Append(ContactBranch).Append("\n");
            sb.Append("  ContactPerson: ").Append(ContactPerson).Append("\n");
            sb.Append("  ContactEmail: ").Append(ContactEmail).Append("\n");
            sb.Append("  ContactNumber: ").Append(ContactNumber).Append("\n");
            sb.Append("  ContactZipCode: ").Append(ContactZipCode).Append("\n");
            sb.Append("  ContactGroup: ").Append(ContactGroup).Append("\n");
            sb.Append("  PublishedOn: ").Append(PublishedOn).Append("\n");
            sb.Append("  CreditType: ").Append(CreditType).Append("\n");
            sb.Append("  CreditDays: ").Append(CreditDays).Append("\n");
            sb.Append("  DueDate: ").Append(DueDate).Append("\n");
            sb.Append("  SalesName: ").Append(SalesName).Append("\n");
            sb.Append("  ProjectName: ").Append(ProjectName).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  IsVatInclusive: ").Append(IsVatInclusive).Append("\n");
            sb.Append("  UseReceiptDeduction: ").Append(UseReceiptDeduction).Append("\n");
            sb.Append("  SubTotal: ").Append(SubTotal).Append("\n");
            sb.Append("  DiscountPercentage: ").Append(DiscountPercentage).Append("\n");
            sb.Append("  DiscountAmount: ").Append(DiscountAmount).Append("\n");
            sb.Append("  TotalAfterDiscount: ").Append(TotalAfterDiscount).Append("\n");
            sb.Append("  IsVat: ").Append(IsVat).Append("\n");
            sb.Append("  VatAmount: ").Append(VatAmount).Append("\n");
            sb.Append("  GrandTotal: ").Append(GrandTotal).Append("\n");
            sb.Append("  DocumentShowWithholdingTax: ").Append(DocumentShowWithholdingTax).Append("\n");
            sb.Append("  DocumentWithholdingTaxPercentage: ").Append(DocumentWithholdingTaxPercentage).Append("\n");
            sb.Append("  DocumentWithholdingTaxAmount: ").Append(DocumentWithholdingTaxAmount).Append("\n");
            sb.Append("  DocumentDeductionType: ").Append(DocumentDeductionType).Append("\n");
            sb.Append("  DocumentDeductionAmount: ").Append(DocumentDeductionAmount).Append("\n");
            sb.Append("  Remarks: ").Append(Remarks).Append("\n");
            sb.Append("  InternalNotes: ").Append(InternalNotes).Append("\n");
            sb.Append("  ShowSignatureOrStamp: ").Append(ShowSignatureOrStamp).Append("\n");
            sb.Append("  DocumentStructureType: ").Append(DocumentStructureType).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  SaleAndPurchaseChannel: ").Append(SaleAndPurchaseChannel).Append("\n");
            sb.Append("  RowIndex: ").Append(RowIndex).Append("\n");
            sb.Append("  DiscountType: ").Append(DiscountType).Append("\n");
            sb.Append("  UseInlineDiscount: ").Append(UseInlineDiscount).Append("\n");
            sb.Append("  UseInlineVat: ").Append(UseInlineVat).Append("\n");
            sb.Append("  ExemptAmount: ").Append(ExemptAmount).Append("\n");
            sb.Append("  VatableAmount: ").Append(VatableAmount).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  DocumentReference: ").Append(DocumentReference).Append("\n");
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
            return this.Equals(input as InlineDocument);
        }

        /// <summary>
        /// Returns true if InlineDocument instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineDocument to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineDocument input)
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
                    this.ContactCode == input.ContactCode ||
                    (this.ContactCode != null &&
                    this.ContactCode.Equals(input.ContactCode))
                ) && 
                (
                    this.ContactName == input.ContactName ||
                    (this.ContactName != null &&
                    this.ContactName.Equals(input.ContactName))
                ) && 
                (
                    this.ContactAddress == input.ContactAddress ||
                    (this.ContactAddress != null &&
                    this.ContactAddress.Equals(input.ContactAddress))
                ) && 
                (
                    this.ContactTaxId == input.ContactTaxId ||
                    (this.ContactTaxId != null &&
                    this.ContactTaxId.Equals(input.ContactTaxId))
                ) && 
                (
                    this.ContactBranch == input.ContactBranch ||
                    (this.ContactBranch != null &&
                    this.ContactBranch.Equals(input.ContactBranch))
                ) && 
                (
                    this.ContactPerson == input.ContactPerson ||
                    (this.ContactPerson != null &&
                    this.ContactPerson.Equals(input.ContactPerson))
                ) && 
                (
                    this.ContactEmail == input.ContactEmail ||
                    (this.ContactEmail != null &&
                    this.ContactEmail.Equals(input.ContactEmail))
                ) && 
                (
                    this.ContactNumber == input.ContactNumber ||
                    (this.ContactNumber != null &&
                    this.ContactNumber.Equals(input.ContactNumber))
                ) && 
                (
                    this.ContactZipCode == input.ContactZipCode ||
                    (this.ContactZipCode != null &&
                    this.ContactZipCode.Equals(input.ContactZipCode))
                ) && 
                (
                    this.ContactGroup == input.ContactGroup ||
                    this.ContactGroup.Equals(input.ContactGroup)
                ) && 
                (
                    this.PublishedOn == input.PublishedOn ||
                    (this.PublishedOn != null &&
                    this.PublishedOn.Equals(input.PublishedOn))
                ) && 
                (
                    this.CreditType == input.CreditType ||
                    this.CreditType.Equals(input.CreditType)
                ) && 
                (
                    this.CreditDays == input.CreditDays ||
                    this.CreditDays.Equals(input.CreditDays)
                ) && 
                (
                    this.DueDate == input.DueDate ||
                    (this.DueDate != null &&
                    this.DueDate.Equals(input.DueDate))
                ) && 
                (
                    this.SalesName == input.SalesName ||
                    (this.SalesName != null &&
                    this.SalesName.Equals(input.SalesName))
                ) && 
                (
                    this.ProjectName == input.ProjectName ||
                    (this.ProjectName != null &&
                    this.ProjectName.Equals(input.ProjectName))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.IsVatInclusive == input.IsVatInclusive ||
                    this.IsVatInclusive.Equals(input.IsVatInclusive)
                ) && 
                (
                    this.UseReceiptDeduction == input.UseReceiptDeduction ||
                    this.UseReceiptDeduction.Equals(input.UseReceiptDeduction)
                ) && 
                (
                    this.SubTotal == input.SubTotal ||
                    this.SubTotal.Equals(input.SubTotal)
                ) && 
                (
                    this.DiscountPercentage == input.DiscountPercentage ||
                    this.DiscountPercentage.Equals(input.DiscountPercentage)
                ) && 
                (
                    this.DiscountAmount == input.DiscountAmount ||
                    this.DiscountAmount.Equals(input.DiscountAmount)
                ) && 
                (
                    this.TotalAfterDiscount == input.TotalAfterDiscount ||
                    this.TotalAfterDiscount.Equals(input.TotalAfterDiscount)
                ) && 
                (
                    this.IsVat == input.IsVat ||
                    this.IsVat.Equals(input.IsVat)
                ) && 
                (
                    this.VatAmount == input.VatAmount ||
                    this.VatAmount.Equals(input.VatAmount)
                ) && 
                (
                    this.GrandTotal == input.GrandTotal ||
                    this.GrandTotal.Equals(input.GrandTotal)
                ) && 
                (
                    this.DocumentShowWithholdingTax == input.DocumentShowWithholdingTax ||
                    this.DocumentShowWithholdingTax.Equals(input.DocumentShowWithholdingTax)
                ) && 
                (
                    this.DocumentWithholdingTaxPercentage == input.DocumentWithholdingTaxPercentage ||
                    this.DocumentWithholdingTaxPercentage.Equals(input.DocumentWithholdingTaxPercentage)
                ) && 
                (
                    this.DocumentWithholdingTaxAmount == input.DocumentWithholdingTaxAmount ||
                    this.DocumentWithholdingTaxAmount.Equals(input.DocumentWithholdingTaxAmount)
                ) && 
                (
                    this.DocumentDeductionType == input.DocumentDeductionType ||
                    this.DocumentDeductionType.Equals(input.DocumentDeductionType)
                ) && 
                (
                    this.DocumentDeductionAmount == input.DocumentDeductionAmount ||
                    this.DocumentDeductionAmount.Equals(input.DocumentDeductionAmount)
                ) && 
                (
                    this.Remarks == input.Remarks ||
                    (this.Remarks != null &&
                    this.Remarks.Equals(input.Remarks))
                ) && 
                (
                    this.InternalNotes == input.InternalNotes ||
                    (this.InternalNotes != null &&
                    this.InternalNotes.Equals(input.InternalNotes))
                ) && 
                (
                    this.ShowSignatureOrStamp == input.ShowSignatureOrStamp ||
                    this.ShowSignatureOrStamp.Equals(input.ShowSignatureOrStamp)
                ) && 
                (
                    this.DocumentStructureType == input.DocumentStructureType ||
                    (this.DocumentStructureType != null &&
                    this.DocumentStructureType.Equals(input.DocumentStructureType))
                ) && 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && 
                (
                    this.SaleAndPurchaseChannel == input.SaleAndPurchaseChannel ||
                    (this.SaleAndPurchaseChannel != null &&
                    this.SaleAndPurchaseChannel.Equals(input.SaleAndPurchaseChannel))
                ) && 
                (
                    this.RowIndex == input.RowIndex ||
                    (this.RowIndex != null &&
                    this.RowIndex.Equals(input.RowIndex))
                ) && 
                (
                    this.DiscountType == input.DiscountType ||
                    this.DiscountType.Equals(input.DiscountType)
                ) && 
                (
                    this.UseInlineDiscount == input.UseInlineDiscount ||
                    this.UseInlineDiscount.Equals(input.UseInlineDiscount)
                ) && 
                (
                    this.UseInlineVat == input.UseInlineVat ||
                    this.UseInlineVat.Equals(input.UseInlineVat)
                ) && 
                (
                    this.ExemptAmount == input.ExemptAmount ||
                    (this.ExemptAmount != null &&
                    this.ExemptAmount.Equals(input.ExemptAmount))
                ) && 
                (
                    this.VatableAmount == input.VatableAmount ||
                    (this.VatableAmount != null &&
                    this.VatableAmount.Equals(input.VatableAmount))
                ) && 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    input.Items != null &&
                    this.Items.SequenceEqual(input.Items)
                ) && 
                (
                    this.DocumentReference == input.DocumentReference ||
                    this.DocumentReference != null &&
                    input.DocumentReference != null &&
                    this.DocumentReference.SequenceEqual(input.DocumentReference)
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
                if (this.ContactCode != null)
                {
                    hashCode = (hashCode * 59) + this.ContactCode.GetHashCode();
                }
                if (this.ContactName != null)
                {
                    hashCode = (hashCode * 59) + this.ContactName.GetHashCode();
                }
                if (this.ContactAddress != null)
                {
                    hashCode = (hashCode * 59) + this.ContactAddress.GetHashCode();
                }
                if (this.ContactTaxId != null)
                {
                    hashCode = (hashCode * 59) + this.ContactTaxId.GetHashCode();
                }
                if (this.ContactBranch != null)
                {
                    hashCode = (hashCode * 59) + this.ContactBranch.GetHashCode();
                }
                if (this.ContactPerson != null)
                {
                    hashCode = (hashCode * 59) + this.ContactPerson.GetHashCode();
                }
                if (this.ContactEmail != null)
                {
                    hashCode = (hashCode * 59) + this.ContactEmail.GetHashCode();
                }
                if (this.ContactNumber != null)
                {
                    hashCode = (hashCode * 59) + this.ContactNumber.GetHashCode();
                }
                if (this.ContactZipCode != null)
                {
                    hashCode = (hashCode * 59) + this.ContactZipCode.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ContactGroup.GetHashCode();
                if (this.PublishedOn != null)
                {
                    hashCode = (hashCode * 59) + this.PublishedOn.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CreditType.GetHashCode();
                hashCode = (hashCode * 59) + this.CreditDays.GetHashCode();
                if (this.DueDate != null)
                {
                    hashCode = (hashCode * 59) + this.DueDate.GetHashCode();
                }
                if (this.SalesName != null)
                {
                    hashCode = (hashCode * 59) + this.SalesName.GetHashCode();
                }
                if (this.ProjectName != null)
                {
                    hashCode = (hashCode * 59) + this.ProjectName.GetHashCode();
                }
                if (this.Reference != null)
                {
                    hashCode = (hashCode * 59) + this.Reference.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsVatInclusive.GetHashCode();
                hashCode = (hashCode * 59) + this.UseReceiptDeduction.GetHashCode();
                hashCode = (hashCode * 59) + this.SubTotal.GetHashCode();
                hashCode = (hashCode * 59) + this.DiscountPercentage.GetHashCode();
                hashCode = (hashCode * 59) + this.DiscountAmount.GetHashCode();
                hashCode = (hashCode * 59) + this.TotalAfterDiscount.GetHashCode();
                hashCode = (hashCode * 59) + this.IsVat.GetHashCode();
                hashCode = (hashCode * 59) + this.VatAmount.GetHashCode();
                hashCode = (hashCode * 59) + this.GrandTotal.GetHashCode();
                hashCode = (hashCode * 59) + this.DocumentShowWithholdingTax.GetHashCode();
                hashCode = (hashCode * 59) + this.DocumentWithholdingTaxPercentage.GetHashCode();
                hashCode = (hashCode * 59) + this.DocumentWithholdingTaxAmount.GetHashCode();
                hashCode = (hashCode * 59) + this.DocumentDeductionType.GetHashCode();
                hashCode = (hashCode * 59) + this.DocumentDeductionAmount.GetHashCode();
                if (this.Remarks != null)
                {
                    hashCode = (hashCode * 59) + this.Remarks.GetHashCode();
                }
                if (this.InternalNotes != null)
                {
                    hashCode = (hashCode * 59) + this.InternalNotes.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ShowSignatureOrStamp.GetHashCode();
                if (this.DocumentStructureType != null)
                {
                    hashCode = (hashCode * 59) + this.DocumentStructureType.GetHashCode();
                }
                if (this.ExternalId != null)
                {
                    hashCode = (hashCode * 59) + this.ExternalId.GetHashCode();
                }
                if (this.SaleAndPurchaseChannel != null)
                {
                    hashCode = (hashCode * 59) + this.SaleAndPurchaseChannel.GetHashCode();
                }
                if (this.RowIndex != null)
                {
                    hashCode = (hashCode * 59) + this.RowIndex.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DiscountType.GetHashCode();
                hashCode = (hashCode * 59) + this.UseInlineDiscount.GetHashCode();
                hashCode = (hashCode * 59) + this.UseInlineVat.GetHashCode();
                if (this.ExemptAmount != null)
                {
                    hashCode = (hashCode * 59) + this.ExemptAmount.GetHashCode();
                }
                if (this.VatableAmount != null)
                {
                    hashCode = (hashCode * 59) + this.VatableAmount.GetHashCode();
                }
                if (this.Items != null)
                {
                    hashCode = (hashCode * 59) + this.Items.GetHashCode();
                }
                if (this.DocumentReference != null)
                {
                    hashCode = (hashCode * 59) + this.DocumentReference.GetHashCode();
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
