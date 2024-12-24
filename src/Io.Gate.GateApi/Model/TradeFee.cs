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
    /// TradeFee
    /// </summary>
    [DataContract]
    public partial class TradeFee :  IEquatable<TradeFee>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TradeFee" /> class.
        /// </summary>
        /// <param name="userId">User ID.</param>
        /// <param name="takerFee">taker fee rate.</param>
        /// <param name="makerFee">maker fee rate.</param>
        /// <param name="gtDiscount">If GT deduction is enabled.</param>
        /// <param name="gtTakerFee">Taker fee rate if using GT deduction. It will be 0 if GT deduction is disabled.</param>
        /// <param name="gtMakerFee">Maker fee rate if using GT deduction. It will be 0 if GT deduction is disabled.</param>
        /// <param name="loanFee">Loan fee rate of margin lending.</param>
        /// <param name="pointType">Point type. 0 - Initial version. 1 - new version since 202009.</param>
        /// <param name="futuresTakerFee">Futures trading taker fee.</param>
        /// <param name="futuresMakerFee">Future trading maker fee.</param>
        /// <param name="deliveryTakerFee">Delivery trading taker fee.</param>
        /// <param name="deliveryMakerFee">Delivery trading maker fee.</param>
        /// <param name="debitFee">Deduction types for rates, 1 - GT deduction, 2 - Point card deduction, 3 - VIP rates.</param>
        public TradeFee(long userId = default(long), string takerFee = default(string), string makerFee = default(string), bool gtDiscount = default(bool), string gtTakerFee = default(string), string gtMakerFee = default(string), string loanFee = default(string), string pointType = default(string), string futuresTakerFee = default(string), string futuresMakerFee = default(string), string deliveryTakerFee = default(string), string deliveryMakerFee = default(string), int debitFee = default(int))
        {
            this.UserId = userId;
            this.TakerFee = takerFee;
            this.MakerFee = makerFee;
            this.GtDiscount = gtDiscount;
            this.GtTakerFee = gtTakerFee;
            this.GtMakerFee = gtMakerFee;
            this.LoanFee = loanFee;
            this.PointType = pointType;
            this.FuturesTakerFee = futuresTakerFee;
            this.FuturesMakerFee = futuresMakerFee;
            this.DeliveryTakerFee = deliveryTakerFee;
            this.DeliveryMakerFee = deliveryMakerFee;
            this.DebitFee = debitFee;
        }

        /// <summary>
        /// User ID
        /// </summary>
        /// <value>User ID</value>
        [DataMember(Name="user_id")]
        public long UserId { get; set; }

        /// <summary>
        /// taker fee rate
        /// </summary>
        /// <value>taker fee rate</value>
        [DataMember(Name="taker_fee")]
        public string TakerFee { get; set; }

        /// <summary>
        /// maker fee rate
        /// </summary>
        /// <value>maker fee rate</value>
        [DataMember(Name="maker_fee")]
        public string MakerFee { get; set; }

        /// <summary>
        /// If GT deduction is enabled
        /// </summary>
        /// <value>If GT deduction is enabled</value>
        [DataMember(Name="gt_discount")]
        public bool GtDiscount { get; set; }

        /// <summary>
        /// Taker fee rate if using GT deduction. It will be 0 if GT deduction is disabled
        /// </summary>
        /// <value>Taker fee rate if using GT deduction. It will be 0 if GT deduction is disabled</value>
        [DataMember(Name="gt_taker_fee")]
        public string GtTakerFee { get; set; }

        /// <summary>
        /// Maker fee rate if using GT deduction. It will be 0 if GT deduction is disabled
        /// </summary>
        /// <value>Maker fee rate if using GT deduction. It will be 0 if GT deduction is disabled</value>
        [DataMember(Name="gt_maker_fee")]
        public string GtMakerFee { get; set; }

        /// <summary>
        /// Loan fee rate of margin lending
        /// </summary>
        /// <value>Loan fee rate of margin lending</value>
        [DataMember(Name="loan_fee")]
        public string LoanFee { get; set; }

        /// <summary>
        /// Point type. 0 - Initial version. 1 - new version since 202009
        /// </summary>
        /// <value>Point type. 0 - Initial version. 1 - new version since 202009</value>
        [DataMember(Name="point_type")]
        public string PointType { get; set; }

        /// <summary>
        /// Futures trading taker fee
        /// </summary>
        /// <value>Futures trading taker fee</value>
        [DataMember(Name="futures_taker_fee")]
        public string FuturesTakerFee { get; set; }

        /// <summary>
        /// Future trading maker fee
        /// </summary>
        /// <value>Future trading maker fee</value>
        [DataMember(Name="futures_maker_fee")]
        public string FuturesMakerFee { get; set; }

        /// <summary>
        /// Delivery trading taker fee
        /// </summary>
        /// <value>Delivery trading taker fee</value>
        [DataMember(Name="delivery_taker_fee")]
        public string DeliveryTakerFee { get; set; }

        /// <summary>
        /// Delivery trading maker fee
        /// </summary>
        /// <value>Delivery trading maker fee</value>
        [DataMember(Name="delivery_maker_fee")]
        public string DeliveryMakerFee { get; set; }

        /// <summary>
        /// Deduction types for rates, 1 - GT deduction, 2 - Point card deduction, 3 - VIP rates
        /// </summary>
        /// <value>Deduction types for rates, 1 - GT deduction, 2 - Point card deduction, 3 - VIP rates</value>
        [DataMember(Name="debit_fee")]
        public int DebitFee { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TradeFee {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  TakerFee: ").Append(TakerFee).Append("\n");
            sb.Append("  MakerFee: ").Append(MakerFee).Append("\n");
            sb.Append("  GtDiscount: ").Append(GtDiscount).Append("\n");
            sb.Append("  GtTakerFee: ").Append(GtTakerFee).Append("\n");
            sb.Append("  GtMakerFee: ").Append(GtMakerFee).Append("\n");
            sb.Append("  LoanFee: ").Append(LoanFee).Append("\n");
            sb.Append("  PointType: ").Append(PointType).Append("\n");
            sb.Append("  FuturesTakerFee: ").Append(FuturesTakerFee).Append("\n");
            sb.Append("  FuturesMakerFee: ").Append(FuturesMakerFee).Append("\n");
            sb.Append("  DeliveryTakerFee: ").Append(DeliveryTakerFee).Append("\n");
            sb.Append("  DeliveryMakerFee: ").Append(DeliveryMakerFee).Append("\n");
            sb.Append("  DebitFee: ").Append(DebitFee).Append("\n");
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
            return this.Equals(input as TradeFee);
        }

        /// <summary>
        /// Returns true if TradeFee instances are equal
        /// </summary>
        /// <param name="input">Instance of TradeFee to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TradeFee input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserId == input.UserId ||
                    this.UserId.Equals(input.UserId)
                ) && 
                (
                    this.TakerFee == input.TakerFee ||
                    (this.TakerFee != null &&
                    this.TakerFee.Equals(input.TakerFee))
                ) && 
                (
                    this.MakerFee == input.MakerFee ||
                    (this.MakerFee != null &&
                    this.MakerFee.Equals(input.MakerFee))
                ) && 
                (
                    this.GtDiscount == input.GtDiscount ||
                    this.GtDiscount.Equals(input.GtDiscount)
                ) && 
                (
                    this.GtTakerFee == input.GtTakerFee ||
                    (this.GtTakerFee != null &&
                    this.GtTakerFee.Equals(input.GtTakerFee))
                ) && 
                (
                    this.GtMakerFee == input.GtMakerFee ||
                    (this.GtMakerFee != null &&
                    this.GtMakerFee.Equals(input.GtMakerFee))
                ) && 
                (
                    this.LoanFee == input.LoanFee ||
                    (this.LoanFee != null &&
                    this.LoanFee.Equals(input.LoanFee))
                ) && 
                (
                    this.PointType == input.PointType ||
                    (this.PointType != null &&
                    this.PointType.Equals(input.PointType))
                ) && 
                (
                    this.FuturesTakerFee == input.FuturesTakerFee ||
                    (this.FuturesTakerFee != null &&
                    this.FuturesTakerFee.Equals(input.FuturesTakerFee))
                ) && 
                (
                    this.FuturesMakerFee == input.FuturesMakerFee ||
                    (this.FuturesMakerFee != null &&
                    this.FuturesMakerFee.Equals(input.FuturesMakerFee))
                ) && 
                (
                    this.DeliveryTakerFee == input.DeliveryTakerFee ||
                    (this.DeliveryTakerFee != null &&
                    this.DeliveryTakerFee.Equals(input.DeliveryTakerFee))
                ) && 
                (
                    this.DeliveryMakerFee == input.DeliveryMakerFee ||
                    (this.DeliveryMakerFee != null &&
                    this.DeliveryMakerFee.Equals(input.DeliveryMakerFee))
                ) && 
                (
                    this.DebitFee == input.DebitFee ||
                    this.DebitFee.Equals(input.DebitFee)
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
                hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.TakerFee != null)
                    hashCode = hashCode * 59 + this.TakerFee.GetHashCode();
                if (this.MakerFee != null)
                    hashCode = hashCode * 59 + this.MakerFee.GetHashCode();
                hashCode = hashCode * 59 + this.GtDiscount.GetHashCode();
                if (this.GtTakerFee != null)
                    hashCode = hashCode * 59 + this.GtTakerFee.GetHashCode();
                if (this.GtMakerFee != null)
                    hashCode = hashCode * 59 + this.GtMakerFee.GetHashCode();
                if (this.LoanFee != null)
                    hashCode = hashCode * 59 + this.LoanFee.GetHashCode();
                if (this.PointType != null)
                    hashCode = hashCode * 59 + this.PointType.GetHashCode();
                if (this.FuturesTakerFee != null)
                    hashCode = hashCode * 59 + this.FuturesTakerFee.GetHashCode();
                if (this.FuturesMakerFee != null)
                    hashCode = hashCode * 59 + this.FuturesMakerFee.GetHashCode();
                if (this.DeliveryTakerFee != null)
                    hashCode = hashCode * 59 + this.DeliveryTakerFee.GetHashCode();
                if (this.DeliveryMakerFee != null)
                    hashCode = hashCode * 59 + this.DeliveryMakerFee.GetHashCode();
                hashCode = hashCode * 59 + this.DebitFee.GetHashCode();
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
