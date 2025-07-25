/*
 * Gate API
 *
 * Welcome to Gate API  APIv4 provides operations related to spot, margin, and contract trading, including public interfaces for querying market data and authenticated private interfaces for implementing API-based automated trading.
 *
 * Contact: support@mail.gate.com
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
    /// Accounts available to transfer:  - &#x60;spot&#x60;: spot account - &#x60;margin&#x60;: margin account - &#x60;futures&#x60;: perpetual futures account - &#x60;delivery&#x60;: delivery futures account - &#x60;options&#x60;: options account
    /// </summary>
    [DataContract]
    public partial class Transfer :  IEquatable<Transfer>, IValidatableObject
    {
        /// <summary>
        /// Account to transfer from.
        /// </summary>
        /// <value>Account to transfer from.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FromEnum
        {
            /// <summary>
            /// Enum Spot for value: spot
            /// </summary>
            [EnumMember(Value = "spot")]
            Spot = 1,

            /// <summary>
            /// Enum Margin for value: margin
            /// </summary>
            [EnumMember(Value = "margin")]
            Margin = 2,

            /// <summary>
            /// Enum Futures for value: futures
            /// </summary>
            [EnumMember(Value = "futures")]
            Futures = 3,

            /// <summary>
            /// Enum Delivery for value: delivery
            /// </summary>
            [EnumMember(Value = "delivery")]
            Delivery = 4,

            /// <summary>
            /// Enum Options for value: options
            /// </summary>
            [EnumMember(Value = "options")]
            Options = 5

        }

        /// <summary>
        /// Account to transfer from.
        /// </summary>
        /// <value>Account to transfer from.</value>
        [DataMember(Name="from")]
        public FromEnum From { get; set; }
        /// <summary>
        /// Account to transfer to.
        /// </summary>
        /// <value>Account to transfer to.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ToEnum
        {
            /// <summary>
            /// Enum Spot for value: spot
            /// </summary>
            [EnumMember(Value = "spot")]
            Spot = 1,

            /// <summary>
            /// Enum Margin for value: margin
            /// </summary>
            [EnumMember(Value = "margin")]
            Margin = 2,

            /// <summary>
            /// Enum Futures for value: futures
            /// </summary>
            [EnumMember(Value = "futures")]
            Futures = 3,

            /// <summary>
            /// Enum Delivery for value: delivery
            /// </summary>
            [EnumMember(Value = "delivery")]
            Delivery = 4,

            /// <summary>
            /// Enum Options for value: options
            /// </summary>
            [EnumMember(Value = "options")]
            Options = 5

        }

        /// <summary>
        /// Account to transfer to.
        /// </summary>
        /// <value>Account to transfer to.</value>
        [DataMember(Name="to")]
        public ToEnum To { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Transfer" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Transfer() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Transfer" /> class.
        /// </summary>
        /// <param name="currency">Transfer currency. For futures account, &#x60;currency&#x60; can be set to &#x60;POINT&#x60; or settle currency (required).</param>
        /// <param name="from">Account to transfer from. (required).</param>
        /// <param name="to">Account to transfer to. (required).</param>
        /// <param name="amount">Transfer amount. (required).</param>
        /// <param name="currencyPair">Margin currency pair. Required if transfer from or to margin account..</param>
        /// <param name="settle">Futures settle currency. Required if transferring from or to futures account.</param>
        public Transfer(string currency = default(string), FromEnum from = default(FromEnum), ToEnum to = default(ToEnum), string amount = default(string), string currencyPair = default(string), string settle = default(string))
        {
            // to ensure "currency" is required (not null)
            this.Currency = currency ?? throw new ArgumentNullException("currency", "currency is a required property for Transfer and cannot be null");
            this.From = from;
            this.To = to;
            // to ensure "amount" is required (not null)
            this.Amount = amount ?? throw new ArgumentNullException("amount", "amount is a required property for Transfer and cannot be null");
            this.CurrencyPair = currencyPair;
            this.Settle = settle;
        }

        /// <summary>
        /// Transfer currency. For futures account, &#x60;currency&#x60; can be set to &#x60;POINT&#x60; or settle currency
        /// </summary>
        /// <value>Transfer currency. For futures account, &#x60;currency&#x60; can be set to &#x60;POINT&#x60; or settle currency</value>
        [DataMember(Name="currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Transfer amount.
        /// </summary>
        /// <value>Transfer amount.</value>
        [DataMember(Name="amount")]
        public string Amount { get; set; }

        /// <summary>
        /// Margin currency pair. Required if transfer from or to margin account.
        /// </summary>
        /// <value>Margin currency pair. Required if transfer from or to margin account.</value>
        [DataMember(Name="currency_pair")]
        public string CurrencyPair { get; set; }

        /// <summary>
        /// Futures settle currency. Required if transferring from or to futures account
        /// </summary>
        /// <value>Futures settle currency. Required if transferring from or to futures account</value>
        [DataMember(Name="settle")]
        public string Settle { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Transfer {\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  CurrencyPair: ").Append(CurrencyPair).Append("\n");
            sb.Append("  Settle: ").Append(Settle).Append("\n");
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
            return this.Equals(input as Transfer);
        }

        /// <summary>
        /// Returns true if Transfer instances are equal
        /// </summary>
        /// <param name="input">Instance of Transfer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Transfer input)
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
                    this.From == input.From ||
                    this.From.Equals(input.From)
                ) && 
                (
                    this.To == input.To ||
                    this.To.Equals(input.To)
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.CurrencyPair == input.CurrencyPair ||
                    (this.CurrencyPair != null &&
                    this.CurrencyPair.Equals(input.CurrencyPair))
                ) && 
                (
                    this.Settle == input.Settle ||
                    (this.Settle != null &&
                    this.Settle.Equals(input.Settle))
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
                hashCode = hashCode * 59 + this.From.GetHashCode();
                hashCode = hashCode * 59 + this.To.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.CurrencyPair != null)
                    hashCode = hashCode * 59 + this.CurrencyPair.GetHashCode();
                if (this.Settle != null)
                    hashCode = hashCode * 59 + this.Settle.GetHashCode();
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
