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
    /// Repayment record.
    /// </summary>
    [DataContract]
    public partial class RepayRecord :  IEquatable<RepayRecord>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RepayRecord" /> class.
        /// </summary>
        /// <param name="orderId">Order ID..</param>
        /// <param name="recordId">Repayment record ID..</param>
        /// <param name="repaidAmount">Repayment amount..</param>
        /// <param name="borrowCurrency">Borrowed currency..</param>
        /// <param name="collateralCurrency">Collateral..</param>
        /// <param name="initLtv">The initial collateralization rate..</param>
        /// <param name="borrowTime">Borrowing time, timestamp..</param>
        /// <param name="repayTime">Repayment time, timestamp..</param>
        /// <param name="totalInterest">Total interest..</param>
        /// <param name="beforeLeftPrincipal">Principal to be repaid before repayment..</param>
        /// <param name="afterLeftPrincipal">Principal to be repaid after repayment..</param>
        /// <param name="beforeLeftCollateral">Collateral quantity before repayment..</param>
        /// <param name="afterLeftCollateral">Collateral quantity after repayment..</param>
        public RepayRecord(long orderId = default(long), long recordId = default(long), string repaidAmount = default(string), string borrowCurrency = default(string), string collateralCurrency = default(string), string initLtv = default(string), long borrowTime = default(long), long repayTime = default(long), string totalInterest = default(string), string beforeLeftPrincipal = default(string), string afterLeftPrincipal = default(string), string beforeLeftCollateral = default(string), string afterLeftCollateral = default(string))
        {
            this.OrderId = orderId;
            this.RecordId = recordId;
            this.RepaidAmount = repaidAmount;
            this.BorrowCurrency = borrowCurrency;
            this.CollateralCurrency = collateralCurrency;
            this.InitLtv = initLtv;
            this.BorrowTime = borrowTime;
            this.RepayTime = repayTime;
            this.TotalInterest = totalInterest;
            this.BeforeLeftPrincipal = beforeLeftPrincipal;
            this.AfterLeftPrincipal = afterLeftPrincipal;
            this.BeforeLeftCollateral = beforeLeftCollateral;
            this.AfterLeftCollateral = afterLeftCollateral;
        }

        /// <summary>
        /// Order ID.
        /// </summary>
        /// <value>Order ID.</value>
        [DataMember(Name="order_id")]
        public long OrderId { get; set; }

        /// <summary>
        /// Repayment record ID.
        /// </summary>
        /// <value>Repayment record ID.</value>
        [DataMember(Name="record_id")]
        public long RecordId { get; set; }

        /// <summary>
        /// Repayment amount.
        /// </summary>
        /// <value>Repayment amount.</value>
        [DataMember(Name="repaid_amount")]
        public string RepaidAmount { get; set; }

        /// <summary>
        /// Borrowed currency.
        /// </summary>
        /// <value>Borrowed currency.</value>
        [DataMember(Name="borrow_currency")]
        public string BorrowCurrency { get; set; }

        /// <summary>
        /// Collateral.
        /// </summary>
        /// <value>Collateral.</value>
        [DataMember(Name="collateral_currency")]
        public string CollateralCurrency { get; set; }

        /// <summary>
        /// The initial collateralization rate.
        /// </summary>
        /// <value>The initial collateralization rate.</value>
        [DataMember(Name="init_ltv")]
        public string InitLtv { get; set; }

        /// <summary>
        /// Borrowing time, timestamp.
        /// </summary>
        /// <value>Borrowing time, timestamp.</value>
        [DataMember(Name="borrow_time")]
        public long BorrowTime { get; set; }

        /// <summary>
        /// Repayment time, timestamp.
        /// </summary>
        /// <value>Repayment time, timestamp.</value>
        [DataMember(Name="repay_time")]
        public long RepayTime { get; set; }

        /// <summary>
        /// Total interest.
        /// </summary>
        /// <value>Total interest.</value>
        [DataMember(Name="total_interest")]
        public string TotalInterest { get; set; }

        /// <summary>
        /// Principal to be repaid before repayment.
        /// </summary>
        /// <value>Principal to be repaid before repayment.</value>
        [DataMember(Name="before_left_principal")]
        public string BeforeLeftPrincipal { get; set; }

        /// <summary>
        /// Principal to be repaid after repayment.
        /// </summary>
        /// <value>Principal to be repaid after repayment.</value>
        [DataMember(Name="after_left_principal")]
        public string AfterLeftPrincipal { get; set; }

        /// <summary>
        /// Collateral quantity before repayment.
        /// </summary>
        /// <value>Collateral quantity before repayment.</value>
        [DataMember(Name="before_left_collateral")]
        public string BeforeLeftCollateral { get; set; }

        /// <summary>
        /// Collateral quantity after repayment.
        /// </summary>
        /// <value>Collateral quantity after repayment.</value>
        [DataMember(Name="after_left_collateral")]
        public string AfterLeftCollateral { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RepayRecord {\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  RecordId: ").Append(RecordId).Append("\n");
            sb.Append("  RepaidAmount: ").Append(RepaidAmount).Append("\n");
            sb.Append("  BorrowCurrency: ").Append(BorrowCurrency).Append("\n");
            sb.Append("  CollateralCurrency: ").Append(CollateralCurrency).Append("\n");
            sb.Append("  InitLtv: ").Append(InitLtv).Append("\n");
            sb.Append("  BorrowTime: ").Append(BorrowTime).Append("\n");
            sb.Append("  RepayTime: ").Append(RepayTime).Append("\n");
            sb.Append("  TotalInterest: ").Append(TotalInterest).Append("\n");
            sb.Append("  BeforeLeftPrincipal: ").Append(BeforeLeftPrincipal).Append("\n");
            sb.Append("  AfterLeftPrincipal: ").Append(AfterLeftPrincipal).Append("\n");
            sb.Append("  BeforeLeftCollateral: ").Append(BeforeLeftCollateral).Append("\n");
            sb.Append("  AfterLeftCollateral: ").Append(AfterLeftCollateral).Append("\n");
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
            return this.Equals(input as RepayRecord);
        }

        /// <summary>
        /// Returns true if RepayRecord instances are equal
        /// </summary>
        /// <param name="input">Instance of RepayRecord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RepayRecord input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OrderId == input.OrderId ||
                    this.OrderId.Equals(input.OrderId)
                ) && 
                (
                    this.RecordId == input.RecordId ||
                    this.RecordId.Equals(input.RecordId)
                ) && 
                (
                    this.RepaidAmount == input.RepaidAmount ||
                    (this.RepaidAmount != null &&
                    this.RepaidAmount.Equals(input.RepaidAmount))
                ) && 
                (
                    this.BorrowCurrency == input.BorrowCurrency ||
                    (this.BorrowCurrency != null &&
                    this.BorrowCurrency.Equals(input.BorrowCurrency))
                ) && 
                (
                    this.CollateralCurrency == input.CollateralCurrency ||
                    (this.CollateralCurrency != null &&
                    this.CollateralCurrency.Equals(input.CollateralCurrency))
                ) && 
                (
                    this.InitLtv == input.InitLtv ||
                    (this.InitLtv != null &&
                    this.InitLtv.Equals(input.InitLtv))
                ) && 
                (
                    this.BorrowTime == input.BorrowTime ||
                    this.BorrowTime.Equals(input.BorrowTime)
                ) && 
                (
                    this.RepayTime == input.RepayTime ||
                    this.RepayTime.Equals(input.RepayTime)
                ) && 
                (
                    this.TotalInterest == input.TotalInterest ||
                    (this.TotalInterest != null &&
                    this.TotalInterest.Equals(input.TotalInterest))
                ) && 
                (
                    this.BeforeLeftPrincipal == input.BeforeLeftPrincipal ||
                    (this.BeforeLeftPrincipal != null &&
                    this.BeforeLeftPrincipal.Equals(input.BeforeLeftPrincipal))
                ) && 
                (
                    this.AfterLeftPrincipal == input.AfterLeftPrincipal ||
                    (this.AfterLeftPrincipal != null &&
                    this.AfterLeftPrincipal.Equals(input.AfterLeftPrincipal))
                ) && 
                (
                    this.BeforeLeftCollateral == input.BeforeLeftCollateral ||
                    (this.BeforeLeftCollateral != null &&
                    this.BeforeLeftCollateral.Equals(input.BeforeLeftCollateral))
                ) && 
                (
                    this.AfterLeftCollateral == input.AfterLeftCollateral ||
                    (this.AfterLeftCollateral != null &&
                    this.AfterLeftCollateral.Equals(input.AfterLeftCollateral))
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
                hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                hashCode = hashCode * 59 + this.RecordId.GetHashCode();
                if (this.RepaidAmount != null)
                    hashCode = hashCode * 59 + this.RepaidAmount.GetHashCode();
                if (this.BorrowCurrency != null)
                    hashCode = hashCode * 59 + this.BorrowCurrency.GetHashCode();
                if (this.CollateralCurrency != null)
                    hashCode = hashCode * 59 + this.CollateralCurrency.GetHashCode();
                if (this.InitLtv != null)
                    hashCode = hashCode * 59 + this.InitLtv.GetHashCode();
                hashCode = hashCode * 59 + this.BorrowTime.GetHashCode();
                hashCode = hashCode * 59 + this.RepayTime.GetHashCode();
                if (this.TotalInterest != null)
                    hashCode = hashCode * 59 + this.TotalInterest.GetHashCode();
                if (this.BeforeLeftPrincipal != null)
                    hashCode = hashCode * 59 + this.BeforeLeftPrincipal.GetHashCode();
                if (this.AfterLeftPrincipal != null)
                    hashCode = hashCode * 59 + this.AfterLeftPrincipal.GetHashCode();
                if (this.BeforeLeftCollateral != null)
                    hashCode = hashCode * 59 + this.BeforeLeftCollateral.GetHashCode();
                if (this.AfterLeftCollateral != null)
                    hashCode = hashCode * 59 + this.AfterLeftCollateral.GetHashCode();
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
