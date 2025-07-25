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
    /// UnifiedAccount
    /// </summary>
    [DataContract]
    public partial class UnifiedAccount :  IEquatable<UnifiedAccount>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedAccount" /> class.
        /// </summary>
        /// <param name="userId">User ID..</param>
        /// <param name="refreshTime">Time of the most recent refresh..</param>
        /// <param name="locked">Whether the account is locked, valid in cross-currency margin/combined margin mode, false in other modes such as single-currency margin mode.</param>
        /// <param name="balances">balances.</param>
        /// <param name="total">Total account assets converted to USD, i.e. the sum of &#x60;(available + freeze) * price&#x60; in all currencies (deprecated, to be deprecated, replaced by unified_account_total).</param>
        /// <param name="borrowed">The total borrowed amount of the account converted into USD, i.e. the sum of &#x60;borrowed * price&#x60; of all currencies (excluding Point Cards). It is valid in cross-currency margin/combined margin mode, and is 0 in other modes such as single-currency margin mode..</param>
        /// <param name="totalInitialMargin">Total initial margin, valid in cross-currency margin/combined margin mode, 0 in other modes such as single-currency margin mode.</param>
        /// <param name="totalMarginBalance">Total margin balance, valid in cross-currency margin/combined margin mode, 0 in other modes such as single-currency margin mode.</param>
        /// <param name="totalMaintenanceMargin">Total maintenance margin is valid in cross-currency margin/combined margin mode, and is 0 in other modes such as single-currency margin mode.</param>
        /// <param name="totalInitialMarginRate">Total initial margin rate, valid in cross-currency margin/combined margin mode, 0 in other modes such as single-currency margin mode.</param>
        /// <param name="totalMaintenanceMarginRate">Total maintenance margin rate, valid in cross-currency margin/combined margin mode, 0 in other modes such as single-currency margin mode.</param>
        /// <param name="totalAvailableMargin">Available margin amount, valid in cross-currency margin/combined margin mode, 0 in other modes such as single-currency margin mode.</param>
        /// <param name="unifiedAccountTotal">Unify the total account assets, valid in single currency margin/cross-currency margin/combined margin mode.</param>
        /// <param name="unifiedAccountTotalLiab">Unify the total loan of the account, valid in the cross-currency margin/combined margin mode, and 0 in other modes such as single-currency margin mode.</param>
        /// <param name="unifiedAccountTotalEquity">Unify the total account equity, valid in single currency margin/cross-currency margin/combined margin mode.</param>
        /// <param name="spotOrderLoss">Total pending order loss, in USDT, valid in cross-currency margin/combined margin mode, 0 in other modes such as single-currency margin mode.</param>
        /// <param name="spotHedge">Spot hedging status, true - enabled, false - not enabled..</param>
        /// <param name="useFunding">Whether to use funds as margin..</param>
        /// <param name="isAllCollateral">Whether all currencies are used as margin, true - false - No.</param>
        public UnifiedAccount(long userId = default(long), long refreshTime = default(long), bool locked = default(bool), Dictionary<string, UnifiedBalance> balances = default(Dictionary<string, UnifiedBalance>), string total = default(string), string borrowed = default(string), string totalInitialMargin = default(string), string totalMarginBalance = default(string), string totalMaintenanceMargin = default(string), string totalInitialMarginRate = default(string), string totalMaintenanceMarginRate = default(string), string totalAvailableMargin = default(string), string unifiedAccountTotal = default(string), string unifiedAccountTotalLiab = default(string), string unifiedAccountTotalEquity = default(string), string spotOrderLoss = default(string), bool spotHedge = default(bool), bool useFunding = default(bool), bool isAllCollateral = default(bool))
        {
            this.UserId = userId;
            this.RefreshTime = refreshTime;
            this.Locked = locked;
            this.Balances = balances;
            this.Total = total;
            this.Borrowed = borrowed;
            this.TotalInitialMargin = totalInitialMargin;
            this.TotalMarginBalance = totalMarginBalance;
            this.TotalMaintenanceMargin = totalMaintenanceMargin;
            this.TotalInitialMarginRate = totalInitialMarginRate;
            this.TotalMaintenanceMarginRate = totalMaintenanceMarginRate;
            this.TotalAvailableMargin = totalAvailableMargin;
            this.UnifiedAccountTotal = unifiedAccountTotal;
            this.UnifiedAccountTotalLiab = unifiedAccountTotalLiab;
            this.UnifiedAccountTotalEquity = unifiedAccountTotalEquity;
            this.SpotOrderLoss = spotOrderLoss;
            this.SpotHedge = spotHedge;
            this.UseFunding = useFunding;
            this.IsAllCollateral = isAllCollateral;
        }

        /// <summary>
        /// User ID.
        /// </summary>
        /// <value>User ID.</value>
        [DataMember(Name="user_id")]
        public long UserId { get; set; }

        /// <summary>
        /// Time of the most recent refresh.
        /// </summary>
        /// <value>Time of the most recent refresh.</value>
        [DataMember(Name="refresh_time")]
        public long RefreshTime { get; set; }

        /// <summary>
        /// Whether the account is locked, valid in cross-currency margin/combined margin mode, false in other modes such as single-currency margin mode
        /// </summary>
        /// <value>Whether the account is locked, valid in cross-currency margin/combined margin mode, false in other modes such as single-currency margin mode</value>
        [DataMember(Name="locked")]
        public bool Locked { get; set; }

        /// <summary>
        /// Gets or Sets Balances
        /// </summary>
        [DataMember(Name="balances")]
        public Dictionary<string, UnifiedBalance> Balances { get; set; }

        /// <summary>
        /// Total account assets converted to USD, i.e. the sum of &#x60;(available + freeze) * price&#x60; in all currencies (deprecated, to be deprecated, replaced by unified_account_total)
        /// </summary>
        /// <value>Total account assets converted to USD, i.e. the sum of &#x60;(available + freeze) * price&#x60; in all currencies (deprecated, to be deprecated, replaced by unified_account_total)</value>
        [DataMember(Name="total")]
        public string Total { get; set; }

        /// <summary>
        /// The total borrowed amount of the account converted into USD, i.e. the sum of &#x60;borrowed * price&#x60; of all currencies (excluding Point Cards). It is valid in cross-currency margin/combined margin mode, and is 0 in other modes such as single-currency margin mode.
        /// </summary>
        /// <value>The total borrowed amount of the account converted into USD, i.e. the sum of &#x60;borrowed * price&#x60; of all currencies (excluding Point Cards). It is valid in cross-currency margin/combined margin mode, and is 0 in other modes such as single-currency margin mode.</value>
        [DataMember(Name="borrowed")]
        public string Borrowed { get; set; }

        /// <summary>
        /// Total initial margin, valid in cross-currency margin/combined margin mode, 0 in other modes such as single-currency margin mode
        /// </summary>
        /// <value>Total initial margin, valid in cross-currency margin/combined margin mode, 0 in other modes such as single-currency margin mode</value>
        [DataMember(Name="total_initial_margin")]
        public string TotalInitialMargin { get; set; }

        /// <summary>
        /// Total margin balance, valid in cross-currency margin/combined margin mode, 0 in other modes such as single-currency margin mode
        /// </summary>
        /// <value>Total margin balance, valid in cross-currency margin/combined margin mode, 0 in other modes such as single-currency margin mode</value>
        [DataMember(Name="total_margin_balance")]
        public string TotalMarginBalance { get; set; }

        /// <summary>
        /// Total maintenance margin is valid in cross-currency margin/combined margin mode, and is 0 in other modes such as single-currency margin mode
        /// </summary>
        /// <value>Total maintenance margin is valid in cross-currency margin/combined margin mode, and is 0 in other modes such as single-currency margin mode</value>
        [DataMember(Name="total_maintenance_margin")]
        public string TotalMaintenanceMargin { get; set; }

        /// <summary>
        /// Total initial margin rate, valid in cross-currency margin/combined margin mode, 0 in other modes such as single-currency margin mode
        /// </summary>
        /// <value>Total initial margin rate, valid in cross-currency margin/combined margin mode, 0 in other modes such as single-currency margin mode</value>
        [DataMember(Name="total_initial_margin_rate")]
        public string TotalInitialMarginRate { get; set; }

        /// <summary>
        /// Total maintenance margin rate, valid in cross-currency margin/combined margin mode, 0 in other modes such as single-currency margin mode
        /// </summary>
        /// <value>Total maintenance margin rate, valid in cross-currency margin/combined margin mode, 0 in other modes such as single-currency margin mode</value>
        [DataMember(Name="total_maintenance_margin_rate")]
        public string TotalMaintenanceMarginRate { get; set; }

        /// <summary>
        /// Available margin amount, valid in cross-currency margin/combined margin mode, 0 in other modes such as single-currency margin mode
        /// </summary>
        /// <value>Available margin amount, valid in cross-currency margin/combined margin mode, 0 in other modes such as single-currency margin mode</value>
        [DataMember(Name="total_available_margin")]
        public string TotalAvailableMargin { get; set; }

        /// <summary>
        /// Unify the total account assets, valid in single currency margin/cross-currency margin/combined margin mode
        /// </summary>
        /// <value>Unify the total account assets, valid in single currency margin/cross-currency margin/combined margin mode</value>
        [DataMember(Name="unified_account_total")]
        public string UnifiedAccountTotal { get; set; }

        /// <summary>
        /// Unify the total loan of the account, valid in the cross-currency margin/combined margin mode, and 0 in other modes such as single-currency margin mode
        /// </summary>
        /// <value>Unify the total loan of the account, valid in the cross-currency margin/combined margin mode, and 0 in other modes such as single-currency margin mode</value>
        [DataMember(Name="unified_account_total_liab")]
        public string UnifiedAccountTotalLiab { get; set; }

        /// <summary>
        /// Unify the total account equity, valid in single currency margin/cross-currency margin/combined margin mode
        /// </summary>
        /// <value>Unify the total account equity, valid in single currency margin/cross-currency margin/combined margin mode</value>
        [DataMember(Name="unified_account_total_equity")]
        public string UnifiedAccountTotalEquity { get; set; }

        /// <summary>
        /// Actual leverage, valid in cross-currency margin/combined margin mode.
        /// </summary>
        /// <value>Actual leverage, valid in cross-currency margin/combined margin mode.</value>
        [DataMember(Name="leverage", EmitDefaultValue=false)]
        public string Leverage { get; private set; }

        /// <summary>
        /// Total pending order loss, in USDT, valid in cross-currency margin/combined margin mode, 0 in other modes such as single-currency margin mode
        /// </summary>
        /// <value>Total pending order loss, in USDT, valid in cross-currency margin/combined margin mode, 0 in other modes such as single-currency margin mode</value>
        [DataMember(Name="spot_order_loss")]
        public string SpotOrderLoss { get; set; }

        /// <summary>
        /// Spot hedging status, true - enabled, false - not enabled.
        /// </summary>
        /// <value>Spot hedging status, true - enabled, false - not enabled.</value>
        [DataMember(Name="spot_hedge")]
        public bool SpotHedge { get; set; }

        /// <summary>
        /// Whether to use funds as margin.
        /// </summary>
        /// <value>Whether to use funds as margin.</value>
        [DataMember(Name="use_funding")]
        public bool UseFunding { get; set; }

        /// <summary>
        /// Whether all currencies are used as margin, true - false - No
        /// </summary>
        /// <value>Whether all currencies are used as margin, true - false - No</value>
        [DataMember(Name="is_all_collateral")]
        public bool IsAllCollateral { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UnifiedAccount {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  RefreshTime: ").Append(RefreshTime).Append("\n");
            sb.Append("  Locked: ").Append(Locked).Append("\n");
            sb.Append("  Balances: ").Append(Balances).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Borrowed: ").Append(Borrowed).Append("\n");
            sb.Append("  TotalInitialMargin: ").Append(TotalInitialMargin).Append("\n");
            sb.Append("  TotalMarginBalance: ").Append(TotalMarginBalance).Append("\n");
            sb.Append("  TotalMaintenanceMargin: ").Append(TotalMaintenanceMargin).Append("\n");
            sb.Append("  TotalInitialMarginRate: ").Append(TotalInitialMarginRate).Append("\n");
            sb.Append("  TotalMaintenanceMarginRate: ").Append(TotalMaintenanceMarginRate).Append("\n");
            sb.Append("  TotalAvailableMargin: ").Append(TotalAvailableMargin).Append("\n");
            sb.Append("  UnifiedAccountTotal: ").Append(UnifiedAccountTotal).Append("\n");
            sb.Append("  UnifiedAccountTotalLiab: ").Append(UnifiedAccountTotalLiab).Append("\n");
            sb.Append("  UnifiedAccountTotalEquity: ").Append(UnifiedAccountTotalEquity).Append("\n");
            sb.Append("  Leverage: ").Append(Leverage).Append("\n");
            sb.Append("  SpotOrderLoss: ").Append(SpotOrderLoss).Append("\n");
            sb.Append("  SpotHedge: ").Append(SpotHedge).Append("\n");
            sb.Append("  UseFunding: ").Append(UseFunding).Append("\n");
            sb.Append("  IsAllCollateral: ").Append(IsAllCollateral).Append("\n");
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
            return this.Equals(input as UnifiedAccount);
        }

        /// <summary>
        /// Returns true if UnifiedAccount instances are equal
        /// </summary>
        /// <param name="input">Instance of UnifiedAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UnifiedAccount input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserId == input.UserId ||
                    this.UserId.Equals(input.UserId)
                ) && 
                (
                    this.RefreshTime == input.RefreshTime ||
                    this.RefreshTime.Equals(input.RefreshTime)
                ) && 
                (
                    this.Locked == input.Locked ||
                    this.Locked.Equals(input.Locked)
                ) && 
                (
                    this.Balances == input.Balances ||
                    this.Balances != null &&
                    input.Balances != null &&
                    this.Balances.SequenceEqual(input.Balances)
                ) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && 
                (
                    this.Borrowed == input.Borrowed ||
                    (this.Borrowed != null &&
                    this.Borrowed.Equals(input.Borrowed))
                ) && 
                (
                    this.TotalInitialMargin == input.TotalInitialMargin ||
                    (this.TotalInitialMargin != null &&
                    this.TotalInitialMargin.Equals(input.TotalInitialMargin))
                ) && 
                (
                    this.TotalMarginBalance == input.TotalMarginBalance ||
                    (this.TotalMarginBalance != null &&
                    this.TotalMarginBalance.Equals(input.TotalMarginBalance))
                ) && 
                (
                    this.TotalMaintenanceMargin == input.TotalMaintenanceMargin ||
                    (this.TotalMaintenanceMargin != null &&
                    this.TotalMaintenanceMargin.Equals(input.TotalMaintenanceMargin))
                ) && 
                (
                    this.TotalInitialMarginRate == input.TotalInitialMarginRate ||
                    (this.TotalInitialMarginRate != null &&
                    this.TotalInitialMarginRate.Equals(input.TotalInitialMarginRate))
                ) && 
                (
                    this.TotalMaintenanceMarginRate == input.TotalMaintenanceMarginRate ||
                    (this.TotalMaintenanceMarginRate != null &&
                    this.TotalMaintenanceMarginRate.Equals(input.TotalMaintenanceMarginRate))
                ) && 
                (
                    this.TotalAvailableMargin == input.TotalAvailableMargin ||
                    (this.TotalAvailableMargin != null &&
                    this.TotalAvailableMargin.Equals(input.TotalAvailableMargin))
                ) && 
                (
                    this.UnifiedAccountTotal == input.UnifiedAccountTotal ||
                    (this.UnifiedAccountTotal != null &&
                    this.UnifiedAccountTotal.Equals(input.UnifiedAccountTotal))
                ) && 
                (
                    this.UnifiedAccountTotalLiab == input.UnifiedAccountTotalLiab ||
                    (this.UnifiedAccountTotalLiab != null &&
                    this.UnifiedAccountTotalLiab.Equals(input.UnifiedAccountTotalLiab))
                ) && 
                (
                    this.UnifiedAccountTotalEquity == input.UnifiedAccountTotalEquity ||
                    (this.UnifiedAccountTotalEquity != null &&
                    this.UnifiedAccountTotalEquity.Equals(input.UnifiedAccountTotalEquity))
                ) && 
                (
                    this.Leverage == input.Leverage ||
                    (this.Leverage != null &&
                    this.Leverage.Equals(input.Leverage))
                ) && 
                (
                    this.SpotOrderLoss == input.SpotOrderLoss ||
                    (this.SpotOrderLoss != null &&
                    this.SpotOrderLoss.Equals(input.SpotOrderLoss))
                ) && 
                (
                    this.SpotHedge == input.SpotHedge ||
                    this.SpotHedge.Equals(input.SpotHedge)
                ) && 
                (
                    this.UseFunding == input.UseFunding ||
                    this.UseFunding.Equals(input.UseFunding)
                ) && 
                (
                    this.IsAllCollateral == input.IsAllCollateral ||
                    this.IsAllCollateral.Equals(input.IsAllCollateral)
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
                hashCode = hashCode * 59 + this.RefreshTime.GetHashCode();
                hashCode = hashCode * 59 + this.Locked.GetHashCode();
                if (this.Balances != null)
                    hashCode = hashCode * 59 + this.Balances.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.Borrowed != null)
                    hashCode = hashCode * 59 + this.Borrowed.GetHashCode();
                if (this.TotalInitialMargin != null)
                    hashCode = hashCode * 59 + this.TotalInitialMargin.GetHashCode();
                if (this.TotalMarginBalance != null)
                    hashCode = hashCode * 59 + this.TotalMarginBalance.GetHashCode();
                if (this.TotalMaintenanceMargin != null)
                    hashCode = hashCode * 59 + this.TotalMaintenanceMargin.GetHashCode();
                if (this.TotalInitialMarginRate != null)
                    hashCode = hashCode * 59 + this.TotalInitialMarginRate.GetHashCode();
                if (this.TotalMaintenanceMarginRate != null)
                    hashCode = hashCode * 59 + this.TotalMaintenanceMarginRate.GetHashCode();
                if (this.TotalAvailableMargin != null)
                    hashCode = hashCode * 59 + this.TotalAvailableMargin.GetHashCode();
                if (this.UnifiedAccountTotal != null)
                    hashCode = hashCode * 59 + this.UnifiedAccountTotal.GetHashCode();
                if (this.UnifiedAccountTotalLiab != null)
                    hashCode = hashCode * 59 + this.UnifiedAccountTotalLiab.GetHashCode();
                if (this.UnifiedAccountTotalEquity != null)
                    hashCode = hashCode * 59 + this.UnifiedAccountTotalEquity.GetHashCode();
                if (this.Leverage != null)
                    hashCode = hashCode * 59 + this.Leverage.GetHashCode();
                if (this.SpotOrderLoss != null)
                    hashCode = hashCode * 59 + this.SpotOrderLoss.GetHashCode();
                hashCode = hashCode * 59 + this.SpotHedge.GetHashCode();
                hashCode = hashCode * 59 + this.UseFunding.GetHashCode();
                hashCode = hashCode * 59 + this.IsAllCollateral.GetHashCode();
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
