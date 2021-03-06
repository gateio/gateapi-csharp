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
    /// Margin account detail. &#x60;base&#x60; refers to base currency, while &#x60;quotes to quote currency
    /// </summary>
    [DataContract]
    public partial class MarginAccount :  IEquatable<MarginAccount>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarginAccount" /> class.
        /// </summary>
        /// <param name="currencyPair">Currency pair.</param>
        /// <param name="_base">_base.</param>
        /// <param name="quote">quote.</param>
        public MarginAccount(string currencyPair = default(string), MarginAccountCurrency _base = default(MarginAccountCurrency), MarginAccountCurrency quote = default(MarginAccountCurrency))
        {
            this.CurrencyPair = currencyPair;
            this.Base = _base;
            this.Quote = quote;
        }

        /// <summary>
        /// Currency pair
        /// </summary>
        /// <value>Currency pair</value>
        [DataMember(Name="currency_pair", EmitDefaultValue=false)]
        public string CurrencyPair { get; set; }

        /// <summary>
        /// Gets or Sets Base
        /// </summary>
        [DataMember(Name="base", EmitDefaultValue=false)]
        public MarginAccountCurrency Base { get; set; }

        /// <summary>
        /// Gets or Sets Quote
        /// </summary>
        [DataMember(Name="quote", EmitDefaultValue=false)]
        public MarginAccountCurrency Quote { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MarginAccount {\n");
            sb.Append("  CurrencyPair: ").Append(CurrencyPair).Append("\n");
            sb.Append("  Base: ").Append(Base).Append("\n");
            sb.Append("  Quote: ").Append(Quote).Append("\n");
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
            return this.Equals(input as MarginAccount);
        }

        /// <summary>
        /// Returns true if MarginAccount instances are equal
        /// </summary>
        /// <param name="input">Instance of MarginAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MarginAccount input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CurrencyPair == input.CurrencyPair ||
                    (this.CurrencyPair != null &&
                    this.CurrencyPair.Equals(input.CurrencyPair))
                ) && 
                (
                    this.Base == input.Base ||
                    (this.Base != null &&
                    this.Base.Equals(input.Base))
                ) && 
                (
                    this.Quote == input.Quote ||
                    (this.Quote != null &&
                    this.Quote.Equals(input.Quote))
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
                if (this.CurrencyPair != null)
                    hashCode = hashCode * 59 + this.CurrencyPair.GetHashCode();
                if (this.Base != null)
                    hashCode = hashCode * 59 + this.Base.GetHashCode();
                if (this.Quote != null)
                    hashCode = hashCode * 59 + this.Quote.GetHashCode();
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
