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
    /// SpotPricePutOrder
    /// </summary>
    [DataContract]
    public partial class SpotPricePutOrder :  IEquatable<SpotPricePutOrder>, IValidatableObject
    {
        /// <summary>
        /// Order type，default to &#x60;limit&#x60;  - limit : Limit Order - market : Market Order
        /// </summary>
        /// <value>Order type，default to &#x60;limit&#x60;  - limit : Limit Order - market : Market Order</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Limit for value: limit
            /// </summary>
            [EnumMember(Value = "limit")]
            Limit = 1,

            /// <summary>
            /// Enum Market for value: market
            /// </summary>
            [EnumMember(Value = "market")]
            Market = 2

        }

        /// <summary>
        /// Order type，default to &#x60;limit&#x60;  - limit : Limit Order - market : Market Order
        /// </summary>
        /// <value>Order type，default to &#x60;limit&#x60;  - limit : Limit Order - market : Market Order</value>
        [DataMember(Name="type")]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Order side  - buy: buy side - sell: sell side
        /// </summary>
        /// <value>Order side  - buy: buy side - sell: sell side</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SideEnum
        {
            /// <summary>
            /// Enum Buy for value: buy
            /// </summary>
            [EnumMember(Value = "buy")]
            Buy = 1,

            /// <summary>
            /// Enum Sell for value: sell
            /// </summary>
            [EnumMember(Value = "sell")]
            Sell = 2

        }

        /// <summary>
        /// Order side  - buy: buy side - sell: sell side
        /// </summary>
        /// <value>Order side  - buy: buy side - sell: sell side</value>
        [DataMember(Name="side")]
        public SideEnum Side { get; set; }
        /// <summary>
        /// Trading account type.  Portfolio margin account must set to &#x60;unified&#x60;  - normal: spot trading - margin: margin trading - unified: unified trading 
        /// </summary>
        /// <value>Trading account type.  Portfolio margin account must set to &#x60;unified&#x60;  - normal: spot trading - margin: margin trading - unified: unified trading </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AccountEnum
        {
            /// <summary>
            /// Enum Normal for value: normal
            /// </summary>
            [EnumMember(Value = "normal")]
            Normal = 1,

            /// <summary>
            /// Enum Margin for value: margin
            /// </summary>
            [EnumMember(Value = "margin")]
            Margin = 2,

            /// <summary>
            /// Enum Unified for value: unified
            /// </summary>
            [EnumMember(Value = "unified")]
            Unified = 3

        }

        /// <summary>
        /// Trading account type.  Portfolio margin account must set to &#x60;unified&#x60;  - normal: spot trading - margin: margin trading - unified: unified trading 
        /// </summary>
        /// <value>Trading account type.  Portfolio margin account must set to &#x60;unified&#x60;  - normal: spot trading - margin: margin trading - unified: unified trading </value>
        [DataMember(Name="account")]
        public AccountEnum Account { get; set; }
        /// <summary>
        /// time_in_force  - gtc: GoodTillCancelled - ioc: ImmediateOrCancelled, taker only 
        /// </summary>
        /// <value>time_in_force  - gtc: GoodTillCancelled - ioc: ImmediateOrCancelled, taker only </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TimeInForceEnum
        {
            /// <summary>
            /// Enum Gtc for value: gtc
            /// </summary>
            [EnumMember(Value = "gtc")]
            Gtc = 1,

            /// <summary>
            /// Enum Ioc for value: ioc
            /// </summary>
            [EnumMember(Value = "ioc")]
            Ioc = 2

        }

        /// <summary>
        /// time_in_force  - gtc: GoodTillCancelled - ioc: ImmediateOrCancelled, taker only 
        /// </summary>
        /// <value>time_in_force  - gtc: GoodTillCancelled - ioc: ImmediateOrCancelled, taker only </value>
        [DataMember(Name="time_in_force")]
        public TimeInForceEnum? TimeInForce { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SpotPricePutOrder" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SpotPricePutOrder() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SpotPricePutOrder" /> class.
        /// </summary>
        /// <param name="type">Order type，default to &#x60;limit&#x60;  - limit : Limit Order - market : Market Order (default to TypeEnum.Limit).</param>
        /// <param name="side">Order side  - buy: buy side - sell: sell side (required).</param>
        /// <param name="price">Order price (required).</param>
        /// <param name="amount">When &#x60;type&#x60; is limit, it refers to base currency.  For instance, &#x60;BTC_USDT&#x60; means &#x60;BTC&#x60;  When &#x60;type&#x60; is &#x60;market&#x60;, it refers to different currency according to &#x60;side&#x60;  - &#x60;side&#x60; : &#x60;buy&#x60; means quote currency, &#x60;BTC_USDT&#x60; means &#x60;USDT&#x60; - &#x60;side&#x60; : &#x60;sell&#x60; means base currency，&#x60;BTC_USDT&#x60; means &#x60;BTC&#x60;  (required).</param>
        /// <param name="account">Trading account type.  Portfolio margin account must set to &#x60;unified&#x60;  - normal: spot trading - margin: margin trading - unified: unified trading  (required) (default to AccountEnum.Normal).</param>
        /// <param name="timeInForce">time_in_force  - gtc: GoodTillCancelled - ioc: ImmediateOrCancelled, taker only  (default to TimeInForceEnum.Gtc).</param>
        /// <param name="autoBorrow">Whether to borrow coins automatically (default to false).</param>
        /// <param name="autoRepay">Whether to repay the loan automatically (default to false).</param>
        /// <param name="text">The source of the order, including: - web: web - api: api - app: app.</param>
        public SpotPricePutOrder(TypeEnum? type = TypeEnum.Limit, SideEnum side = default(SideEnum), string price = default(string), string amount = default(string), AccountEnum account = AccountEnum.Normal, TimeInForceEnum? timeInForce = TimeInForceEnum.Gtc, bool autoBorrow = false, bool autoRepay = false, string text = default(string))
        {
            this.Side = side;
            // to ensure "price" is required (not null)
            this.Price = price ?? throw new ArgumentNullException("price", "price is a required property for SpotPricePutOrder and cannot be null");
            // to ensure "amount" is required (not null)
            this.Amount = amount ?? throw new ArgumentNullException("amount", "amount is a required property for SpotPricePutOrder and cannot be null");
            this.Account = account;
            this.Type = type;
            this.TimeInForce = timeInForce;
            this.AutoBorrow = autoBorrow;
            this.AutoRepay = autoRepay;
            this.Text = text;
        }

        /// <summary>
        /// Order price
        /// </summary>
        /// <value>Order price</value>
        [DataMember(Name="price")]
        public string Price { get; set; }

        /// <summary>
        /// When &#x60;type&#x60; is limit, it refers to base currency.  For instance, &#x60;BTC_USDT&#x60; means &#x60;BTC&#x60;  When &#x60;type&#x60; is &#x60;market&#x60;, it refers to different currency according to &#x60;side&#x60;  - &#x60;side&#x60; : &#x60;buy&#x60; means quote currency, &#x60;BTC_USDT&#x60; means &#x60;USDT&#x60; - &#x60;side&#x60; : &#x60;sell&#x60; means base currency，&#x60;BTC_USDT&#x60; means &#x60;BTC&#x60; 
        /// </summary>
        /// <value>When &#x60;type&#x60; is limit, it refers to base currency.  For instance, &#x60;BTC_USDT&#x60; means &#x60;BTC&#x60;  When &#x60;type&#x60; is &#x60;market&#x60;, it refers to different currency according to &#x60;side&#x60;  - &#x60;side&#x60; : &#x60;buy&#x60; means quote currency, &#x60;BTC_USDT&#x60; means &#x60;USDT&#x60; - &#x60;side&#x60; : &#x60;sell&#x60; means base currency，&#x60;BTC_USDT&#x60; means &#x60;BTC&#x60; </value>
        [DataMember(Name="amount")]
        public string Amount { get; set; }

        /// <summary>
        /// Whether to borrow coins automatically
        /// </summary>
        /// <value>Whether to borrow coins automatically</value>
        [DataMember(Name="auto_borrow")]
        public bool AutoBorrow { get; set; }

        /// <summary>
        /// Whether to repay the loan automatically
        /// </summary>
        /// <value>Whether to repay the loan automatically</value>
        [DataMember(Name="auto_repay")]
        public bool AutoRepay { get; set; }

        /// <summary>
        /// The source of the order, including: - web: web - api: api - app: app
        /// </summary>
        /// <value>The source of the order, including: - web: web - api: api - app: app</value>
        [DataMember(Name="text")]
        public string Text { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SpotPricePutOrder {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Side: ").Append(Side).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  TimeInForce: ").Append(TimeInForce).Append("\n");
            sb.Append("  AutoBorrow: ").Append(AutoBorrow).Append("\n");
            sb.Append("  AutoRepay: ").Append(AutoRepay).Append("\n");
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
            return this.Equals(input as SpotPricePutOrder);
        }

        /// <summary>
        /// Returns true if SpotPricePutOrder instances are equal
        /// </summary>
        /// <param name="input">Instance of SpotPricePutOrder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SpotPricePutOrder input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Side == input.Side ||
                    this.Side.Equals(input.Side)
                ) && 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Account == input.Account ||
                    this.Account.Equals(input.Account)
                ) && 
                (
                    this.TimeInForce == input.TimeInForce ||
                    this.TimeInForce.Equals(input.TimeInForce)
                ) && 
                (
                    this.AutoBorrow == input.AutoBorrow ||
                    this.AutoBorrow.Equals(input.AutoBorrow)
                ) && 
                (
                    this.AutoRepay == input.AutoRepay ||
                    this.AutoRepay.Equals(input.AutoRepay)
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
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                hashCode = hashCode * 59 + this.Side.GetHashCode();
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                hashCode = hashCode * 59 + this.Account.GetHashCode();
                hashCode = hashCode * 59 + this.TimeInForce.GetHashCode();
                hashCode = hashCode * 59 + this.AutoBorrow.GetHashCode();
                hashCode = hashCode * 59 + this.AutoRepay.GetHashCode();
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
