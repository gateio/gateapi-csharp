/*
 * Gate API v4
 *
 * Welcome to Gate.io API  APIv4 provides spot, margin and futures trading operations. There are public APIs to retrieve the real-time market statistics, and private APIs which needs authentication to trade on user's behalf.
 *
 * Contact: support@mail.gate.io
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = Io.Gate.GateApi.Client.OpenAPIDateConverter;

namespace Io.Gate.GateApi.Model
{
    /// <summary>
    /// RepayRecordRepaidCurrency
    /// </summary>
    [DataContract]
    public partial class RepayRecordRepaidCurrency :  IEquatable<RepayRecordRepaidCurrency>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RepayRecordRepaidCurrency" /> class.
        /// </summary>
        /// <param name="currency">Repayment currency.</param>
        /// <param name="indexPrice">Currency Index Price.</param>
        /// <param name="repaidAmount">Repayment amount.</param>
        /// <param name="repaidPrincipal">Principal.</param>
        /// <param name="repaidInterest">Interest.</param>
        /// <param name="repaidAmountUsdt">Value of the repayment amount in USDT.</param>
        public RepayRecordRepaidCurrency(string currency = default(string), string indexPrice = default(string), string repaidAmount = default(string), string repaidPrincipal = default(string), string repaidInterest = default(string), string repaidAmountUsdt = default(string))
        {
            this.Currency = currency;
            this.IndexPrice = indexPrice;
            this.RepaidAmount = repaidAmount;
            this.RepaidPrincipal = repaidPrincipal;
            this.RepaidInterest = repaidInterest;
            this.RepaidAmountUsdt = repaidAmountUsdt;
        }

        /// <summary>
        /// Repayment currency
        /// </summary>
        /// <value>Repayment currency</value>
        [DataMember(Name="currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Currency Index Price
        /// </summary>
        /// <value>Currency Index Price</value>
        [DataMember(Name="index_price")]
        public string IndexPrice { get; set; }

        /// <summary>
        /// Repayment amount
        /// </summary>
        /// <value>Repayment amount</value>
        [DataMember(Name="repaid_amount")]
        public string RepaidAmount { get; set; }

        /// <summary>
        /// Principal
        /// </summary>
        /// <value>Principal</value>
        [DataMember(Name="repaid_principal")]
        public string RepaidPrincipal { get; set; }

        /// <summary>
        /// Interest
        /// </summary>
        /// <value>Interest</value>
        [DataMember(Name="repaid_interest")]
        public string RepaidInterest { get; set; }

        /// <summary>
        /// Value of the repayment amount in USDT
        /// </summary>
        /// <value>Value of the repayment amount in USDT</value>
        [DataMember(Name="repaid_amount_usdt")]
        public string RepaidAmountUsdt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RepayRecordRepaidCurrency {\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  IndexPrice: ").Append(IndexPrice).Append("\n");
            sb.Append("  RepaidAmount: ").Append(RepaidAmount).Append("\n");
            sb.Append("  RepaidPrincipal: ").Append(RepaidPrincipal).Append("\n");
            sb.Append("  RepaidInterest: ").Append(RepaidInterest).Append("\n");
            sb.Append("  RepaidAmountUsdt: ").Append(RepaidAmountUsdt).Append("\n");
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
            return this.Equals(input as RepayRecordRepaidCurrency);
        }

        /// <summary>
        /// Returns true if RepayRecordRepaidCurrency instances are equal
        /// </summary>
        /// <param name="input">Instance of RepayRecordRepaidCurrency to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RepayRecordRepaidCurrency input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.IndexPrice == input.IndexPrice ||
                    (this.IndexPrice != null &&
                    this.IndexPrice.Equals(input.IndexPrice))
                ) && 
                (
                    this.RepaidAmount == input.RepaidAmount ||
                    (this.RepaidAmount != null &&
                    this.RepaidAmount.Equals(input.RepaidAmount))
                ) && 
                (
                    this.RepaidPrincipal == input.RepaidPrincipal ||
                    (this.RepaidPrincipal != null &&
                    this.RepaidPrincipal.Equals(input.RepaidPrincipal))
                ) && 
                (
                    this.RepaidInterest == input.RepaidInterest ||
                    (this.RepaidInterest != null &&
                    this.RepaidInterest.Equals(input.RepaidInterest))
                ) && 
                (
                    this.RepaidAmountUsdt == input.RepaidAmountUsdt ||
                    (this.RepaidAmountUsdt != null &&
                    this.RepaidAmountUsdt.Equals(input.RepaidAmountUsdt))
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
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.IndexPrice != null)
                    hashCode = hashCode * 59 + this.IndexPrice.GetHashCode();
                if (this.RepaidAmount != null)
                    hashCode = hashCode * 59 + this.RepaidAmount.GetHashCode();
                if (this.RepaidPrincipal != null)
                    hashCode = hashCode * 59 + this.RepaidPrincipal.GetHashCode();
                if (this.RepaidInterest != null)
                    hashCode = hashCode * 59 + this.RepaidInterest.GetHashCode();
                if (this.RepaidAmountUsdt != null)
                    hashCode = hashCode * 59 + this.RepaidAmountUsdt.GetHashCode();
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
