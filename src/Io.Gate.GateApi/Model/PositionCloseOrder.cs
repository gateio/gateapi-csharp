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
    /// Current close order if any, or &#x60;null&#x60;.
    /// </summary>
    [DataContract]
    public partial class PositionCloseOrder :  IEquatable<PositionCloseOrder>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PositionCloseOrder" /> class.
        /// </summary>
        /// <param name="id">Close order ID..</param>
        /// <param name="price">Close order price..</param>
        /// <param name="isLiq">Is the close order from liquidation..</param>
        public PositionCloseOrder(long id = default(long), string price = default(string), bool isLiq = default(bool))
        {
            this.Id = id;
            this.Price = price;
            this.IsLiq = isLiq;
        }

        /// <summary>
        /// Close order ID.
        /// </summary>
        /// <value>Close order ID.</value>
        [DataMember(Name="id")]
        public long Id { get; set; }

        /// <summary>
        /// Close order price.
        /// </summary>
        /// <value>Close order price.</value>
        [DataMember(Name="price")]
        public string Price { get; set; }

        /// <summary>
        /// Is the close order from liquidation.
        /// </summary>
        /// <value>Is the close order from liquidation.</value>
        [DataMember(Name="is_liq")]
        public bool IsLiq { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PositionCloseOrder {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  IsLiq: ").Append(IsLiq).Append("\n");
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
            return this.Equals(input as PositionCloseOrder);
        }

        /// <summary>
        /// Returns true if PositionCloseOrder instances are equal
        /// </summary>
        /// <param name="input">Instance of PositionCloseOrder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PositionCloseOrder input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.IsLiq == input.IsLiq ||
                    this.IsLiq.Equals(input.IsLiq)
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
                hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
                hashCode = hashCode * 59 + this.IsLiq.GetHashCode();
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
