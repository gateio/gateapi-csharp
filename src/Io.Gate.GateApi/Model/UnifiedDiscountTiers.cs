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
    /// UnifiedDiscountTiers
    /// </summary>
    [DataContract]
    public partial class UnifiedDiscountTiers :  IEquatable<UnifiedDiscountTiers>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedDiscountTiers" /> class.
        /// </summary>
        /// <param name="tier">Tier.</param>
        /// <param name="discount">Discount.</param>
        /// <param name="lowerLimit">Lower limit.</param>
        /// <param name="upperLimit">Upper limit,＋ indicates positive infinity.</param>
        /// <param name="leverage">Position leverage.</param>
        public UnifiedDiscountTiers(string tier = default(string), string discount = default(string), string lowerLimit = default(string), string upperLimit = default(string), string leverage = default(string))
        {
            this.Tier = tier;
            this.Discount = discount;
            this.LowerLimit = lowerLimit;
            this.UpperLimit = upperLimit;
            this.Leverage = leverage;
        }

        /// <summary>
        /// Tier
        /// </summary>
        /// <value>Tier</value>
        [DataMember(Name="tier")]
        public string Tier { get; set; }

        /// <summary>
        /// Discount
        /// </summary>
        /// <value>Discount</value>
        [DataMember(Name="discount")]
        public string Discount { get; set; }

        /// <summary>
        /// Lower limit
        /// </summary>
        /// <value>Lower limit</value>
        [DataMember(Name="lower_limit")]
        public string LowerLimit { get; set; }

        /// <summary>
        /// Upper limit,＋ indicates positive infinity
        /// </summary>
        /// <value>Upper limit,＋ indicates positive infinity</value>
        [DataMember(Name="upper_limit")]
        public string UpperLimit { get; set; }

        /// <summary>
        /// Position leverage
        /// </summary>
        /// <value>Position leverage</value>
        [DataMember(Name="leverage")]
        public string Leverage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UnifiedDiscountTiers {\n");
            sb.Append("  Tier: ").Append(Tier).Append("\n");
            sb.Append("  Discount: ").Append(Discount).Append("\n");
            sb.Append("  LowerLimit: ").Append(LowerLimit).Append("\n");
            sb.Append("  UpperLimit: ").Append(UpperLimit).Append("\n");
            sb.Append("  Leverage: ").Append(Leverage).Append("\n");
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
            return this.Equals(input as UnifiedDiscountTiers);
        }

        /// <summary>
        /// Returns true if UnifiedDiscountTiers instances are equal
        /// </summary>
        /// <param name="input">Instance of UnifiedDiscountTiers to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UnifiedDiscountTiers input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Tier == input.Tier ||
                    (this.Tier != null &&
                    this.Tier.Equals(input.Tier))
                ) && 
                (
                    this.Discount == input.Discount ||
                    (this.Discount != null &&
                    this.Discount.Equals(input.Discount))
                ) && 
                (
                    this.LowerLimit == input.LowerLimit ||
                    (this.LowerLimit != null &&
                    this.LowerLimit.Equals(input.LowerLimit))
                ) && 
                (
                    this.UpperLimit == input.UpperLimit ||
                    (this.UpperLimit != null &&
                    this.UpperLimit.Equals(input.UpperLimit))
                ) && 
                (
                    this.Leverage == input.Leverage ||
                    (this.Leverage != null &&
                    this.Leverage.Equals(input.Leverage))
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
                if (this.Tier != null)
                    hashCode = hashCode * 59 + this.Tier.GetHashCode();
                if (this.Discount != null)
                    hashCode = hashCode * 59 + this.Discount.GetHashCode();
                if (this.LowerLimit != null)
                    hashCode = hashCode * 59 + this.LowerLimit.GetHashCode();
                if (this.UpperLimit != null)
                    hashCode = hashCode * 59 + this.UpperLimit.GetHashCode();
                if (this.Leverage != null)
                    hashCode = hashCode * 59 + this.Leverage.GetHashCode();
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
