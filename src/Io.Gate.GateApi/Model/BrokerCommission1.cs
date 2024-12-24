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
    /// BrokerCommission1
    /// </summary>
    [DataContract]
    public partial class BrokerCommission1 :  IEquatable<BrokerCommission1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BrokerCommission1" /> class.
        /// </summary>
        /// <param name="commissionTime">Commission Time. (unix timestamp).</param>
        /// <param name="userId">User ID.</param>
        /// <param name="groupName">Group name.</param>
        /// <param name="amount">The amount of commission rebates.</param>
        /// <param name="fee">Fee.</param>
        /// <param name="feeAsset">Fee currency.</param>
        /// <param name="rebateFee">The income from rebates, converted to USDT.</param>
        /// <param name="source">Rebate Type: Spot、Futures、Options.</param>
        /// <param name="currencyPair">Currency pair.</param>
        public BrokerCommission1(long commissionTime = default(long), long userId = default(long), string groupName = default(string), string amount = default(string), string fee = default(string), string feeAsset = default(string), string rebateFee = default(string), string source = default(string), string currencyPair = default(string))
        {
            this.CommissionTime = commissionTime;
            this.UserId = userId;
            this.GroupName = groupName;
            this.Amount = amount;
            this.Fee = fee;
            this.FeeAsset = feeAsset;
            this.RebateFee = rebateFee;
            this.Source = source;
            this.CurrencyPair = currencyPair;
        }

        /// <summary>
        /// Commission Time. (unix timestamp)
        /// </summary>
        /// <value>Commission Time. (unix timestamp)</value>
        [DataMember(Name="commission_time")]
        public long CommissionTime { get; set; }

        /// <summary>
        /// User ID
        /// </summary>
        /// <value>User ID</value>
        [DataMember(Name="user_id")]
        public long UserId { get; set; }

        /// <summary>
        /// Group name
        /// </summary>
        /// <value>Group name</value>
        [DataMember(Name="group_name")]
        public string GroupName { get; set; }

        /// <summary>
        /// The amount of commission rebates
        /// </summary>
        /// <value>The amount of commission rebates</value>
        [DataMember(Name="amount")]
        public string Amount { get; set; }

        /// <summary>
        /// Fee
        /// </summary>
        /// <value>Fee</value>
        [DataMember(Name="fee")]
        public string Fee { get; set; }

        /// <summary>
        /// Fee currency
        /// </summary>
        /// <value>Fee currency</value>
        [DataMember(Name="fee_asset")]
        public string FeeAsset { get; set; }

        /// <summary>
        /// The income from rebates, converted to USDT
        /// </summary>
        /// <value>The income from rebates, converted to USDT</value>
        [DataMember(Name="rebate_fee")]
        public string RebateFee { get; set; }

        /// <summary>
        /// Rebate Type: Spot、Futures、Options
        /// </summary>
        /// <value>Rebate Type: Spot、Futures、Options</value>
        [DataMember(Name="source")]
        public string Source { get; set; }

        /// <summary>
        /// Currency pair
        /// </summary>
        /// <value>Currency pair</value>
        [DataMember(Name="currency_pair")]
        public string CurrencyPair { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BrokerCommission1 {\n");
            sb.Append("  CommissionTime: ").Append(CommissionTime).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  GroupName: ").Append(GroupName).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Fee: ").Append(Fee).Append("\n");
            sb.Append("  FeeAsset: ").Append(FeeAsset).Append("\n");
            sb.Append("  RebateFee: ").Append(RebateFee).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  CurrencyPair: ").Append(CurrencyPair).Append("\n");
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
            return this.Equals(input as BrokerCommission1);
        }

        /// <summary>
        /// Returns true if BrokerCommission1 instances are equal
        /// </summary>
        /// <param name="input">Instance of BrokerCommission1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BrokerCommission1 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CommissionTime == input.CommissionTime ||
                    this.CommissionTime.Equals(input.CommissionTime)
                ) && 
                (
                    this.UserId == input.UserId ||
                    this.UserId.Equals(input.UserId)
                ) && 
                (
                    this.GroupName == input.GroupName ||
                    (this.GroupName != null &&
                    this.GroupName.Equals(input.GroupName))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Fee == input.Fee ||
                    (this.Fee != null &&
                    this.Fee.Equals(input.Fee))
                ) && 
                (
                    this.FeeAsset == input.FeeAsset ||
                    (this.FeeAsset != null &&
                    this.FeeAsset.Equals(input.FeeAsset))
                ) && 
                (
                    this.RebateFee == input.RebateFee ||
                    (this.RebateFee != null &&
                    this.RebateFee.Equals(input.RebateFee))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.CurrencyPair == input.CurrencyPair ||
                    (this.CurrencyPair != null &&
                    this.CurrencyPair.Equals(input.CurrencyPair))
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
                hashCode = hashCode * 59 + this.CommissionTime.GetHashCode();
                hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.GroupName != null)
                    hashCode = hashCode * 59 + this.GroupName.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.Fee != null)
                    hashCode = hashCode * 59 + this.Fee.GetHashCode();
                if (this.FeeAsset != null)
                    hashCode = hashCode * 59 + this.FeeAsset.GetHashCode();
                if (this.RebateFee != null)
                    hashCode = hashCode * 59 + this.RebateFee.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.CurrencyPair != null)
                    hashCode = hashCode * 59 + this.CurrencyPair.GetHashCode();
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
