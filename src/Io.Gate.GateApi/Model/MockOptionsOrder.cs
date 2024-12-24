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
    /// Option orders
    /// </summary>
    [DataContract]
    public partial class MockOptionsOrder :  IEquatable<MockOptionsOrder>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MockOptionsOrder" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MockOptionsOrder() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MockOptionsOrder" /> class.
        /// </summary>
        /// <param name="optionsName">Option name, currently only supports options for BTC and ETH with USDT. (required).</param>
        /// <param name="size">Initial order quantity, not involved in actual calculation (required).</param>
        /// <param name="left">Unfilled contract quantity, involved in actual calculation (required).</param>
        public MockOptionsOrder(string optionsName = default(string), string size = default(string), string left = default(string))
        {
            // to ensure "optionsName" is required (not null)
            this.OptionsName = optionsName ?? throw new ArgumentNullException("optionsName", "optionsName is a required property for MockOptionsOrder and cannot be null");
            // to ensure "size" is required (not null)
            this.Size = size ?? throw new ArgumentNullException("size", "size is a required property for MockOptionsOrder and cannot be null");
            // to ensure "left" is required (not null)
            this.Left = left ?? throw new ArgumentNullException("left", "left is a required property for MockOptionsOrder and cannot be null");
        }

        /// <summary>
        /// Option name, currently only supports options for BTC and ETH with USDT.
        /// </summary>
        /// <value>Option name, currently only supports options for BTC and ETH with USDT.</value>
        [DataMember(Name="options_name")]
        public string OptionsName { get; set; }

        /// <summary>
        /// Initial order quantity, not involved in actual calculation
        /// </summary>
        /// <value>Initial order quantity, not involved in actual calculation</value>
        [DataMember(Name="size")]
        public string Size { get; set; }

        /// <summary>
        /// Unfilled contract quantity, involved in actual calculation
        /// </summary>
        /// <value>Unfilled contract quantity, involved in actual calculation</value>
        [DataMember(Name="left")]
        public string Left { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MockOptionsOrder {\n");
            sb.Append("  OptionsName: ").Append(OptionsName).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Left: ").Append(Left).Append("\n");
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
            return this.Equals(input as MockOptionsOrder);
        }

        /// <summary>
        /// Returns true if MockOptionsOrder instances are equal
        /// </summary>
        /// <param name="input">Instance of MockOptionsOrder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MockOptionsOrder input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OptionsName == input.OptionsName ||
                    (this.OptionsName != null &&
                    this.OptionsName.Equals(input.OptionsName))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.Left == input.Left ||
                    (this.Left != null &&
                    this.Left.Equals(input.Left))
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
                if (this.OptionsName != null)
                    hashCode = hashCode * 59 + this.OptionsName.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.Left != null)
                    hashCode = hashCode * 59 + this.Left.GetHashCode();
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
