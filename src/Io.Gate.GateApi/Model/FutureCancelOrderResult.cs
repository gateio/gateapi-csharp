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
    public partial class FutureCancelOrderResult :  IEquatable<FutureCancelOrderResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FutureCancelOrderResult" /> class.
        /// </summary>
        /// <param name="id">Order ID.</param>
        /// <param name="userId">User ID.</param>
        /// <param name="succeeded">Whether cancellation succeeded.</param>
        /// <param name="message">Error message when failed to cancel the order; empty if succeeded.</param>
        public FutureCancelOrderResult(string id = default(string), long userId = default(long), bool succeeded = default(bool), string message = default(string))
        {
            this.Id = id;
            this.UserId = userId;
            this.Succeeded = succeeded;
            this.Message = message;
        }

        /// <summary>
        /// Order ID
        /// </summary>
        /// <value>Order ID</value>
        [DataMember(Name="id")]
        public string Id { get; set; }

        /// <summary>
        /// User ID
        /// </summary>
        /// <value>User ID</value>
        [DataMember(Name="user_id")]
        public long UserId { get; set; }

        /// <summary>
        /// Whether cancellation succeeded
        /// </summary>
        /// <value>Whether cancellation succeeded</value>
        [DataMember(Name="succeeded")]
        public bool Succeeded { get; set; }

        /// <summary>
        /// Error message when failed to cancel the order; empty if succeeded
        /// </summary>
        /// <value>Error message when failed to cancel the order; empty if succeeded</value>
        [DataMember(Name="message")]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FutureCancelOrderResult {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Succeeded: ").Append(Succeeded).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return this.Equals(input as FutureCancelOrderResult);
        }

        /// <summary>
        /// Returns true if FutureCancelOrderResult instances are equal
        /// </summary>
        /// <param name="input">Instance of FutureCancelOrderResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FutureCancelOrderResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.UserId == input.UserId ||
                    this.UserId.Equals(input.UserId)
                ) && 
                (
                    this.Succeeded == input.Succeeded ||
                    this.Succeeded.Equals(input.Succeeded)
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                hashCode = hashCode * 59 + this.UserId.GetHashCode();
                hashCode = hashCode * 59 + this.Succeeded.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
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
