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
    /// CurrencyChain
    /// </summary>
    [DataContract]
    public partial class CurrencyChain :  IEquatable<CurrencyChain>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CurrencyChain" /> class.
        /// </summary>
        /// <param name="chain">Chain name.</param>
        /// <param name="nameCn">Chain name in Chinese.</param>
        /// <param name="nameEn">Chain name in English.</param>
        /// <param name="isDisabled">If it is disabled. 0 means NOT being disabled.</param>
        public CurrencyChain(string chain = default(string), string nameCn = default(string), string nameEn = default(string), int isDisabled = default(int))
        {
            this.Chain = chain;
            this.NameCn = nameCn;
            this.NameEn = nameEn;
            this.IsDisabled = isDisabled;
        }

        /// <summary>
        /// Chain name
        /// </summary>
        /// <value>Chain name</value>
        [DataMember(Name="chain")]
        public string Chain { get; set; }

        /// <summary>
        /// Chain name in Chinese
        /// </summary>
        /// <value>Chain name in Chinese</value>
        [DataMember(Name="name_cn")]
        public string NameCn { get; set; }

        /// <summary>
        /// Chain name in English
        /// </summary>
        /// <value>Chain name in English</value>
        [DataMember(Name="name_en")]
        public string NameEn { get; set; }

        /// <summary>
        /// If it is disabled. 0 means NOT being disabled
        /// </summary>
        /// <value>If it is disabled. 0 means NOT being disabled</value>
        [DataMember(Name="is_disabled")]
        public int IsDisabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CurrencyChain {\n");
            sb.Append("  Chain: ").Append(Chain).Append("\n");
            sb.Append("  NameCn: ").Append(NameCn).Append("\n");
            sb.Append("  NameEn: ").Append(NameEn).Append("\n");
            sb.Append("  IsDisabled: ").Append(IsDisabled).Append("\n");
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
            return this.Equals(input as CurrencyChain);
        }

        /// <summary>
        /// Returns true if CurrencyChain instances are equal
        /// </summary>
        /// <param name="input">Instance of CurrencyChain to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CurrencyChain input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Chain == input.Chain ||
                    (this.Chain != null &&
                    this.Chain.Equals(input.Chain))
                ) && 
                (
                    this.NameCn == input.NameCn ||
                    (this.NameCn != null &&
                    this.NameCn.Equals(input.NameCn))
                ) && 
                (
                    this.NameEn == input.NameEn ||
                    (this.NameEn != null &&
                    this.NameEn.Equals(input.NameEn))
                ) && 
                (
                    this.IsDisabled == input.IsDisabled ||
                    this.IsDisabled.Equals(input.IsDisabled)
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
                if (this.Chain != null)
                    hashCode = hashCode * 59 + this.Chain.GetHashCode();
                if (this.NameCn != null)
                    hashCode = hashCode * 59 + this.NameCn.GetHashCode();
                if (this.NameEn != null)
                    hashCode = hashCode * 59 + this.NameEn.GetHashCode();
                hashCode = hashCode * 59 + this.IsDisabled.GetHashCode();
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