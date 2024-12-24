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
    /// SpotPriceTrigger
    /// </summary>
    [DataContract]
    public partial class SpotPriceTrigger :  IEquatable<SpotPriceTrigger>, IValidatableObject
    {
        /// <summary>
        /// Price trigger condition  - &gt;&#x3D;: triggered when market price larger than or equal to &#x60;price&#x60; field - &lt;&#x3D;: triggered when market price less than or equal to &#x60;price&#x60; field 
        /// </summary>
        /// <value>Price trigger condition  - &gt;&#x3D;: triggered when market price larger than or equal to &#x60;price&#x60; field - &lt;&#x3D;: triggered when market price less than or equal to &#x60;price&#x60; field </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RuleEnum
        {
            /// <summary>
            /// Enum GreaterThanOrEqualTo for value: >=
            /// </summary>
            [EnumMember(Value = ">=")]
            GreaterThanOrEqualTo = 1,

            /// <summary>
            /// Enum LessThanOrEqualTo for value: <=
            /// </summary>
            [EnumMember(Value = "<=")]
            LessThanOrEqualTo = 2

        }

        /// <summary>
        /// Price trigger condition  - &gt;&#x3D;: triggered when market price larger than or equal to &#x60;price&#x60; field - &lt;&#x3D;: triggered when market price less than or equal to &#x60;price&#x60; field 
        /// </summary>
        /// <value>Price trigger condition  - &gt;&#x3D;: triggered when market price larger than or equal to &#x60;price&#x60; field - &lt;&#x3D;: triggered when market price less than or equal to &#x60;price&#x60; field </value>
        [DataMember(Name="rule")]
        public RuleEnum Rule { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SpotPriceTrigger" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SpotPriceTrigger() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SpotPriceTrigger" /> class.
        /// </summary>
        /// <param name="price">Trigger price (required).</param>
        /// <param name="rule">Price trigger condition  - &gt;&#x3D;: triggered when market price larger than or equal to &#x60;price&#x60; field - &lt;&#x3D;: triggered when market price less than or equal to &#x60;price&#x60; field  (required).</param>
        /// <param name="expiration">How long (in seconds) to wait for the condition to be triggered before cancelling the order. (required).</param>
        public SpotPriceTrigger(string price = default(string), RuleEnum rule = default(RuleEnum), int expiration = default(int))
        {
            // to ensure "price" is required (not null)
            this.Price = price ?? throw new ArgumentNullException("price", "price is a required property for SpotPriceTrigger and cannot be null");
            this.Rule = rule;
            this.Expiration = expiration;
        }

        /// <summary>
        /// Trigger price
        /// </summary>
        /// <value>Trigger price</value>
        [DataMember(Name="price")]
        public string Price { get; set; }

        /// <summary>
        /// How long (in seconds) to wait for the condition to be triggered before cancelling the order.
        /// </summary>
        /// <value>How long (in seconds) to wait for the condition to be triggered before cancelling the order.</value>
        [DataMember(Name="expiration")]
        public int Expiration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SpotPriceTrigger {\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Rule: ").Append(Rule).Append("\n");
            sb.Append("  Expiration: ").Append(Expiration).Append("\n");
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
            return this.Equals(input as SpotPriceTrigger);
        }

        /// <summary>
        /// Returns true if SpotPriceTrigger instances are equal
        /// </summary>
        /// <param name="input">Instance of SpotPriceTrigger to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SpotPriceTrigger input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.Rule == input.Rule ||
                    this.Rule.Equals(input.Rule)
                ) && 
                (
                    this.Expiration == input.Expiration ||
                    this.Expiration.Equals(input.Expiration)
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
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
                hashCode = hashCode * 59 + this.Rule.GetHashCode();
                hashCode = hashCode * 59 + this.Expiration.GetHashCode();
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
