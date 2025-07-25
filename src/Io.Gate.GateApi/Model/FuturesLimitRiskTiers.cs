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
    /// Retrieve risk limit configurations for different tiers under a specified contract.
    /// </summary>
    [DataContract]
    public partial class FuturesLimitRiskTiers :  IEquatable<FuturesLimitRiskTiers>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FuturesLimitRiskTiers" /> class.
        /// </summary>
        /// <param name="tier">Tier..</param>
        /// <param name="riskLimit">Position risk limit..</param>
        /// <param name="initialRate">Initial margin rate..</param>
        /// <param name="maintenanceRate">Maintenance margin rate..</param>
        /// <param name="leverageMax">Maximum leverage..</param>
        /// <param name="contract">Markets, visible only during market pagination requests..</param>
        /// <param name="deduction">Maintenance margin quick calculation deduction..</param>
        public FuturesLimitRiskTiers(int tier = default(int), string riskLimit = default(string), string initialRate = default(string), string maintenanceRate = default(string), string leverageMax = default(string), string contract = default(string), string deduction = default(string))
        {
            this.Tier = tier;
            this.RiskLimit = riskLimit;
            this.InitialRate = initialRate;
            this.MaintenanceRate = maintenanceRate;
            this.LeverageMax = leverageMax;
            this.Contract = contract;
            this.Deduction = deduction;
        }

        /// <summary>
        /// Tier.
        /// </summary>
        /// <value>Tier.</value>
        [DataMember(Name="tier")]
        public int Tier { get; set; }

        /// <summary>
        /// Position risk limit.
        /// </summary>
        /// <value>Position risk limit.</value>
        [DataMember(Name="risk_limit")]
        public string RiskLimit { get; set; }

        /// <summary>
        /// Initial margin rate.
        /// </summary>
        /// <value>Initial margin rate.</value>
        [DataMember(Name="initial_rate")]
        public string InitialRate { get; set; }

        /// <summary>
        /// Maintenance margin rate.
        /// </summary>
        /// <value>Maintenance margin rate.</value>
        [DataMember(Name="maintenance_rate")]
        public string MaintenanceRate { get; set; }

        /// <summary>
        /// Maximum leverage.
        /// </summary>
        /// <value>Maximum leverage.</value>
        [DataMember(Name="leverage_max")]
        public string LeverageMax { get; set; }

        /// <summary>
        /// Markets, visible only during market pagination requests.
        /// </summary>
        /// <value>Markets, visible only during market pagination requests.</value>
        [DataMember(Name="contract")]
        public string Contract { get; set; }

        /// <summary>
        /// Maintenance margin quick calculation deduction.
        /// </summary>
        /// <value>Maintenance margin quick calculation deduction.</value>
        [DataMember(Name="deduction")]
        public string Deduction { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FuturesLimitRiskTiers {\n");
            sb.Append("  Tier: ").Append(Tier).Append("\n");
            sb.Append("  RiskLimit: ").Append(RiskLimit).Append("\n");
            sb.Append("  InitialRate: ").Append(InitialRate).Append("\n");
            sb.Append("  MaintenanceRate: ").Append(MaintenanceRate).Append("\n");
            sb.Append("  LeverageMax: ").Append(LeverageMax).Append("\n");
            sb.Append("  Contract: ").Append(Contract).Append("\n");
            sb.Append("  Deduction: ").Append(Deduction).Append("\n");
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
            return this.Equals(input as FuturesLimitRiskTiers);
        }

        /// <summary>
        /// Returns true if FuturesLimitRiskTiers instances are equal
        /// </summary>
        /// <param name="input">Instance of FuturesLimitRiskTiers to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FuturesLimitRiskTiers input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Tier == input.Tier ||
                    this.Tier.Equals(input.Tier)
                ) && 
                (
                    this.RiskLimit == input.RiskLimit ||
                    (this.RiskLimit != null &&
                    this.RiskLimit.Equals(input.RiskLimit))
                ) && 
                (
                    this.InitialRate == input.InitialRate ||
                    (this.InitialRate != null &&
                    this.InitialRate.Equals(input.InitialRate))
                ) && 
                (
                    this.MaintenanceRate == input.MaintenanceRate ||
                    (this.MaintenanceRate != null &&
                    this.MaintenanceRate.Equals(input.MaintenanceRate))
                ) && 
                (
                    this.LeverageMax == input.LeverageMax ||
                    (this.LeverageMax != null &&
                    this.LeverageMax.Equals(input.LeverageMax))
                ) && 
                (
                    this.Contract == input.Contract ||
                    (this.Contract != null &&
                    this.Contract.Equals(input.Contract))
                ) && 
                (
                    this.Deduction == input.Deduction ||
                    (this.Deduction != null &&
                    this.Deduction.Equals(input.Deduction))
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
                hashCode = hashCode * 59 + this.Tier.GetHashCode();
                if (this.RiskLimit != null)
                    hashCode = hashCode * 59 + this.RiskLimit.GetHashCode();
                if (this.InitialRate != null)
                    hashCode = hashCode * 59 + this.InitialRate.GetHashCode();
                if (this.MaintenanceRate != null)
                    hashCode = hashCode * 59 + this.MaintenanceRate.GetHashCode();
                if (this.LeverageMax != null)
                    hashCode = hashCode * 59 + this.LeverageMax.GetHashCode();
                if (this.Contract != null)
                    hashCode = hashCode * 59 + this.Contract.GetHashCode();
                if (this.Deduction != null)
                    hashCode = hashCode * 59 + this.Deduction.GetHashCode();
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
