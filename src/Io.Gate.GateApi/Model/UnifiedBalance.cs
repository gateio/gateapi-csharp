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
    /// UnifiedBalance
    /// </summary>
    [DataContract]
    public partial class UnifiedBalance :  IEquatable<UnifiedBalance>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedBalance" /> class.
        /// </summary>
        /// <param name="available">Available amount is valid in single currency margin/cross-currency margin/combined margin mode, and the calculation is different in different modes.</param>
        /// <param name="freeze">The locked amount is valid in single currency margin/cross-currency margin/combined margin mode.</param>
        /// <param name="borrowed">Borrow limit, valid in cross-currency margin/combined margin mode, 0 in other modes such as single-currency margin mode.</param>
        /// <param name="negativeLiab">Negative balance loan is valid in cross-currency margin/combined margin mode, and is 0 in other modes such as single-currency margin mode.</param>
        /// <param name="futuresPosLiab">Contract opening position borrowing currency (abandoned, to be offline field).</param>
        /// <param name="equity">Equity, valid in single currency margin/cross currency margin/combined margin mode.</param>
        /// <param name="totalFreeze">Total occupancy (discarded, to be offline field).</param>
        /// <param name="totalLiab">Total borrowing, valid in cross-currency margin/combined margin mode, 0 in other modes such as single-currency margin mode.</param>
        /// <param name="spotInUse">The amount of spot hedging is valid in the combined margin mode, and is 0 in other margin modes such as single currency and cross-currency margin modes.</param>
        /// <param name="funding">Yubibao financial management amount, effective when Yubibao financial management is turned on as a unified account margin switch.</param>
        /// <param name="fundingVersion">Funding version.</param>
        /// <param name="crossBalance">Full margin balance is valid in single currency margin mode, and is 0 in other modes such as cross currency margin/combined margin mode.</param>
        /// <param name="isoBalance">Isolated margin balance is valid in single-currency margin mode and is 0 in other modes such as cross-currency margin/combined margin mode.</param>
        /// <param name="im">Full-position initial margin is valid in single-currency margin mode and is 0 in other modes such as cross-currency margin/combined margin mode.</param>
        /// <param name="mm">Full-position maintenance margin rate is valid in single-currency margin mode and is 0 in other modes such as cross-currency margin/combined margin mode.</param>
        /// <param name="imr">Full-position initial margin rate is valid in single-currency margin mode and is 0 in other modes such as cross-currency margin/combined margin mode.</param>
        /// <param name="mmr">Full-position maintenance margin rate is valid in single-currency margin mode and is 0 in other modes such as cross-currency margin/combined margin mode.</param>
        /// <param name="marginBalance">Full margin balance is valid in single currency margin mode and is 0 in other modes such as cross currency margin/combined margin mode.</param>
        /// <param name="availableMargin">Full margin available for full position is valid in single currency margin mode, and is 0 in other modes such as cross-currency margin/combined margin mode.</param>
        public UnifiedBalance(string available = default(string), string freeze = default(string), string borrowed = default(string), string negativeLiab = default(string), string futuresPosLiab = default(string), string equity = default(string), string totalFreeze = default(string), string totalLiab = default(string), string spotInUse = default(string), string funding = default(string), string fundingVersion = default(string), string crossBalance = default(string), string isoBalance = default(string), string im = default(string), string mm = default(string), string imr = default(string), string mmr = default(string), string marginBalance = default(string), string availableMargin = default(string))
        {
            this.Available = available;
            this.Freeze = freeze;
            this.Borrowed = borrowed;
            this.NegativeLiab = negativeLiab;
            this.FuturesPosLiab = futuresPosLiab;
            this.Equity = equity;
            this.TotalFreeze = totalFreeze;
            this.TotalLiab = totalLiab;
            this.SpotInUse = spotInUse;
            this.Funding = funding;
            this.FundingVersion = fundingVersion;
            this.CrossBalance = crossBalance;
            this.IsoBalance = isoBalance;
            this.Im = im;
            this.Mm = mm;
            this.Imr = imr;
            this.Mmr = mmr;
            this.MarginBalance = marginBalance;
            this.AvailableMargin = availableMargin;
        }

        /// <summary>
        /// Available amount is valid in single currency margin/cross-currency margin/combined margin mode, and the calculation is different in different modes
        /// </summary>
        /// <value>Available amount is valid in single currency margin/cross-currency margin/combined margin mode, and the calculation is different in different modes</value>
        [DataMember(Name="available")]
        public string Available { get; set; }

        /// <summary>
        /// The locked amount is valid in single currency margin/cross-currency margin/combined margin mode
        /// </summary>
        /// <value>The locked amount is valid in single currency margin/cross-currency margin/combined margin mode</value>
        [DataMember(Name="freeze")]
        public string Freeze { get; set; }

        /// <summary>
        /// Borrow limit, valid in cross-currency margin/combined margin mode, 0 in other modes such as single-currency margin mode
        /// </summary>
        /// <value>Borrow limit, valid in cross-currency margin/combined margin mode, 0 in other modes such as single-currency margin mode</value>
        [DataMember(Name="borrowed")]
        public string Borrowed { get; set; }

        /// <summary>
        /// Negative balance loan is valid in cross-currency margin/combined margin mode, and is 0 in other modes such as single-currency margin mode
        /// </summary>
        /// <value>Negative balance loan is valid in cross-currency margin/combined margin mode, and is 0 in other modes such as single-currency margin mode</value>
        [DataMember(Name="negative_liab")]
        public string NegativeLiab { get; set; }

        /// <summary>
        /// Contract opening position borrowing currency (abandoned, to be offline field)
        /// </summary>
        /// <value>Contract opening position borrowing currency (abandoned, to be offline field)</value>
        [DataMember(Name="futures_pos_liab")]
        public string FuturesPosLiab { get; set; }

        /// <summary>
        /// Equity, valid in single currency margin/cross currency margin/combined margin mode
        /// </summary>
        /// <value>Equity, valid in single currency margin/cross currency margin/combined margin mode</value>
        [DataMember(Name="equity")]
        public string Equity { get; set; }

        /// <summary>
        /// Total occupancy (discarded, to be offline field)
        /// </summary>
        /// <value>Total occupancy (discarded, to be offline field)</value>
        [DataMember(Name="total_freeze")]
        public string TotalFreeze { get; set; }

        /// <summary>
        /// Total borrowing, valid in cross-currency margin/combined margin mode, 0 in other modes such as single-currency margin mode
        /// </summary>
        /// <value>Total borrowing, valid in cross-currency margin/combined margin mode, 0 in other modes such as single-currency margin mode</value>
        [DataMember(Name="total_liab")]
        public string TotalLiab { get; set; }

        /// <summary>
        /// The amount of spot hedging is valid in the combined margin mode, and is 0 in other margin modes such as single currency and cross-currency margin modes
        /// </summary>
        /// <value>The amount of spot hedging is valid in the combined margin mode, and is 0 in other margin modes such as single currency and cross-currency margin modes</value>
        [DataMember(Name="spot_in_use")]
        public string SpotInUse { get; set; }

        /// <summary>
        /// Yubibao financial management amount, effective when Yubibao financial management is turned on as a unified account margin switch
        /// </summary>
        /// <value>Yubibao financial management amount, effective when Yubibao financial management is turned on as a unified account margin switch</value>
        [DataMember(Name="funding")]
        public string Funding { get; set; }

        /// <summary>
        /// Funding version
        /// </summary>
        /// <value>Funding version</value>
        [DataMember(Name="funding_version")]
        public string FundingVersion { get; set; }

        /// <summary>
        /// Full margin balance is valid in single currency margin mode, and is 0 in other modes such as cross currency margin/combined margin mode
        /// </summary>
        /// <value>Full margin balance is valid in single currency margin mode, and is 0 in other modes such as cross currency margin/combined margin mode</value>
        [DataMember(Name="cross_balance")]
        public string CrossBalance { get; set; }

        /// <summary>
        /// Isolated margin balance is valid in single-currency margin mode and is 0 in other modes such as cross-currency margin/combined margin mode
        /// </summary>
        /// <value>Isolated margin balance is valid in single-currency margin mode and is 0 in other modes such as cross-currency margin/combined margin mode</value>
        [DataMember(Name="iso_balance")]
        public string IsoBalance { get; set; }

        /// <summary>
        /// Full-position initial margin is valid in single-currency margin mode and is 0 in other modes such as cross-currency margin/combined margin mode
        /// </summary>
        /// <value>Full-position initial margin is valid in single-currency margin mode and is 0 in other modes such as cross-currency margin/combined margin mode</value>
        [DataMember(Name="im")]
        public string Im { get; set; }

        /// <summary>
        /// Full-position maintenance margin rate is valid in single-currency margin mode and is 0 in other modes such as cross-currency margin/combined margin mode
        /// </summary>
        /// <value>Full-position maintenance margin rate is valid in single-currency margin mode and is 0 in other modes such as cross-currency margin/combined margin mode</value>
        [DataMember(Name="mm")]
        public string Mm { get; set; }

        /// <summary>
        /// Full-position initial margin rate is valid in single-currency margin mode and is 0 in other modes such as cross-currency margin/combined margin mode
        /// </summary>
        /// <value>Full-position initial margin rate is valid in single-currency margin mode and is 0 in other modes such as cross-currency margin/combined margin mode</value>
        [DataMember(Name="imr")]
        public string Imr { get; set; }

        /// <summary>
        /// Full-position maintenance margin rate is valid in single-currency margin mode and is 0 in other modes such as cross-currency margin/combined margin mode
        /// </summary>
        /// <value>Full-position maintenance margin rate is valid in single-currency margin mode and is 0 in other modes such as cross-currency margin/combined margin mode</value>
        [DataMember(Name="mmr")]
        public string Mmr { get; set; }

        /// <summary>
        /// Full margin balance is valid in single currency margin mode and is 0 in other modes such as cross currency margin/combined margin mode
        /// </summary>
        /// <value>Full margin balance is valid in single currency margin mode and is 0 in other modes such as cross currency margin/combined margin mode</value>
        [DataMember(Name="margin_balance")]
        public string MarginBalance { get; set; }

        /// <summary>
        /// Full margin available for full position is valid in single currency margin mode, and is 0 in other modes such as cross-currency margin/combined margin mode
        /// </summary>
        /// <value>Full margin available for full position is valid in single currency margin mode, and is 0 in other modes such as cross-currency margin/combined margin mode</value>
        [DataMember(Name="available_margin")]
        public string AvailableMargin { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UnifiedBalance {\n");
            sb.Append("  Available: ").Append(Available).Append("\n");
            sb.Append("  Freeze: ").Append(Freeze).Append("\n");
            sb.Append("  Borrowed: ").Append(Borrowed).Append("\n");
            sb.Append("  NegativeLiab: ").Append(NegativeLiab).Append("\n");
            sb.Append("  FuturesPosLiab: ").Append(FuturesPosLiab).Append("\n");
            sb.Append("  Equity: ").Append(Equity).Append("\n");
            sb.Append("  TotalFreeze: ").Append(TotalFreeze).Append("\n");
            sb.Append("  TotalLiab: ").Append(TotalLiab).Append("\n");
            sb.Append("  SpotInUse: ").Append(SpotInUse).Append("\n");
            sb.Append("  Funding: ").Append(Funding).Append("\n");
            sb.Append("  FundingVersion: ").Append(FundingVersion).Append("\n");
            sb.Append("  CrossBalance: ").Append(CrossBalance).Append("\n");
            sb.Append("  IsoBalance: ").Append(IsoBalance).Append("\n");
            sb.Append("  Im: ").Append(Im).Append("\n");
            sb.Append("  Mm: ").Append(Mm).Append("\n");
            sb.Append("  Imr: ").Append(Imr).Append("\n");
            sb.Append("  Mmr: ").Append(Mmr).Append("\n");
            sb.Append("  MarginBalance: ").Append(MarginBalance).Append("\n");
            sb.Append("  AvailableMargin: ").Append(AvailableMargin).Append("\n");
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
            return this.Equals(input as UnifiedBalance);
        }

        /// <summary>
        /// Returns true if UnifiedBalance instances are equal
        /// </summary>
        /// <param name="input">Instance of UnifiedBalance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UnifiedBalance input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Available == input.Available ||
                    (this.Available != null &&
                    this.Available.Equals(input.Available))
                ) && 
                (
                    this.Freeze == input.Freeze ||
                    (this.Freeze != null &&
                    this.Freeze.Equals(input.Freeze))
                ) && 
                (
                    this.Borrowed == input.Borrowed ||
                    (this.Borrowed != null &&
                    this.Borrowed.Equals(input.Borrowed))
                ) && 
                (
                    this.NegativeLiab == input.NegativeLiab ||
                    (this.NegativeLiab != null &&
                    this.NegativeLiab.Equals(input.NegativeLiab))
                ) && 
                (
                    this.FuturesPosLiab == input.FuturesPosLiab ||
                    (this.FuturesPosLiab != null &&
                    this.FuturesPosLiab.Equals(input.FuturesPosLiab))
                ) && 
                (
                    this.Equity == input.Equity ||
                    (this.Equity != null &&
                    this.Equity.Equals(input.Equity))
                ) && 
                (
                    this.TotalFreeze == input.TotalFreeze ||
                    (this.TotalFreeze != null &&
                    this.TotalFreeze.Equals(input.TotalFreeze))
                ) && 
                (
                    this.TotalLiab == input.TotalLiab ||
                    (this.TotalLiab != null &&
                    this.TotalLiab.Equals(input.TotalLiab))
                ) && 
                (
                    this.SpotInUse == input.SpotInUse ||
                    (this.SpotInUse != null &&
                    this.SpotInUse.Equals(input.SpotInUse))
                ) && 
                (
                    this.Funding == input.Funding ||
                    (this.Funding != null &&
                    this.Funding.Equals(input.Funding))
                ) && 
                (
                    this.FundingVersion == input.FundingVersion ||
                    (this.FundingVersion != null &&
                    this.FundingVersion.Equals(input.FundingVersion))
                ) && 
                (
                    this.CrossBalance == input.CrossBalance ||
                    (this.CrossBalance != null &&
                    this.CrossBalance.Equals(input.CrossBalance))
                ) && 
                (
                    this.IsoBalance == input.IsoBalance ||
                    (this.IsoBalance != null &&
                    this.IsoBalance.Equals(input.IsoBalance))
                ) && 
                (
                    this.Im == input.Im ||
                    (this.Im != null &&
                    this.Im.Equals(input.Im))
                ) && 
                (
                    this.Mm == input.Mm ||
                    (this.Mm != null &&
                    this.Mm.Equals(input.Mm))
                ) && 
                (
                    this.Imr == input.Imr ||
                    (this.Imr != null &&
                    this.Imr.Equals(input.Imr))
                ) && 
                (
                    this.Mmr == input.Mmr ||
                    (this.Mmr != null &&
                    this.Mmr.Equals(input.Mmr))
                ) && 
                (
                    this.MarginBalance == input.MarginBalance ||
                    (this.MarginBalance != null &&
                    this.MarginBalance.Equals(input.MarginBalance))
                ) && 
                (
                    this.AvailableMargin == input.AvailableMargin ||
                    (this.AvailableMargin != null &&
                    this.AvailableMargin.Equals(input.AvailableMargin))
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
                if (this.Available != null)
                    hashCode = hashCode * 59 + this.Available.GetHashCode();
                if (this.Freeze != null)
                    hashCode = hashCode * 59 + this.Freeze.GetHashCode();
                if (this.Borrowed != null)
                    hashCode = hashCode * 59 + this.Borrowed.GetHashCode();
                if (this.NegativeLiab != null)
                    hashCode = hashCode * 59 + this.NegativeLiab.GetHashCode();
                if (this.FuturesPosLiab != null)
                    hashCode = hashCode * 59 + this.FuturesPosLiab.GetHashCode();
                if (this.Equity != null)
                    hashCode = hashCode * 59 + this.Equity.GetHashCode();
                if (this.TotalFreeze != null)
                    hashCode = hashCode * 59 + this.TotalFreeze.GetHashCode();
                if (this.TotalLiab != null)
                    hashCode = hashCode * 59 + this.TotalLiab.GetHashCode();
                if (this.SpotInUse != null)
                    hashCode = hashCode * 59 + this.SpotInUse.GetHashCode();
                if (this.Funding != null)
                    hashCode = hashCode * 59 + this.Funding.GetHashCode();
                if (this.FundingVersion != null)
                    hashCode = hashCode * 59 + this.FundingVersion.GetHashCode();
                if (this.CrossBalance != null)
                    hashCode = hashCode * 59 + this.CrossBalance.GetHashCode();
                if (this.IsoBalance != null)
                    hashCode = hashCode * 59 + this.IsoBalance.GetHashCode();
                if (this.Im != null)
                    hashCode = hashCode * 59 + this.Im.GetHashCode();
                if (this.Mm != null)
                    hashCode = hashCode * 59 + this.Mm.GetHashCode();
                if (this.Imr != null)
                    hashCode = hashCode * 59 + this.Imr.GetHashCode();
                if (this.Mmr != null)
                    hashCode = hashCode * 59 + this.Mmr.GetHashCode();
                if (this.MarginBalance != null)
                    hashCode = hashCode * 59 + this.MarginBalance.GetHashCode();
                if (this.AvailableMargin != null)
                    hashCode = hashCode * 59 + this.AvailableMargin.GetHashCode();
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
