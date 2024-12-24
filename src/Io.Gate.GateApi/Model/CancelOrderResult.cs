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
    /// Order cancellation result
    /// </summary>
    [DataContract]
    public partial class CancelOrderResult :  IEquatable<CancelOrderResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CancelOrderResult" /> class.
        /// </summary>
        /// <param name="currencyPair">Order currency pair.</param>
        /// <param name="id">Order ID.</param>
        /// <param name="text">Custom order information.</param>
        /// <param name="succeeded">Whether cancellation succeeded.</param>
        /// <param name="label">Error label when failed to cancel the order; emtpy if succeeded.</param>
        /// <param name="message">Error message when failed to cancel the order; empty if succeeded.</param>
        /// <param name="account">Empty by default. If cancelled order is cross margin order, this field is set to &#x60;cross_margin&#x60;.</param>
        public CancelOrderResult(string currencyPair = default(string), string id = default(string), string text = default(string), bool succeeded = default(bool), string label = default(string), string message = default(string), string account = default(string))
        {
            this.CurrencyPair = currencyPair;
            this.Id = id;
            this.Text = text;
            this.Succeeded = succeeded;
            this.Label = label;
            this.Message = message;
            this.Account = account;
        }

        /// <summary>
        /// Order currency pair
        /// </summary>
        /// <value>Order currency pair</value>
        [DataMember(Name="currency_pair")]
        public string CurrencyPair { get; set; }

        /// <summary>
        /// Order ID
        /// </summary>
        /// <value>Order ID</value>
        [DataMember(Name="id")]
        public string Id { get; set; }

        /// <summary>
        /// Custom order information
        /// </summary>
        /// <value>Custom order information</value>
        [DataMember(Name="text")]
        public string Text { get; set; }

        /// <summary>
        /// Whether cancellation succeeded
        /// </summary>
        /// <value>Whether cancellation succeeded</value>
        [DataMember(Name="succeeded")]
        public bool Succeeded { get; set; }

        /// <summary>
        /// Error label when failed to cancel the order; emtpy if succeeded
        /// </summary>
        /// <value>Error label when failed to cancel the order; emtpy if succeeded</value>
        [DataMember(Name="label")]
        public string Label { get; set; }

        /// <summary>
        /// Error message when failed to cancel the order; empty if succeeded
        /// </summary>
        /// <value>Error message when failed to cancel the order; empty if succeeded</value>
        [DataMember(Name="message")]
        public string Message { get; set; }

        /// <summary>
        /// Empty by default. If cancelled order is cross margin order, this field is set to &#x60;cross_margin&#x60;
        /// </summary>
        /// <value>Empty by default. If cancelled order is cross margin order, this field is set to &#x60;cross_margin&#x60;</value>
        [DataMember(Name="account")]
        public string Account { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CancelOrderResult {\n");
            sb.Append("  CurrencyPair: ").Append(CurrencyPair).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Succeeded: ").Append(Succeeded).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
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
            return this.Equals(input as CancelOrderResult);
        }

        /// <summary>
        /// Returns true if CancelOrderResult instances are equal
        /// </summary>
        /// <param name="input">Instance of CancelOrderResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CancelOrderResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CurrencyPair == input.CurrencyPair ||
                    (this.CurrencyPair != null &&
                    this.CurrencyPair.Equals(input.CurrencyPair))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
                ) && 
                (
                    this.Succeeded == input.Succeeded ||
                    this.Succeeded.Equals(input.Succeeded)
                ) && 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Account == input.Account ||
                    (this.Account != null &&
                    this.Account.Equals(input.Account))
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
                if (this.CurrencyPair != null)
                    hashCode = hashCode * 59 + this.CurrencyPair.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Text != null)
                    hashCode = hashCode * 59 + this.Text.GetHashCode();
                hashCode = hashCode * 59 + this.Succeeded.GetHashCode();
                if (this.Label != null)
                    hashCode = hashCode * 59 + this.Label.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.Account != null)
                    hashCode = hashCode * 59 + this.Account.GetHashCode();
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