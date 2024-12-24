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
    /// SpotInsuranceHistory
    /// </summary>
    [DataContract]
    public partial class SpotInsuranceHistory :  IEquatable<SpotInsuranceHistory>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpotInsuranceHistory" /> class.
        /// </summary>
        /// <param name="currency">Currency.</param>
        /// <param name="balance">余额.</param>
        /// <param name="time">Creation time, timestamp, milliseconds.</param>
        public SpotInsuranceHistory(string currency = default(string), string balance = default(string), long time = default(long))
        {
            this.Currency = currency;
            this.Balance = balance;
            this.Time = time;
        }

        /// <summary>
        /// Currency
        /// </summary>
        /// <value>Currency</value>
        [DataMember(Name="currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 余额
        /// </summary>
        /// <value>余额</value>
        [DataMember(Name="balance")]
        public string Balance { get; set; }

        /// <summary>
        /// Creation time, timestamp, milliseconds
        /// </summary>
        /// <value>Creation time, timestamp, milliseconds</value>
        [DataMember(Name="time")]
        public long Time { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SpotInsuranceHistory {\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
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
            return this.Equals(input as SpotInsuranceHistory);
        }

        /// <summary>
        /// Returns true if SpotInsuranceHistory instances are equal
        /// </summary>
        /// <param name="input">Instance of SpotInsuranceHistory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SpotInsuranceHistory input)
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
                    this.Balance == input.Balance ||
                    (this.Balance != null &&
                    this.Balance.Equals(input.Balance))
                ) && 
                (
                    this.Time == input.Time ||
                    this.Time.Equals(input.Time)
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
                if (this.Balance != null)
                    hashCode = hashCode * 59 + this.Balance.GetHashCode();
                hashCode = hashCode * 59 + this.Time.GetHashCode();
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
