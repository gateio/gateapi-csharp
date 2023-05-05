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
    /// Parameters of flash swap order creation
    /// </summary>
    [DataContract]
    public partial class FlashSwapOrderRequest :  IEquatable<FlashSwapOrderRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FlashSwapOrderRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FlashSwapOrderRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FlashSwapOrderRequest" /> class.
        /// </summary>
        /// <param name="previewId">Preview result ID (required).</param>
        /// <param name="sellCurrency">Currency to sell which can be retrieved from supported currency list API &#x60;GET /flash_swap/currencies&#x60; (required).</param>
        /// <param name="sellAmount">Amount to sell (based on the preview result) (required).</param>
        /// <param name="buyCurrency">Currency to buy which can be retrieved from supported currency list API &#x60;GET /flash_swap/currencies&#x60; (required).</param>
        /// <param name="buyAmount">Amount to buy (based on the preview result) (required).</param>
        public FlashSwapOrderRequest(string previewId = default(string), string sellCurrency = default(string), string sellAmount = default(string), string buyCurrency = default(string), string buyAmount = default(string))
        {
            // to ensure "previewId" is required (not null)
            this.PreviewId = previewId ?? throw new ArgumentNullException("previewId", "previewId is a required property for FlashSwapOrderRequest and cannot be null");
            // to ensure "sellCurrency" is required (not null)
            this.SellCurrency = sellCurrency ?? throw new ArgumentNullException("sellCurrency", "sellCurrency is a required property for FlashSwapOrderRequest and cannot be null");
            // to ensure "sellAmount" is required (not null)
            this.SellAmount = sellAmount ?? throw new ArgumentNullException("sellAmount", "sellAmount is a required property for FlashSwapOrderRequest and cannot be null");
            // to ensure "buyCurrency" is required (not null)
            this.BuyCurrency = buyCurrency ?? throw new ArgumentNullException("buyCurrency", "buyCurrency is a required property for FlashSwapOrderRequest and cannot be null");
            // to ensure "buyAmount" is required (not null)
            this.BuyAmount = buyAmount ?? throw new ArgumentNullException("buyAmount", "buyAmount is a required property for FlashSwapOrderRequest and cannot be null");
        }

        /// <summary>
        /// Preview result ID
        /// </summary>
        /// <value>Preview result ID</value>
        [DataMember(Name="preview_id")]
        public string PreviewId { get; set; }

        /// <summary>
        /// Currency to sell which can be retrieved from supported currency list API &#x60;GET /flash_swap/currencies&#x60;
        /// </summary>
        /// <value>Currency to sell which can be retrieved from supported currency list API &#x60;GET /flash_swap/currencies&#x60;</value>
        [DataMember(Name="sell_currency")]
        public string SellCurrency { get; set; }

        /// <summary>
        /// Amount to sell (based on the preview result)
        /// </summary>
        /// <value>Amount to sell (based on the preview result)</value>
        [DataMember(Name="sell_amount")]
        public string SellAmount { get; set; }

        /// <summary>
        /// Currency to buy which can be retrieved from supported currency list API &#x60;GET /flash_swap/currencies&#x60;
        /// </summary>
        /// <value>Currency to buy which can be retrieved from supported currency list API &#x60;GET /flash_swap/currencies&#x60;</value>
        [DataMember(Name="buy_currency")]
        public string BuyCurrency { get; set; }

        /// <summary>
        /// Amount to buy (based on the preview result)
        /// </summary>
        /// <value>Amount to buy (based on the preview result)</value>
        [DataMember(Name="buy_amount")]
        public string BuyAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlashSwapOrderRequest {\n");
            sb.Append("  PreviewId: ").Append(PreviewId).Append("\n");
            sb.Append("  SellCurrency: ").Append(SellCurrency).Append("\n");
            sb.Append("  SellAmount: ").Append(SellAmount).Append("\n");
            sb.Append("  BuyCurrency: ").Append(BuyCurrency).Append("\n");
            sb.Append("  BuyAmount: ").Append(BuyAmount).Append("\n");
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
            return this.Equals(input as FlashSwapOrderRequest);
        }

        /// <summary>
        /// Returns true if FlashSwapOrderRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of FlashSwapOrderRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlashSwapOrderRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PreviewId == input.PreviewId ||
                    (this.PreviewId != null &&
                    this.PreviewId.Equals(input.PreviewId))
                ) && 
                (
                    this.SellCurrency == input.SellCurrency ||
                    (this.SellCurrency != null &&
                    this.SellCurrency.Equals(input.SellCurrency))
                ) && 
                (
                    this.SellAmount == input.SellAmount ||
                    (this.SellAmount != null &&
                    this.SellAmount.Equals(input.SellAmount))
                ) && 
                (
                    this.BuyCurrency == input.BuyCurrency ||
                    (this.BuyCurrency != null &&
                    this.BuyCurrency.Equals(input.BuyCurrency))
                ) && 
                (
                    this.BuyAmount == input.BuyAmount ||
                    (this.BuyAmount != null &&
                    this.BuyAmount.Equals(input.BuyAmount))
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
                if (this.PreviewId != null)
                    hashCode = hashCode * 59 + this.PreviewId.GetHashCode();
                if (this.SellCurrency != null)
                    hashCode = hashCode * 59 + this.SellCurrency.GetHashCode();
                if (this.SellAmount != null)
                    hashCode = hashCode * 59 + this.SellAmount.GetHashCode();
                if (this.BuyCurrency != null)
                    hashCode = hashCode * 59 + this.BuyCurrency.GetHashCode();
                if (this.BuyAmount != null)
                    hashCode = hashCode * 59 + this.BuyAmount.GetHashCode();
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
