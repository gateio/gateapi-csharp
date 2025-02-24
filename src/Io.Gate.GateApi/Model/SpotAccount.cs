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
    /// SpotAccount
    /// </summary>
    [DataContract]
    public partial class SpotAccount :  IEquatable<SpotAccount>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpotAccount" /> class.
        /// </summary>
        /// <param name="currency">Currency detail.</param>
        /// <param name="available">Available amount.</param>
        /// <param name="locked">Locked amount, used in trading.</param>
        /// <param name="updateId">Version number.</param>
        public SpotAccount(string currency = default(string), string available = default(string), string locked = default(string), long updateId = default(long))
        {
            this.Currency = currency;
            this.Available = available;
            this.Locked = locked;
            this.UpdateId = updateId;
        }

        /// <summary>
        /// Currency detail
        /// </summary>
        /// <value>Currency detail</value>
        [DataMember(Name="currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Available amount
        /// </summary>
        /// <value>Available amount</value>
        [DataMember(Name="available")]
        public string Available { get; set; }

        /// <summary>
        /// Locked amount, used in trading
        /// </summary>
        /// <value>Locked amount, used in trading</value>
        [DataMember(Name="locked")]
        public string Locked { get; set; }

        /// <summary>
        /// Version number
        /// </summary>
        /// <value>Version number</value>
        [DataMember(Name="update_id")]
        public long UpdateId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SpotAccount {\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Available: ").Append(Available).Append("\n");
            sb.Append("  Locked: ").Append(Locked).Append("\n");
            sb.Append("  UpdateId: ").Append(UpdateId).Append("\n");
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
            return this.Equals(input as SpotAccount);
        }

        /// <summary>
        /// Returns true if SpotAccount instances are equal
        /// </summary>
        /// <param name="input">Instance of SpotAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SpotAccount input)
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
                    this.Available == input.Available ||
                    (this.Available != null &&
                    this.Available.Equals(input.Available))
                ) && 
                (
                    this.Locked == input.Locked ||
                    (this.Locked != null &&
                    this.Locked.Equals(input.Locked))
                ) && 
                (
                    this.UpdateId == input.UpdateId ||
                    this.UpdateId.Equals(input.UpdateId)
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
                if (this.Available != null)
                    hashCode = hashCode * 59 + this.Available.GetHashCode();
                if (this.Locked != null)
                    hashCode = hashCode * 59 + this.Locked.GetHashCode();
                hashCode = hashCode * 59 + this.UpdateId.GetHashCode();
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
