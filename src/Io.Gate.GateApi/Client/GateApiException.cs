/*
 * Gate API
 *
 * Welcome to Gate API  APIv4 provides operations related to spot, margin, and contract trading, including public interfaces for querying market data and authenticated private interfaces for implementing API-based automated trading.
 *
 * Contact: support@mail.gate.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Io.Gate.GateApi.Client
{
    /// <summary>
    /// Gate request exception
    /// </summary>
    [DataContract]
    public class GateApiException : ApiException
    {
        /// <summary>
        /// Gate API exception label
        /// </summary>
        [DataMember(Name = "label")]
        public string ErrorLabel { get; set; }

        /// <summary>
        /// Gate API exception message
        /// </summary>
        public string ErrorMessage
        {
            get { return string.IsNullOrWhiteSpace(this._errorDetail) ? this._errorMessage : this._errorDetail; }
        }

        /// <summary>
        /// Possible Gate API exception message detail
        /// </summary>
        [DataMember(Name = "message")]
        private string _errorMessage;

        /// <summary>
        /// Possible Gate API exception message detail
        /// </summary>
        [DataMember(Name = "detail")]
        private string _errorDetail;

        /// <summary>
        /// Construct Gate API exception with error response body
        /// </summary>
        [JsonConstructor]
        public GateApiException(string label, string message = default(string), string detail = default(string))
        {
            this.ErrorLabel = label;
            this._errorMessage = message;
            this._errorDetail = detail;
        }

        /// <summary>
        /// Set API exception message detail to general exception message
        /// </summary>
        public override string Message
        {
            get
            {
                return JsonConvert.SerializeObject(this, Formatting.None,
                    new JsonSerializerSettings{NullValueHandling = NullValueHandling.Ignore});
            }
        }
    }
}
