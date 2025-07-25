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
    /// FuturesTicker
    /// </summary>
    [DataContract]
    public partial class FuturesTicker :  IEquatable<FuturesTicker>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FuturesTicker" /> class.
        /// </summary>
        /// <param name="contract">Futures contract..</param>
        /// <param name="last">Last trading price..</param>
        /// <param name="changePercentage">Change percentage..</param>
        /// <param name="totalSize">Contract total size..</param>
        /// <param name="low24h">Lowest trading price in recent 24h..</param>
        /// <param name="high24h">Highest trading price in recent 24h..</param>
        /// <param name="volume24h">Trade size in recent 24h..</param>
        /// <param name="volume24hBtc">Trade volumes in recent 24h in BTC(deprecated, use &#x60;volume_24h_base&#x60;, &#x60;volume_24h_quote&#x60;, &#x60;volume_24h_settle&#x60; instead).</param>
        /// <param name="volume24hUsd">Trade volumes in recent 24h in USD(deprecated, use &#x60;volume_24h_base&#x60;, &#x60;volume_24h_quote&#x60;, &#x60;volume_24h_settle&#x60; instead).</param>
        /// <param name="volume24hBase">Trade volume in recent 24h, in base currency..</param>
        /// <param name="volume24hQuote">Trade volume in recent 24h, in quote currency..</param>
        /// <param name="volume24hSettle">Trade volume in recent 24h, in settle currency..</param>
        /// <param name="markPrice">Recent mark price..</param>
        /// <param name="fundingRate">Funding rate..</param>
        /// <param name="fundingRateIndicative">Indicative Funding rate in next period. (deprecated. use &#x60;funding_rate&#x60;)..</param>
        /// <param name="indexPrice">Index price..</param>
        /// <param name="quantoBaseRate">Exchange rate of base currency and settlement currency in Quanto contract. Does not exists in contracts of other types.</param>
        /// <param name="lowestAsk">Recent lowest ask..</param>
        /// <param name="lowestSize">The latest seller&#39;s lowest price order quantity..</param>
        /// <param name="highestBid">Recent highest bid..</param>
        /// <param name="highestSize">The latest buyer&#39;s highest price order volume..</param>
        public FuturesTicker(string contract = default(string), string last = default(string), string changePercentage = default(string), string totalSize = default(string), string low24h = default(string), string high24h = default(string), string volume24h = default(string), string volume24hBtc = default(string), string volume24hUsd = default(string), string volume24hBase = default(string), string volume24hQuote = default(string), string volume24hSettle = default(string), string markPrice = default(string), string fundingRate = default(string), string fundingRateIndicative = default(string), string indexPrice = default(string), string quantoBaseRate = default(string), string lowestAsk = default(string), string lowestSize = default(string), string highestBid = default(string), string highestSize = default(string))
        {
            this.Contract = contract;
            this.Last = last;
            this.ChangePercentage = changePercentage;
            this.TotalSize = totalSize;
            this.Low24h = low24h;
            this.High24h = high24h;
            this.Volume24h = volume24h;
            this.Volume24hBtc = volume24hBtc;
            this.Volume24hUsd = volume24hUsd;
            this.Volume24hBase = volume24hBase;
            this.Volume24hQuote = volume24hQuote;
            this.Volume24hSettle = volume24hSettle;
            this.MarkPrice = markPrice;
            this.FundingRate = fundingRate;
            this.FundingRateIndicative = fundingRateIndicative;
            this.IndexPrice = indexPrice;
            this.QuantoBaseRate = quantoBaseRate;
            this.LowestAsk = lowestAsk;
            this.LowestSize = lowestSize;
            this.HighestBid = highestBid;
            this.HighestSize = highestSize;
        }

        /// <summary>
        /// Futures contract.
        /// </summary>
        /// <value>Futures contract.</value>
        [DataMember(Name="contract")]
        public string Contract { get; set; }

        /// <summary>
        /// Last trading price.
        /// </summary>
        /// <value>Last trading price.</value>
        [DataMember(Name="last")]
        public string Last { get; set; }

        /// <summary>
        /// Change percentage.
        /// </summary>
        /// <value>Change percentage.</value>
        [DataMember(Name="change_percentage")]
        public string ChangePercentage { get; set; }

        /// <summary>
        /// Contract total size.
        /// </summary>
        /// <value>Contract total size.</value>
        [DataMember(Name="total_size")]
        public string TotalSize { get; set; }

        /// <summary>
        /// Lowest trading price in recent 24h.
        /// </summary>
        /// <value>Lowest trading price in recent 24h.</value>
        [DataMember(Name="low_24h")]
        public string Low24h { get; set; }

        /// <summary>
        /// Highest trading price in recent 24h.
        /// </summary>
        /// <value>Highest trading price in recent 24h.</value>
        [DataMember(Name="high_24h")]
        public string High24h { get; set; }

        /// <summary>
        /// Trade size in recent 24h.
        /// </summary>
        /// <value>Trade size in recent 24h.</value>
        [DataMember(Name="volume_24h")]
        public string Volume24h { get; set; }

        /// <summary>
        /// Trade volumes in recent 24h in BTC(deprecated, use &#x60;volume_24h_base&#x60;, &#x60;volume_24h_quote&#x60;, &#x60;volume_24h_settle&#x60; instead)
        /// </summary>
        /// <value>Trade volumes in recent 24h in BTC(deprecated, use &#x60;volume_24h_base&#x60;, &#x60;volume_24h_quote&#x60;, &#x60;volume_24h_settle&#x60; instead)</value>
        [DataMember(Name="volume_24h_btc")]
        public string Volume24hBtc { get; set; }

        /// <summary>
        /// Trade volumes in recent 24h in USD(deprecated, use &#x60;volume_24h_base&#x60;, &#x60;volume_24h_quote&#x60;, &#x60;volume_24h_settle&#x60; instead)
        /// </summary>
        /// <value>Trade volumes in recent 24h in USD(deprecated, use &#x60;volume_24h_base&#x60;, &#x60;volume_24h_quote&#x60;, &#x60;volume_24h_settle&#x60; instead)</value>
        [DataMember(Name="volume_24h_usd")]
        public string Volume24hUsd { get; set; }

        /// <summary>
        /// Trade volume in recent 24h, in base currency.
        /// </summary>
        /// <value>Trade volume in recent 24h, in base currency.</value>
        [DataMember(Name="volume_24h_base")]
        public string Volume24hBase { get; set; }

        /// <summary>
        /// Trade volume in recent 24h, in quote currency.
        /// </summary>
        /// <value>Trade volume in recent 24h, in quote currency.</value>
        [DataMember(Name="volume_24h_quote")]
        public string Volume24hQuote { get; set; }

        /// <summary>
        /// Trade volume in recent 24h, in settle currency.
        /// </summary>
        /// <value>Trade volume in recent 24h, in settle currency.</value>
        [DataMember(Name="volume_24h_settle")]
        public string Volume24hSettle { get; set; }

        /// <summary>
        /// Recent mark price.
        /// </summary>
        /// <value>Recent mark price.</value>
        [DataMember(Name="mark_price")]
        public string MarkPrice { get; set; }

        /// <summary>
        /// Funding rate.
        /// </summary>
        /// <value>Funding rate.</value>
        [DataMember(Name="funding_rate")]
        public string FundingRate { get; set; }

        /// <summary>
        /// Indicative Funding rate in next period. (deprecated. use &#x60;funding_rate&#x60;).
        /// </summary>
        /// <value>Indicative Funding rate in next period. (deprecated. use &#x60;funding_rate&#x60;).</value>
        [DataMember(Name="funding_rate_indicative")]
        public string FundingRateIndicative { get; set; }

        /// <summary>
        /// Index price.
        /// </summary>
        /// <value>Index price.</value>
        [DataMember(Name="index_price")]
        public string IndexPrice { get; set; }

        /// <summary>
        /// Exchange rate of base currency and settlement currency in Quanto contract. Does not exists in contracts of other types
        /// </summary>
        /// <value>Exchange rate of base currency and settlement currency in Quanto contract. Does not exists in contracts of other types</value>
        [DataMember(Name="quanto_base_rate")]
        public string QuantoBaseRate { get; set; }

        /// <summary>
        /// Recent lowest ask.
        /// </summary>
        /// <value>Recent lowest ask.</value>
        [DataMember(Name="lowest_ask")]
        public string LowestAsk { get; set; }

        /// <summary>
        /// The latest seller&#39;s lowest price order quantity.
        /// </summary>
        /// <value>The latest seller&#39;s lowest price order quantity.</value>
        [DataMember(Name="lowest_size")]
        public string LowestSize { get; set; }

        /// <summary>
        /// Recent highest bid.
        /// </summary>
        /// <value>Recent highest bid.</value>
        [DataMember(Name="highest_bid")]
        public string HighestBid { get; set; }

        /// <summary>
        /// The latest buyer&#39;s highest price order volume.
        /// </summary>
        /// <value>The latest buyer&#39;s highest price order volume.</value>
        [DataMember(Name="highest_size")]
        public string HighestSize { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FuturesTicker {\n");
            sb.Append("  Contract: ").Append(Contract).Append("\n");
            sb.Append("  Last: ").Append(Last).Append("\n");
            sb.Append("  ChangePercentage: ").Append(ChangePercentage).Append("\n");
            sb.Append("  TotalSize: ").Append(TotalSize).Append("\n");
            sb.Append("  Low24h: ").Append(Low24h).Append("\n");
            sb.Append("  High24h: ").Append(High24h).Append("\n");
            sb.Append("  Volume24h: ").Append(Volume24h).Append("\n");
            sb.Append("  Volume24hBtc: ").Append(Volume24hBtc).Append("\n");
            sb.Append("  Volume24hUsd: ").Append(Volume24hUsd).Append("\n");
            sb.Append("  Volume24hBase: ").Append(Volume24hBase).Append("\n");
            sb.Append("  Volume24hQuote: ").Append(Volume24hQuote).Append("\n");
            sb.Append("  Volume24hSettle: ").Append(Volume24hSettle).Append("\n");
            sb.Append("  MarkPrice: ").Append(MarkPrice).Append("\n");
            sb.Append("  FundingRate: ").Append(FundingRate).Append("\n");
            sb.Append("  FundingRateIndicative: ").Append(FundingRateIndicative).Append("\n");
            sb.Append("  IndexPrice: ").Append(IndexPrice).Append("\n");
            sb.Append("  QuantoBaseRate: ").Append(QuantoBaseRate).Append("\n");
            sb.Append("  LowestAsk: ").Append(LowestAsk).Append("\n");
            sb.Append("  LowestSize: ").Append(LowestSize).Append("\n");
            sb.Append("  HighestBid: ").Append(HighestBid).Append("\n");
            sb.Append("  HighestSize: ").Append(HighestSize).Append("\n");
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
            return this.Equals(input as FuturesTicker);
        }

        /// <summary>
        /// Returns true if FuturesTicker instances are equal
        /// </summary>
        /// <param name="input">Instance of FuturesTicker to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FuturesTicker input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Contract == input.Contract ||
                    (this.Contract != null &&
                    this.Contract.Equals(input.Contract))
                ) && 
                (
                    this.Last == input.Last ||
                    (this.Last != null &&
                    this.Last.Equals(input.Last))
                ) && 
                (
                    this.ChangePercentage == input.ChangePercentage ||
                    (this.ChangePercentage != null &&
                    this.ChangePercentage.Equals(input.ChangePercentage))
                ) && 
                (
                    this.TotalSize == input.TotalSize ||
                    (this.TotalSize != null &&
                    this.TotalSize.Equals(input.TotalSize))
                ) && 
                (
                    this.Low24h == input.Low24h ||
                    (this.Low24h != null &&
                    this.Low24h.Equals(input.Low24h))
                ) && 
                (
                    this.High24h == input.High24h ||
                    (this.High24h != null &&
                    this.High24h.Equals(input.High24h))
                ) && 
                (
                    this.Volume24h == input.Volume24h ||
                    (this.Volume24h != null &&
                    this.Volume24h.Equals(input.Volume24h))
                ) && 
                (
                    this.Volume24hBtc == input.Volume24hBtc ||
                    (this.Volume24hBtc != null &&
                    this.Volume24hBtc.Equals(input.Volume24hBtc))
                ) && 
                (
                    this.Volume24hUsd == input.Volume24hUsd ||
                    (this.Volume24hUsd != null &&
                    this.Volume24hUsd.Equals(input.Volume24hUsd))
                ) && 
                (
                    this.Volume24hBase == input.Volume24hBase ||
                    (this.Volume24hBase != null &&
                    this.Volume24hBase.Equals(input.Volume24hBase))
                ) && 
                (
                    this.Volume24hQuote == input.Volume24hQuote ||
                    (this.Volume24hQuote != null &&
                    this.Volume24hQuote.Equals(input.Volume24hQuote))
                ) && 
                (
                    this.Volume24hSettle == input.Volume24hSettle ||
                    (this.Volume24hSettle != null &&
                    this.Volume24hSettle.Equals(input.Volume24hSettle))
                ) && 
                (
                    this.MarkPrice == input.MarkPrice ||
                    (this.MarkPrice != null &&
                    this.MarkPrice.Equals(input.MarkPrice))
                ) && 
                (
                    this.FundingRate == input.FundingRate ||
                    (this.FundingRate != null &&
                    this.FundingRate.Equals(input.FundingRate))
                ) && 
                (
                    this.FundingRateIndicative == input.FundingRateIndicative ||
                    (this.FundingRateIndicative != null &&
                    this.FundingRateIndicative.Equals(input.FundingRateIndicative))
                ) && 
                (
                    this.IndexPrice == input.IndexPrice ||
                    (this.IndexPrice != null &&
                    this.IndexPrice.Equals(input.IndexPrice))
                ) && 
                (
                    this.QuantoBaseRate == input.QuantoBaseRate ||
                    (this.QuantoBaseRate != null &&
                    this.QuantoBaseRate.Equals(input.QuantoBaseRate))
                ) && 
                (
                    this.LowestAsk == input.LowestAsk ||
                    (this.LowestAsk != null &&
                    this.LowestAsk.Equals(input.LowestAsk))
                ) && 
                (
                    this.LowestSize == input.LowestSize ||
                    (this.LowestSize != null &&
                    this.LowestSize.Equals(input.LowestSize))
                ) && 
                (
                    this.HighestBid == input.HighestBid ||
                    (this.HighestBid != null &&
                    this.HighestBid.Equals(input.HighestBid))
                ) && 
                (
                    this.HighestSize == input.HighestSize ||
                    (this.HighestSize != null &&
                    this.HighestSize.Equals(input.HighestSize))
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
                if (this.Contract != null)
                    hashCode = hashCode * 59 + this.Contract.GetHashCode();
                if (this.Last != null)
                    hashCode = hashCode * 59 + this.Last.GetHashCode();
                if (this.ChangePercentage != null)
                    hashCode = hashCode * 59 + this.ChangePercentage.GetHashCode();
                if (this.TotalSize != null)
                    hashCode = hashCode * 59 + this.TotalSize.GetHashCode();
                if (this.Low24h != null)
                    hashCode = hashCode * 59 + this.Low24h.GetHashCode();
                if (this.High24h != null)
                    hashCode = hashCode * 59 + this.High24h.GetHashCode();
                if (this.Volume24h != null)
                    hashCode = hashCode * 59 + this.Volume24h.GetHashCode();
                if (this.Volume24hBtc != null)
                    hashCode = hashCode * 59 + this.Volume24hBtc.GetHashCode();
                if (this.Volume24hUsd != null)
                    hashCode = hashCode * 59 + this.Volume24hUsd.GetHashCode();
                if (this.Volume24hBase != null)
                    hashCode = hashCode * 59 + this.Volume24hBase.GetHashCode();
                if (this.Volume24hQuote != null)
                    hashCode = hashCode * 59 + this.Volume24hQuote.GetHashCode();
                if (this.Volume24hSettle != null)
                    hashCode = hashCode * 59 + this.Volume24hSettle.GetHashCode();
                if (this.MarkPrice != null)
                    hashCode = hashCode * 59 + this.MarkPrice.GetHashCode();
                if (this.FundingRate != null)
                    hashCode = hashCode * 59 + this.FundingRate.GetHashCode();
                if (this.FundingRateIndicative != null)
                    hashCode = hashCode * 59 + this.FundingRateIndicative.GetHashCode();
                if (this.IndexPrice != null)
                    hashCode = hashCode * 59 + this.IndexPrice.GetHashCode();
                if (this.QuantoBaseRate != null)
                    hashCode = hashCode * 59 + this.QuantoBaseRate.GetHashCode();
                if (this.LowestAsk != null)
                    hashCode = hashCode * 59 + this.LowestAsk.GetHashCode();
                if (this.LowestSize != null)
                    hashCode = hashCode * 59 + this.LowestSize.GetHashCode();
                if (this.HighestBid != null)
                    hashCode = hashCode * 59 + this.HighestBid.GetHashCode();
                if (this.HighestSize != null)
                    hashCode = hashCode * 59 + this.HighestSize.GetHashCode();
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
