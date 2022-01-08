using System.Collections.Generic;
using Newtonsoft.Json;
using Payeer.Api.Json;

namespace Payeer.Api.Entities
{
    /// <summary>
    ///     Represents a status response
    /// </summary>
    public sealed class StatusResponse
    {
        public StatusResponse()
        {
            Errors = new List<ErrorMessage>();
        }

        [JsonIgnoreOnSerialize]
        [JsonProperty("errors", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<ErrorMessage> Errors { get; set; }
#warning NEEDTOCHECK
        [JsonIgnoreOnSerialize]
        [JsonProperty("auth_error", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string AuthError { get; set; }
    }
}
