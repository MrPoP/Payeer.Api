using Newtonsoft.Json;
using Payeer.Api.Entities.Enums;
using Payeer.Api.Json;

namespace Payeer.Api.Entities.Base
{
    public abstract class Entity
    {
        [JsonProperty("account")]
        public string Account { get; set; }
        [JsonProperty("apiId")]
        public string AppID { get; set; }
        [JsonProperty("apiPass")]
        public string AppPW { get; set; }
        [JsonProperty("action")]
        [JsonIgnoreOnSerialize]
        internal ActionType Action { get; set; }
    }
}
