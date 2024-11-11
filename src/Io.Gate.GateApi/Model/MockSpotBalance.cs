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
    /// Spot
    /// </summary>
    [DataContract]
    public partial class MockSpotBalance :  IEquatable<MockSpotBalance>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MockSpotBalance" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MockSpotBalance() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MockSpotBalance" /> class.
        /// </summary>
        /// <param name="currency">Currency name (required).</param>
        /// <param name="equity">Currency equity, where equity &#x3D; balance - borrowed, represents the net delta exposure  of your spot positions, which can be negative. Currently only supports three currencies: BTC, ETH. (required).</param>
        public MockSpotBalance(string currency = default(string), string equity = default(string))
        {
            // to ensure "currency" is required (not null)
            this.Currency = currency ?? throw new ArgumentNullException("currency", "currency is a required property for MockSpotBalance and cannot be null");
            // to ensure "equity" is required (not null)
            this.Equity = equity ?? throw new ArgumentNullException("equity", "equity is a required property for MockSpotBalance and cannot be null");
        }

        /// <summary>
        /// Currency name
        /// </summary>
        /// <value>Currency name</value>
        [DataMember(Name="currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Currency equity, where equity &#x3D; balance - borrowed, represents the net delta exposure  of your spot positions, which can be negative. Currently only supports three currencies: BTC, ETH.
        /// </summary>
        /// <value>Currency equity, where equity &#x3D; balance - borrowed, represents the net delta exposure  of your spot positions, which can be negative. Currently only supports three currencies: BTC, ETH.</value>
        [DataMember(Name="equity")]
        public string Equity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MockSpotBalance {\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Equity: ").Append(Equity).Append("\n");
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
            return this.Equals(input as MockSpotBalance);
        }

        /// <summary>
        /// Returns true if MockSpotBalance instances are equal
        /// </summary>
        /// <param name="input">Instance of MockSpotBalance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MockSpotBalance input)
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
                    this.Equity == input.Equity ||
                    (this.Equity != null &&
                    this.Equity.Equals(input.Equity))
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
                if (this.Equity != null)
                    hashCode = hashCode * 59 + this.Equity.GetHashCode();
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