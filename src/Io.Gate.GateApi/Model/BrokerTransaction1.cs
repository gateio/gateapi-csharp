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
    /// BrokerTransaction1
    /// </summary>
    [DataContract]
    public partial class BrokerTransaction1 :  IEquatable<BrokerTransaction1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BrokerTransaction1" /> class.
        /// </summary>
        /// <param name="transactionTime">Transaction Time. (unix timestamp)..</param>
        /// <param name="userId">User ID..</param>
        /// <param name="groupName">Group name..</param>
        /// <param name="fee">fee (usdt)..</param>
        /// <param name="currencyPair">Currency pair..</param>
        /// <param name="amount">Commission Amount..</param>
        /// <param name="feeAsset">Fee currency..</param>
        /// <param name="source">Rebate Type: Spot、Futures、Options.、Alpha.</param>
        /// <param name="subBrokerInfo">subBrokerInfo.</param>
        /// <param name="alphaContractAddr">Alpha token address.</param>
        public BrokerTransaction1(long transactionTime = default(long), long userId = default(long), string groupName = default(string), string fee = default(string), string currencyPair = default(string), string amount = default(string), string feeAsset = default(string), string source = default(string), BrokerCommissionSubBrokerInfo subBrokerInfo = default(BrokerCommissionSubBrokerInfo), string alphaContractAddr = default(string))
        {
            this.TransactionTime = transactionTime;
            this.UserId = userId;
            this.GroupName = groupName;
            this.Fee = fee;
            this.CurrencyPair = currencyPair;
            this.Amount = amount;
            this.FeeAsset = feeAsset;
            this.Source = source;
            this.SubBrokerInfo = subBrokerInfo;
            this.AlphaContractAddr = alphaContractAddr;
        }

        /// <summary>
        /// Transaction Time. (unix timestamp).
        /// </summary>
        /// <value>Transaction Time. (unix timestamp).</value>
        [DataMember(Name="transaction_time")]
        public long TransactionTime { get; set; }

        /// <summary>
        /// User ID.
        /// </summary>
        /// <value>User ID.</value>
        [DataMember(Name="user_id")]
        public long UserId { get; set; }

        /// <summary>
        /// Group name.
        /// </summary>
        /// <value>Group name.</value>
        [DataMember(Name="group_name")]
        public string GroupName { get; set; }

        /// <summary>
        /// fee (usdt).
        /// </summary>
        /// <value>fee (usdt).</value>
        [DataMember(Name="fee")]
        public string Fee { get; set; }

        /// <summary>
        /// Currency pair.
        /// </summary>
        /// <value>Currency pair.</value>
        [DataMember(Name="currency_pair")]
        public string CurrencyPair { get; set; }

        /// <summary>
        /// Commission Amount.
        /// </summary>
        /// <value>Commission Amount.</value>
        [DataMember(Name="amount")]
        public string Amount { get; set; }

        /// <summary>
        /// Fee currency.
        /// </summary>
        /// <value>Fee currency.</value>
        [DataMember(Name="fee_asset")]
        public string FeeAsset { get; set; }

        /// <summary>
        /// Rebate Type: Spot、Futures、Options.、Alpha
        /// </summary>
        /// <value>Rebate Type: Spot、Futures、Options.、Alpha</value>
        [DataMember(Name="source")]
        public string Source { get; set; }

        /// <summary>
        /// Gets or Sets SubBrokerInfo
        /// </summary>
        [DataMember(Name="sub_broker_info")]
        public BrokerCommissionSubBrokerInfo SubBrokerInfo { get; set; }

        /// <summary>
        /// Alpha token address
        /// </summary>
        /// <value>Alpha token address</value>
        [DataMember(Name="alpha_contract_addr")]
        public string AlphaContractAddr { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BrokerTransaction1 {\n");
            sb.Append("  TransactionTime: ").Append(TransactionTime).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  GroupName: ").Append(GroupName).Append("\n");
            sb.Append("  Fee: ").Append(Fee).Append("\n");
            sb.Append("  CurrencyPair: ").Append(CurrencyPair).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  FeeAsset: ").Append(FeeAsset).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  SubBrokerInfo: ").Append(SubBrokerInfo).Append("\n");
            sb.Append("  AlphaContractAddr: ").Append(AlphaContractAddr).Append("\n");
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
            return this.Equals(input as BrokerTransaction1);
        }

        /// <summary>
        /// Returns true if BrokerTransaction1 instances are equal
        /// </summary>
        /// <param name="input">Instance of BrokerTransaction1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BrokerTransaction1 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TransactionTime == input.TransactionTime ||
                    this.TransactionTime.Equals(input.TransactionTime)
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
                    this.Fee == input.Fee ||
                    (this.Fee != null &&
                    this.Fee.Equals(input.Fee))
                ) && 
                (
                    this.CurrencyPair == input.CurrencyPair ||
                    (this.CurrencyPair != null &&
                    this.CurrencyPair.Equals(input.CurrencyPair))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.FeeAsset == input.FeeAsset ||
                    (this.FeeAsset != null &&
                    this.FeeAsset.Equals(input.FeeAsset))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.SubBrokerInfo == input.SubBrokerInfo ||
                    (this.SubBrokerInfo != null &&
                    this.SubBrokerInfo.Equals(input.SubBrokerInfo))
                ) && 
                (
                    this.AlphaContractAddr == input.AlphaContractAddr ||
                    (this.AlphaContractAddr != null &&
                    this.AlphaContractAddr.Equals(input.AlphaContractAddr))
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
                hashCode = hashCode * 59 + this.TransactionTime.GetHashCode();
                hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.GroupName != null)
                    hashCode = hashCode * 59 + this.GroupName.GetHashCode();
                if (this.Fee != null)
                    hashCode = hashCode * 59 + this.Fee.GetHashCode();
                if (this.CurrencyPair != null)
                    hashCode = hashCode * 59 + this.CurrencyPair.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.FeeAsset != null)
                    hashCode = hashCode * 59 + this.FeeAsset.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.SubBrokerInfo != null)
                    hashCode = hashCode * 59 + this.SubBrokerInfo.GetHashCode();
                if (this.AlphaContractAddr != null)
                    hashCode = hashCode * 59 + this.AlphaContractAddr.GetHashCode();
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
