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
    /// Parameters of flash swap order creation.
    /// </summary>
    [DataContract]
    public partial class FlashSwapPreviewRequest :  IEquatable<FlashSwapPreviewRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FlashSwapPreviewRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FlashSwapPreviewRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FlashSwapPreviewRequest" /> class.
        /// </summary>
        /// <param name="sellCurrency">The name of the asset being sold, as obtained from the \&quot;GET /flash_swap/currency_pairs\&quot; API, which retrieves a list of supported flash swap currency pairs. (required).</param>
        /// <param name="sellAmount">Amount to sell. It is required to choose one parameter between &#x60;sell_amount&#x60; and &#x60;buy_amount&#x60;.</param>
        /// <param name="buyCurrency">The name of the asset being purchased, as obtained from the \&quot;GET /flash_swap/currency_pairs\&quot; API, which provides a list of supported flash swap currency pairs. (required).</param>
        /// <param name="buyAmount">Amount to buy. It is required to choose one parameter between &#x60;sell_amount&#x60; and &#x60;buy_amount&#x60;.</param>
        public FlashSwapPreviewRequest(string sellCurrency = default(string), string sellAmount = default(string), string buyCurrency = default(string), string buyAmount = default(string))
        {
            // to ensure "sellCurrency" is required (not null)
            this.SellCurrency = sellCurrency ?? throw new ArgumentNullException("sellCurrency", "sellCurrency is a required property for FlashSwapPreviewRequest and cannot be null");
            // to ensure "buyCurrency" is required (not null)
            this.BuyCurrency = buyCurrency ?? throw new ArgumentNullException("buyCurrency", "buyCurrency is a required property for FlashSwapPreviewRequest and cannot be null");
            this.SellAmount = sellAmount;
            this.BuyAmount = buyAmount;
        }

        /// <summary>
        /// The name of the asset being sold, as obtained from the \&quot;GET /flash_swap/currency_pairs\&quot; API, which retrieves a list of supported flash swap currency pairs.
        /// </summary>
        /// <value>The name of the asset being sold, as obtained from the \&quot;GET /flash_swap/currency_pairs\&quot; API, which retrieves a list of supported flash swap currency pairs.</value>
        [DataMember(Name="sell_currency")]
        public string SellCurrency { get; set; }

        /// <summary>
        /// Amount to sell. It is required to choose one parameter between &#x60;sell_amount&#x60; and &#x60;buy_amount&#x60;
        /// </summary>
        /// <value>Amount to sell. It is required to choose one parameter between &#x60;sell_amount&#x60; and &#x60;buy_amount&#x60;</value>
        [DataMember(Name="sell_amount")]
        public string SellAmount { get; set; }

        /// <summary>
        /// The name of the asset being purchased, as obtained from the \&quot;GET /flash_swap/currency_pairs\&quot; API, which provides a list of supported flash swap currency pairs.
        /// </summary>
        /// <value>The name of the asset being purchased, as obtained from the \&quot;GET /flash_swap/currency_pairs\&quot; API, which provides a list of supported flash swap currency pairs.</value>
        [DataMember(Name="buy_currency")]
        public string BuyCurrency { get; set; }

        /// <summary>
        /// Amount to buy. It is required to choose one parameter between &#x60;sell_amount&#x60; and &#x60;buy_amount&#x60;
        /// </summary>
        /// <value>Amount to buy. It is required to choose one parameter between &#x60;sell_amount&#x60; and &#x60;buy_amount&#x60;</value>
        [DataMember(Name="buy_amount")]
        public string BuyAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlashSwapPreviewRequest {\n");
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
            return this.Equals(input as FlashSwapPreviewRequest);
        }

        /// <summary>
        /// Returns true if FlashSwapPreviewRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of FlashSwapPreviewRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlashSwapPreviewRequest input)
        {
            if (input == null)
                return false;

            return 
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
