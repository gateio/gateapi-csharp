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
    /// UnifiedLeverageSetting
    /// </summary>
    [DataContract]
    public partial class UnifiedLeverageSetting :  IEquatable<UnifiedLeverageSetting>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedLeverageSetting" /> class.
        /// </summary>
        /// <param name="currency">Currency name.</param>
        /// <param name="leverage">multiple.</param>
        public UnifiedLeverageSetting(string currency = default(string), string leverage = default(string))
        {
            this.Currency = currency;
            this.Leverage = leverage;
        }

        /// <summary>
        /// Currency name
        /// </summary>
        /// <value>Currency name</value>
        [DataMember(Name="currency")]
        public string Currency { get; set; }

        /// <summary>
        /// multiple
        /// </summary>
        /// <value>multiple</value>
        [DataMember(Name="leverage")]
        public string Leverage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UnifiedLeverageSetting {\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
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
            return this.Equals(input as UnifiedLeverageSetting);
        }

        /// <summary>
        /// Returns true if UnifiedLeverageSetting instances are equal
        /// </summary>
        /// <param name="input">Instance of UnifiedLeverageSetting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UnifiedLeverageSetting input)
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
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
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