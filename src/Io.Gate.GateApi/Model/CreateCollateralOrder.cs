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
    /// CreateCollateralOrder
    /// </summary>
    [DataContract]
    public partial class CreateCollateralOrder :  IEquatable<CreateCollateralOrder>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCollateralOrder" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateCollateralOrder() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCollateralOrder" /> class.
        /// </summary>
        /// <param name="collateralAmount">Collateral amount. (required).</param>
        /// <param name="collateralCurrency">Collateral. (required).</param>
        /// <param name="borrowAmount">Borrowing amount. (required).</param>
        /// <param name="borrowCurrency">Borrowed currency. (required).</param>
        public CreateCollateralOrder(string collateralAmount = default(string), string collateralCurrency = default(string), string borrowAmount = default(string), string borrowCurrency = default(string))
        {
            // to ensure "collateralAmount" is required (not null)
            this.CollateralAmount = collateralAmount ?? throw new ArgumentNullException("collateralAmount", "collateralAmount is a required property for CreateCollateralOrder and cannot be null");
            // to ensure "collateralCurrency" is required (not null)
            this.CollateralCurrency = collateralCurrency ?? throw new ArgumentNullException("collateralCurrency", "collateralCurrency is a required property for CreateCollateralOrder and cannot be null");
            // to ensure "borrowAmount" is required (not null)
            this.BorrowAmount = borrowAmount ?? throw new ArgumentNullException("borrowAmount", "borrowAmount is a required property for CreateCollateralOrder and cannot be null");
            // to ensure "borrowCurrency" is required (not null)
            this.BorrowCurrency = borrowCurrency ?? throw new ArgumentNullException("borrowCurrency", "borrowCurrency is a required property for CreateCollateralOrder and cannot be null");
        }

        /// <summary>
        /// Collateral amount.
        /// </summary>
        /// <value>Collateral amount.</value>
        [DataMember(Name="collateral_amount")]
        public string CollateralAmount { get; set; }

        /// <summary>
        /// Collateral.
        /// </summary>
        /// <value>Collateral.</value>
        [DataMember(Name="collateral_currency")]
        public string CollateralCurrency { get; set; }

        /// <summary>
        /// Borrowing amount.
        /// </summary>
        /// <value>Borrowing amount.</value>
        [DataMember(Name="borrow_amount")]
        public string BorrowAmount { get; set; }

        /// <summary>
        /// Borrowed currency.
        /// </summary>
        /// <value>Borrowed currency.</value>
        [DataMember(Name="borrow_currency")]
        public string BorrowCurrency { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateCollateralOrder {\n");
            sb.Append("  CollateralAmount: ").Append(CollateralAmount).Append("\n");
            sb.Append("  CollateralCurrency: ").Append(CollateralCurrency).Append("\n");
            sb.Append("  BorrowAmount: ").Append(BorrowAmount).Append("\n");
            sb.Append("  BorrowCurrency: ").Append(BorrowCurrency).Append("\n");
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
            return this.Equals(input as CreateCollateralOrder);
        }

        /// <summary>
        /// Returns true if CreateCollateralOrder instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateCollateralOrder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateCollateralOrder input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CollateralAmount == input.CollateralAmount ||
                    (this.CollateralAmount != null &&
                    this.CollateralAmount.Equals(input.CollateralAmount))
                ) && 
                (
                    this.CollateralCurrency == input.CollateralCurrency ||
                    (this.CollateralCurrency != null &&
                    this.CollateralCurrency.Equals(input.CollateralCurrency))
                ) && 
                (
                    this.BorrowAmount == input.BorrowAmount ||
                    (this.BorrowAmount != null &&
                    this.BorrowAmount.Equals(input.BorrowAmount))
                ) && 
                (
                    this.BorrowCurrency == input.BorrowCurrency ||
                    (this.BorrowCurrency != null &&
                    this.BorrowCurrency.Equals(input.BorrowCurrency))
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
                if (this.CollateralAmount != null)
                    hashCode = hashCode * 59 + this.CollateralAmount.GetHashCode();
                if (this.CollateralCurrency != null)
                    hashCode = hashCode * 59 + this.CollateralCurrency.GetHashCode();
                if (this.BorrowAmount != null)
                    hashCode = hashCode * 59 + this.BorrowAmount.GetHashCode();
                if (this.BorrowCurrency != null)
                    hashCode = hashCode * 59 + this.BorrowCurrency.GetHashCode();
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
