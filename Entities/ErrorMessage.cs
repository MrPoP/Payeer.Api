using Newtonsoft.Json;
using Payeer.Api.Json;

namespace Payeer.Api.Entities
{
    /// <summary>
    ///     Represents an error message
    /// </summary>
    public class ErrorMessage
    {
        /// <summary>
        ///     Available for GET requests
        /// </summary>
        [JsonIgnoreOnSerialize]
        [JsonProperty("error")]
        public string Message { get; set; }
    }
}
