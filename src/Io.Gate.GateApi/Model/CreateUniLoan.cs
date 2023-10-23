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
    /// Borrow or repay
    /// </summary>
    [DataContract]
    public partial class CreateUniLoan :  IEquatable<CreateUniLoan>, IValidatableObject
    {
        /// <summary>
        /// type: borrow - borrow, repay - repay
        /// </summary>
        /// <value>type: borrow - borrow, repay - repay</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Borrow for value: borrow
            /// </summary>
            [EnumMember(Value = "borrow")]
            Borrow = 1,

            /// <summary>
            /// Enum Repay for value: repay
            /// </summary>
            [EnumMember(Value = "repay")]
            Repay = 2

        }

        /// <summary>
        /// type: borrow - borrow, repay - repay
        /// </summary>
        /// <value>type: borrow - borrow, repay - repay</value>
        [DataMember(Name="type")]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUniLoan" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateUniLoan() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUniLoan" /> class.
        /// </summary>
        /// <param name="currency">Currency (required).</param>
        /// <param name="type">type: borrow - borrow, repay - repay (required).</param>
        /// <param name="amount">The amount of lending or repaying (required).</param>
        /// <param name="repaidAll">Full repayment.  Repay operation only.  If the value is &#x60;true&#x60;, the amount will be ignored and the loan will be repaid in full..</param>
        /// <param name="currencyPair">Currency pair (required).</param>
        public CreateUniLoan(string currency = default(string), TypeEnum type = default(TypeEnum), string amount = default(string), bool repaidAll = default(bool), string currencyPair = default(string))
        {
            // to ensure "currency" is required (not null)
            this.Currency = currency ?? throw new ArgumentNullException("currency", "currency is a required property for CreateUniLoan and cannot be null");
            this.Type = type;
            // to ensure "amount" is required (not null)
            this.Amount = amount ?? throw new ArgumentNullException("amount", "amount is a required property for CreateUniLoan and cannot be null");
            // to ensure "currencyPair" is required (not null)
            this.CurrencyPair = currencyPair ?? throw new ArgumentNullException("currencyPair", "currencyPair is a required property for CreateUniLoan and cannot be null");
            this.RepaidAll = repaidAll;
        }

        /// <summary>
        /// Currency
        /// </summary>
        /// <value>Currency</value>
        [DataMember(Name="currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The amount of lending or repaying
        /// </summary>
        /// <value>The amount of lending or repaying</value>
        [DataMember(Name="amount")]
        public string Amount { get; set; }

        /// <summary>
        /// Full repayment.  Repay operation only.  If the value is &#x60;true&#x60;, the amount will be ignored and the loan will be repaid in full.
        /// </summary>
        /// <value>Full repayment.  Repay operation only.  If the value is &#x60;true&#x60;, the amount will be ignored and the loan will be repaid in full.</value>
        [DataMember(Name="repaid_all")]
        public bool RepaidAll { get; set; }

        /// <summary>
        /// Currency pair
        /// </summary>
        /// <value>Currency pair</value>
        [DataMember(Name="currency_pair")]
        public string CurrencyPair { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateUniLoan {\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  RepaidAll: ").Append(RepaidAll).Append("\n");
            sb.Append("  CurrencyPair: ").Append(CurrencyPair).Append("\n");
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
            return this.Equals(input as CreateUniLoan);
        }

        /// <summary>
        /// Returns true if CreateUniLoan instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateUniLoan to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateUniLoan input)
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
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.RepaidAll == input.RepaidAll ||
                    this.RepaidAll.Equals(input.RepaidAll)
                ) && 
                (
                    this.CurrencyPair == input.CurrencyPair ||
                    (this.CurrencyPair != null &&
                    this.CurrencyPair.Equals(input.CurrencyPair))
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
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                hashCode = hashCode * 59 + this.RepaidAll.GetHashCode();
                if (this.CurrencyPair != null)
                    hashCode = hashCode * 59 + this.CurrencyPair.GetHashCode();
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