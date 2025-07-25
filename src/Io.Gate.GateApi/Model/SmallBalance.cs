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
    /// Convert Small Balance.
    /// </summary>
    [DataContract]
    public partial class SmallBalance :  IEquatable<SmallBalance>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SmallBalance" /> class.
        /// </summary>
        /// <param name="currency">Currency..</param>
        /// <param name="availableBalance">Available balance..</param>
        /// <param name="estimatedAsBtc">Estimated as BTC..</param>
        /// <param name="convertibleToGt">Estimated conversion to GT..</param>
        public SmallBalance(string currency = default(string), string availableBalance = default(string), string estimatedAsBtc = default(string), string convertibleToGt = default(string))
        {
            this.Currency = currency;
            this.AvailableBalance = availableBalance;
            this.EstimatedAsBtc = estimatedAsBtc;
            this.ConvertibleToGt = convertibleToGt;
        }

        /// <summary>
        /// Currency.
        /// </summary>
        /// <value>Currency.</value>
        [DataMember(Name="currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Available balance.
        /// </summary>
        /// <value>Available balance.</value>
        [DataMember(Name="available_balance")]
        public string AvailableBalance { get; set; }

        /// <summary>
        /// Estimated as BTC.
        /// </summary>
        /// <value>Estimated as BTC.</value>
        [DataMember(Name="estimated_as_btc")]
        public string EstimatedAsBtc { get; set; }

        /// <summary>
        /// Estimated conversion to GT.
        /// </summary>
        /// <value>Estimated conversion to GT.</value>
        [DataMember(Name="convertible_to_gt")]
        public string ConvertibleToGt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SmallBalance {\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  AvailableBalance: ").Append(AvailableBalance).Append("\n");
            sb.Append("  EstimatedAsBtc: ").Append(EstimatedAsBtc).Append("\n");
            sb.Append("  ConvertibleToGt: ").Append(ConvertibleToGt).Append("\n");
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
            return this.Equals(input as SmallBalance);
        }

        /// <summary>
        /// Returns true if SmallBalance instances are equal
        /// </summary>
        /// <param name="input">Instance of SmallBalance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SmallBalance input)
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
                    this.AvailableBalance == input.AvailableBalance ||
                    (this.AvailableBalance != null &&
                    this.AvailableBalance.Equals(input.AvailableBalance))
                ) && 
                (
                    this.EstimatedAsBtc == input.EstimatedAsBtc ||
                    (this.EstimatedAsBtc != null &&
                    this.EstimatedAsBtc.Equals(input.EstimatedAsBtc))
                ) && 
                (
                    this.ConvertibleToGt == input.ConvertibleToGt ||
                    (this.ConvertibleToGt != null &&
                    this.ConvertibleToGt.Equals(input.ConvertibleToGt))
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
                if (this.AvailableBalance != null)
                    hashCode = hashCode * 59 + this.AvailableBalance.GetHashCode();
                if (this.EstimatedAsBtc != null)
                    hashCode = hashCode * 59 + this.EstimatedAsBtc.GetHashCode();
                if (this.ConvertibleToGt != null)
                    hashCode = hashCode * 59 + this.ConvertibleToGt.GetHashCode();
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
