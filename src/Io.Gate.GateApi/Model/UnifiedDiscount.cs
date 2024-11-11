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
    /// Currency discount tiers
    /// </summary>
    [DataContract]
    public partial class UnifiedDiscount :  IEquatable<UnifiedDiscount>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedDiscount" /> class.
        /// </summary>
        /// <param name="currency">Currency name.</param>
        /// <param name="discountTiers">Tiered discount.</param>
        public UnifiedDiscount(string currency = default(string), List<UnifiedDiscountTiers> discountTiers = default(List<UnifiedDiscountTiers>))
        {
            this.Currency = currency;
            this.DiscountTiers = discountTiers;
        }

        /// <summary>
        /// Currency name
        /// </summary>
        /// <value>Currency name</value>
        [DataMember(Name="currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Tiered discount
        /// </summary>
        /// <value>Tiered discount</value>
        [DataMember(Name="discount_tiers")]
        public List<UnifiedDiscountTiers> DiscountTiers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UnifiedDiscount {\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  DiscountTiers: ").Append(DiscountTiers).Append("\n");
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
            return this.Equals(input as UnifiedDiscount);
        }

        /// <summary>
        /// Returns true if UnifiedDiscount instances are equal
        /// </summary>
        /// <param name="input">Instance of UnifiedDiscount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UnifiedDiscount input)
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
                    this.DiscountTiers == input.DiscountTiers ||
                    this.DiscountTiers != null &&
                    input.DiscountTiers != null &&
                    this.DiscountTiers.SequenceEqual(input.DiscountTiers)
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
                if (this.DiscountTiers != null)
                    hashCode = hashCode * 59 + this.DiscountTiers.GetHashCode();
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