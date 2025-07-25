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
    /// FuturesAutoDeleverage
    /// </summary>
    [DataContract]
    public partial class FuturesAutoDeleverage :  IEquatable<FuturesAutoDeleverage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FuturesAutoDeleverage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public FuturesAutoDeleverage()
        {
        }

        /// <summary>
        /// Automatic deleveraging time.
        /// </summary>
        /// <value>Automatic deleveraging time.</value>
        [DataMember(Name="time", EmitDefaultValue=false)]
        public long Time { get; private set; }

        /// <summary>
        /// User ID.
        /// </summary>
        /// <value>User ID.</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public long User { get; private set; }

        /// <summary>
        /// Order ID. Order IDs before 2023-02-20 are null.
        /// </summary>
        /// <value>Order ID. Order IDs before 2023-02-20 are null.</value>
        [DataMember(Name="order_id", EmitDefaultValue=false)]
        public long OrderId { get; private set; }

        /// <summary>
        /// Futures contract.
        /// </summary>
        /// <value>Futures contract.</value>
        [DataMember(Name="contract", EmitDefaultValue=false)]
        public string Contract { get; private set; }

        /// <summary>
        /// Position leverage.
        /// </summary>
        /// <value>Position leverage.</value>
        [DataMember(Name="leverage", EmitDefaultValue=false)]
        public string Leverage { get; private set; }

        /// <summary>
        /// Cross margin leverage(valid only when &#x60;leverage&#x60; is 0).
        /// </summary>
        /// <value>Cross margin leverage(valid only when &#x60;leverage&#x60; is 0).</value>
        [DataMember(Name="cross_leverage_limit", EmitDefaultValue=false)]
        public string CrossLeverageLimit { get; private set; }

        /// <summary>
        /// Average entry price.
        /// </summary>
        /// <value>Average entry price.</value>
        [DataMember(Name="entry_price", EmitDefaultValue=false)]
        public string EntryPrice { get; private set; }

        /// <summary>
        /// Average fill price.
        /// </summary>
        /// <value>Average fill price.</value>
        [DataMember(Name="fill_price", EmitDefaultValue=false)]
        public string FillPrice { get; private set; }

        /// <summary>
        /// Trading size.
        /// </summary>
        /// <value>Trading size.</value>
        [DataMember(Name="trade_size", EmitDefaultValue=false)]
        public long TradeSize { get; private set; }

        /// <summary>
        /// Positions after auto-deleveraging.
        /// </summary>
        /// <value>Positions after auto-deleveraging.</value>
        [DataMember(Name="position_size", EmitDefaultValue=false)]
        public long PositionSize { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FuturesAutoDeleverage {\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  Contract: ").Append(Contract).Append("\n");
            sb.Append("  Leverage: ").Append(Leverage).Append("\n");
            sb.Append("  CrossLeverageLimit: ").Append(CrossLeverageLimit).Append("\n");
            sb.Append("  EntryPrice: ").Append(EntryPrice).Append("\n");
            sb.Append("  FillPrice: ").Append(FillPrice).Append("\n");
            sb.Append("  TradeSize: ").Append(TradeSize).Append("\n");
            sb.Append("  PositionSize: ").Append(PositionSize).Append("\n");
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
            return this.Equals(input as FuturesAutoDeleverage);
        }

        /// <summary>
        /// Returns true if FuturesAutoDeleverage instances are equal
        /// </summary>
        /// <param name="input">Instance of FuturesAutoDeleverage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FuturesAutoDeleverage input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Time == input.Time ||
                    this.Time.Equals(input.Time)
                ) && 
                (
                    this.User == input.User ||
                    this.User.Equals(input.User)
                ) && 
                (
                    this.OrderId == input.OrderId ||
                    this.OrderId.Equals(input.OrderId)
                ) && 
                (
                    this.Contract == input.Contract ||
                    (this.Contract != null &&
                    this.Contract.Equals(input.Contract))
                ) && 
                (
                    this.Leverage == input.Leverage ||
                    (this.Leverage != null &&
                    this.Leverage.Equals(input.Leverage))
                ) && 
                (
                    this.CrossLeverageLimit == input.CrossLeverageLimit ||
                    (this.CrossLeverageLimit != null &&
                    this.CrossLeverageLimit.Equals(input.CrossLeverageLimit))
                ) && 
                (
                    this.EntryPrice == input.EntryPrice ||
                    (this.EntryPrice != null &&
                    this.EntryPrice.Equals(input.EntryPrice))
                ) && 
                (
                    this.FillPrice == input.FillPrice ||
                    (this.FillPrice != null &&
                    this.FillPrice.Equals(input.FillPrice))
                ) && 
                (
                    this.TradeSize == input.TradeSize ||
                    this.TradeSize.Equals(input.TradeSize)
                ) && 
                (
                    this.PositionSize == input.PositionSize ||
                    this.PositionSize.Equals(input.PositionSize)
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
                hashCode = hashCode * 59 + this.Time.GetHashCode();
                hashCode = hashCode * 59 + this.User.GetHashCode();
                hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.Contract != null)
                    hashCode = hashCode * 59 + this.Contract.GetHashCode();
                if (this.Leverage != null)
                    hashCode = hashCode * 59 + this.Leverage.GetHashCode();
                if (this.CrossLeverageLimit != null)
                    hashCode = hashCode * 59 + this.CrossLeverageLimit.GetHashCode();
                if (this.EntryPrice != null)
                    hashCode = hashCode * 59 + this.EntryPrice.GetHashCode();
                if (this.FillPrice != null)
                    hashCode = hashCode * 59 + this.FillPrice.GetHashCode();
                hashCode = hashCode * 59 + this.TradeSize.GetHashCode();
                hashCode = hashCode * 59 + this.PositionSize.GetHashCode();
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
