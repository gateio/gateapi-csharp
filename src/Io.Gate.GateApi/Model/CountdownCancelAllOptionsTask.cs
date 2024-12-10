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
    /// Countdown cancel task detail
    /// </summary>
    [DataContract]
    public partial class CountdownCancelAllOptionsTask :  IEquatable<CountdownCancelAllOptionsTask>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CountdownCancelAllOptionsTask" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CountdownCancelAllOptionsTask() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CountdownCancelAllOptionsTask" /> class.
        /// </summary>
        /// <param name="timeout">Countdown time, in seconds  At least 5 seconds, 0 means cancel the countdown (required).</param>
        /// <param name="contract">Options contract name.</param>
        /// <param name="underlying">Underlying.</param>
        public CountdownCancelAllOptionsTask(int timeout = default(int), string contract = default(string), string underlying = default(string))
        {
            this.Timeout = timeout;
            this.Contract = contract;
            this.Underlying = underlying;
        }

        /// <summary>
        /// Countdown time, in seconds  At least 5 seconds, 0 means cancel the countdown
        /// </summary>
        /// <value>Countdown time, in seconds  At least 5 seconds, 0 means cancel the countdown</value>
        [DataMember(Name="timeout")]
        public int Timeout { get; set; }

        /// <summary>
        /// Options contract name
        /// </summary>
        /// <value>Options contract name</value>
        [DataMember(Name="contract")]
        public string Contract { get; set; }

        /// <summary>
        /// Underlying
        /// </summary>
        /// <value>Underlying</value>
        [DataMember(Name="underlying")]
        public string Underlying { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CountdownCancelAllOptionsTask {\n");
            sb.Append("  Timeout: ").Append(Timeout).Append("\n");
            sb.Append("  Contract: ").Append(Contract).Append("\n");
            sb.Append("  Underlying: ").Append(Underlying).Append("\n");
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
            return this.Equals(input as CountdownCancelAllOptionsTask);
        }

        /// <summary>
        /// Returns true if CountdownCancelAllOptionsTask instances are equal
        /// </summary>
        /// <param name="input">Instance of CountdownCancelAllOptionsTask to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CountdownCancelAllOptionsTask input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Timeout == input.Timeout ||
                    this.Timeout.Equals(input.Timeout)
                ) && 
                (
                    this.Contract == input.Contract ||
                    (this.Contract != null &&
                    this.Contract.Equals(input.Contract))
                ) && 
                (
                    this.Underlying == input.Underlying ||
                    (this.Underlying != null &&
                    this.Underlying.Equals(input.Underlying))
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
                hashCode = hashCode * 59 + this.Timeout.GetHashCode();
                if (this.Contract != null)
                    hashCode = hashCode * 59 + this.Contract.GetHashCode();
                if (this.Underlying != null)
                    hashCode = hashCode * 59 + this.Underlying.GetHashCode();
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
