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
    /// DualGetOrders
    /// </summary>
    [DataContract]
    public partial class DualGetOrders :  IEquatable<DualGetOrders>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DualGetOrders" /> class.
        /// </summary>
        /// <param name="id">Order ID.</param>
        /// <param name="planId">Plan ID.</param>
        /// <param name="copies">Copies.</param>
        /// <param name="investAmount">Investment Amount.</param>
        /// <param name="settlementAmount">Settlement Amount.</param>
        /// <param name="createTime">Creation time.</param>
        /// <param name="completeTime">Completion Time.</param>
        /// <param name="status">Status:  &#x60;INIT&#x60;-INIT &#x60;SETTLEMENT_SUCCESS&#x60;-Settlement Success &#x60;SETTLEMENT_PROCESSING&#x60;-SEttlement Processing &#x60;CANCELED&#x60;-Canceled &#x60;FAILED&#x60;-Failed.</param>
        /// <param name="investCurrency">Investment Currency.</param>
        /// <param name="exerciseCurrency">Strike Currency.</param>
        /// <param name="exercisePrice">Strike price.</param>
        /// <param name="settlementPrice">settlement price.</param>
        /// <param name="settlementCurrency">Settle currency.</param>
        /// <param name="apyDisplay">APY.</param>
        /// <param name="apySettlement">Settlement APY.</param>
        /// <param name="deliveryTime">Settlement time.</param>
        /// <param name="text">Custom order information.</param>
        public DualGetOrders(int id = default(int), int planId = default(int), string copies = default(string), string investAmount = default(string), string settlementAmount = default(string), int createTime = default(int), int completeTime = default(int), string status = default(string), string investCurrency = default(string), string exerciseCurrency = default(string), string exercisePrice = default(string), string settlementPrice = default(string), string settlementCurrency = default(string), string apyDisplay = default(string), string apySettlement = default(string), int deliveryTime = default(int), string text = default(string))
        {
            this.Id = id;
            this.PlanId = planId;
            this.Copies = copies;
            this.InvestAmount = investAmount;
            this.SettlementAmount = settlementAmount;
            this.CreateTime = createTime;
            this.CompleteTime = completeTime;
            this.Status = status;
            this.InvestCurrency = investCurrency;
            this.ExerciseCurrency = exerciseCurrency;
            this.ExercisePrice = exercisePrice;
            this.SettlementPrice = settlementPrice;
            this.SettlementCurrency = settlementCurrency;
            this.ApyDisplay = apyDisplay;
            this.ApySettlement = apySettlement;
            this.DeliveryTime = deliveryTime;
            this.Text = text;
        }

        /// <summary>
        /// Order ID
        /// </summary>
        /// <value>Order ID</value>
        [DataMember(Name="id")]
        public int Id { get; set; }

        /// <summary>
        /// Plan ID
        /// </summary>
        /// <value>Plan ID</value>
        [DataMember(Name="plan_id")]
        public int PlanId { get; set; }

        /// <summary>
        /// Copies
        /// </summary>
        /// <value>Copies</value>
        [DataMember(Name="copies")]
        public string Copies { get; set; }

        /// <summary>
        /// Investment Amount
        /// </summary>
        /// <value>Investment Amount</value>
        [DataMember(Name="invest_amount")]
        public string InvestAmount { get; set; }

        /// <summary>
        /// Settlement Amount
        /// </summary>
        /// <value>Settlement Amount</value>
        [DataMember(Name="settlement_amount")]
        public string SettlementAmount { get; set; }

        /// <summary>
        /// Creation time
        /// </summary>
        /// <value>Creation time</value>
        [DataMember(Name="create_time")]
        public int CreateTime { get; set; }

        /// <summary>
        /// Completion Time
        /// </summary>
        /// <value>Completion Time</value>
        [DataMember(Name="complete_time")]
        public int CompleteTime { get; set; }

        /// <summary>
        /// Status:  &#x60;INIT&#x60;-INIT &#x60;SETTLEMENT_SUCCESS&#x60;-Settlement Success &#x60;SETTLEMENT_PROCESSING&#x60;-SEttlement Processing &#x60;CANCELED&#x60;-Canceled &#x60;FAILED&#x60;-Failed
        /// </summary>
        /// <value>Status:  &#x60;INIT&#x60;-INIT &#x60;SETTLEMENT_SUCCESS&#x60;-Settlement Success &#x60;SETTLEMENT_PROCESSING&#x60;-SEttlement Processing &#x60;CANCELED&#x60;-Canceled &#x60;FAILED&#x60;-Failed</value>
        [DataMember(Name="status")]
        public string Status { get; set; }

        /// <summary>
        /// Investment Currency
        /// </summary>
        /// <value>Investment Currency</value>
        [DataMember(Name="invest_currency")]
        public string InvestCurrency { get; set; }

        /// <summary>
        /// Strike Currency
        /// </summary>
        /// <value>Strike Currency</value>
        [DataMember(Name="exercise_currency")]
        public string ExerciseCurrency { get; set; }

        /// <summary>
        /// Strike price
        /// </summary>
        /// <value>Strike price</value>
        [DataMember(Name="exercise_price")]
        public string ExercisePrice { get; set; }

        /// <summary>
        /// settlement price
        /// </summary>
        /// <value>settlement price</value>
        [DataMember(Name="settlement_price")]
        public string SettlementPrice { get; set; }

        /// <summary>
        /// Settle currency
        /// </summary>
        /// <value>Settle currency</value>
        [DataMember(Name="settlement_currency")]
        public string SettlementCurrency { get; set; }

        /// <summary>
        /// APY
        /// </summary>
        /// <value>APY</value>
        [DataMember(Name="apy_display")]
        public string ApyDisplay { get; set; }

        /// <summary>
        /// Settlement APY
        /// </summary>
        /// <value>Settlement APY</value>
        [DataMember(Name="apy_settlement")]
        public string ApySettlement { get; set; }

        /// <summary>
        /// Settlement time
        /// </summary>
        /// <value>Settlement time</value>
        [DataMember(Name="delivery_time")]
        public int DeliveryTime { get; set; }

        /// <summary>
        /// Custom order information
        /// </summary>
        /// <value>Custom order information</value>
        [DataMember(Name="text")]
        public string Text { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DualGetOrders {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PlanId: ").Append(PlanId).Append("\n");
            sb.Append("  Copies: ").Append(Copies).Append("\n");
            sb.Append("  InvestAmount: ").Append(InvestAmount).Append("\n");
            sb.Append("  SettlementAmount: ").Append(SettlementAmount).Append("\n");
            sb.Append("  CreateTime: ").Append(CreateTime).Append("\n");
            sb.Append("  CompleteTime: ").Append(CompleteTime).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  InvestCurrency: ").Append(InvestCurrency).Append("\n");
            sb.Append("  ExerciseCurrency: ").Append(ExerciseCurrency).Append("\n");
            sb.Append("  ExercisePrice: ").Append(ExercisePrice).Append("\n");
            sb.Append("  SettlementPrice: ").Append(SettlementPrice).Append("\n");
            sb.Append("  SettlementCurrency: ").Append(SettlementCurrency).Append("\n");
            sb.Append("  ApyDisplay: ").Append(ApyDisplay).Append("\n");
            sb.Append("  ApySettlement: ").Append(ApySettlement).Append("\n");
            sb.Append("  DeliveryTime: ").Append(DeliveryTime).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
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
            return this.Equals(input as DualGetOrders);
        }

        /// <summary>
        /// Returns true if DualGetOrders instances are equal
        /// </summary>
        /// <param name="input">Instance of DualGetOrders to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DualGetOrders input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.PlanId == input.PlanId ||
                    this.PlanId.Equals(input.PlanId)
                ) && 
                (
                    this.Copies == input.Copies ||
                    (this.Copies != null &&
                    this.Copies.Equals(input.Copies))
                ) && 
                (
                    this.InvestAmount == input.InvestAmount ||
                    (this.InvestAmount != null &&
                    this.InvestAmount.Equals(input.InvestAmount))
                ) && 
                (
                    this.SettlementAmount == input.SettlementAmount ||
                    (this.SettlementAmount != null &&
                    this.SettlementAmount.Equals(input.SettlementAmount))
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    this.CreateTime.Equals(input.CreateTime)
                ) && 
                (
                    this.CompleteTime == input.CompleteTime ||
                    this.CompleteTime.Equals(input.CompleteTime)
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.InvestCurrency == input.InvestCurrency ||
                    (this.InvestCurrency != null &&
                    this.InvestCurrency.Equals(input.InvestCurrency))
                ) && 
                (
                    this.ExerciseCurrency == input.ExerciseCurrency ||
                    (this.ExerciseCurrency != null &&
                    this.ExerciseCurrency.Equals(input.ExerciseCurrency))
                ) && 
                (
                    this.ExercisePrice == input.ExercisePrice ||
                    (this.ExercisePrice != null &&
                    this.ExercisePrice.Equals(input.ExercisePrice))
                ) && 
                (
                    this.SettlementPrice == input.SettlementPrice ||
                    (this.SettlementPrice != null &&
                    this.SettlementPrice.Equals(input.SettlementPrice))
                ) && 
                (
                    this.SettlementCurrency == input.SettlementCurrency ||
                    (this.SettlementCurrency != null &&
                    this.SettlementCurrency.Equals(input.SettlementCurrency))
                ) && 
                (
                    this.ApyDisplay == input.ApyDisplay ||
                    (this.ApyDisplay != null &&
                    this.ApyDisplay.Equals(input.ApyDisplay))
                ) && 
                (
                    this.ApySettlement == input.ApySettlement ||
                    (this.ApySettlement != null &&
                    this.ApySettlement.Equals(input.ApySettlement))
                ) && 
                (
                    this.DeliveryTime == input.DeliveryTime ||
                    this.DeliveryTime.Equals(input.DeliveryTime)
                ) && 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
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
                hashCode = hashCode * 59 + this.PlanId.GetHashCode();
                if (this.Copies != null)
                    hashCode = hashCode * 59 + this.Copies.GetHashCode();
                if (this.InvestAmount != null)
                    hashCode = hashCode * 59 + this.InvestAmount.GetHashCode();
                if (this.SettlementAmount != null)
                    hashCode = hashCode * 59 + this.SettlementAmount.GetHashCode();
                hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                hashCode = hashCode * 59 + this.CompleteTime.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.InvestCurrency != null)
                    hashCode = hashCode * 59 + this.InvestCurrency.GetHashCode();
                if (this.ExerciseCurrency != null)
                    hashCode = hashCode * 59 + this.ExerciseCurrency.GetHashCode();
                if (this.ExercisePrice != null)
                    hashCode = hashCode * 59 + this.ExercisePrice.GetHashCode();
                if (this.SettlementPrice != null)
                    hashCode = hashCode * 59 + this.SettlementPrice.GetHashCode();
                if (this.SettlementCurrency != null)
                    hashCode = hashCode * 59 + this.SettlementCurrency.GetHashCode();
                if (this.ApyDisplay != null)
                    hashCode = hashCode * 59 + this.ApyDisplay.GetHashCode();
                if (this.ApySettlement != null)
                    hashCode = hashCode * 59 + this.ApySettlement.GetHashCode();
                hashCode = hashCode * 59 + this.DeliveryTime.GetHashCode();
                if (this.Text != null)
                    hashCode = hashCode * 59 + this.Text.GetHashCode();
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
