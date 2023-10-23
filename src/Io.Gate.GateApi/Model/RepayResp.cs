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
    /// Repay
    /// </summary>
    [DataContract]
    public partial class RepayResp :  IEquatable<RepayResp>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RepayResp" /> class.
        /// </summary>
        /// <param name="repaidPrincipal">Principal.</param>
        /// <param name="repaidInterest">Interest.</param>
        public RepayResp(string repaidPrincipal = default(string), string repaidInterest = default(string))
        {
            this.RepaidPrincipal = repaidPrincipal;
            this.RepaidInterest = repaidInterest;
        }

        /// <summary>
        /// Principal
        /// </summary>
        /// <value>Principal</value>
        [DataMember(Name="repaid_principal")]
        public string RepaidPrincipal { get; set; }

        /// <summary>
        /// Interest
        /// </summary>
        /// <value>Interest</value>
        [DataMember(Name="repaid_interest")]
        public string RepaidInterest { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RepayResp {\n");
            sb.Append("  RepaidPrincipal: ").Append(RepaidPrincipal).Append("\n");
            sb.Append("  RepaidInterest: ").Append(RepaidInterest).Append("\n");
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
            return this.Equals(input as RepayResp);
        }

        /// <summary>
        /// Returns true if RepayResp instances are equal
        /// </summary>
        /// <param name="input">Instance of RepayResp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RepayResp input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RepaidPrincipal == input.RepaidPrincipal ||
                    (this.RepaidPrincipal != null &&
                    this.RepaidPrincipal.Equals(input.RepaidPrincipal))
                ) && 
                (
                    this.RepaidInterest == input.RepaidInterest ||
                    (this.RepaidInterest != null &&
                    this.RepaidInterest.Equals(input.RepaidInterest))
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
                if (this.RepaidPrincipal != null)
                    hashCode = hashCode * 59 + this.RepaidPrincipal.GetHashCode();
                if (this.RepaidInterest != null)
                    hashCode = hashCode * 59 + this.RepaidInterest.GetHashCode();
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