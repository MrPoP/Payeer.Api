using Newtonsoft.Json;
using Payeer.Api.Entities.Base;
using Payeer.Api.Entities.Enums;

namespace Payeer.Api.Entities
{
    public sealed class Authorization : Entity
    {
        public Authorization()
        {
        }
        [JsonProperty("auth_error")]
        public AuthorizationCode AuthorizationResult { get; set; }
    }
}
