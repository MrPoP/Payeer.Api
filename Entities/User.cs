using Newtonsoft.Json;
using Payeer.Api.Entities.Base;
using Payeer.Api.Entities.Enums;
using Payeer.Api.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payeer.Api.Entities
{
    public sealed class User : Entity
    {
        public User()
        {
            Action = ActionType.Get_Balance;
        }
        [JsonProperty("currency")]
        public CurrencyType Currency { get; set; }
        [JsonProperty("total")]
        public double TotalBalance { get; set; }
        [JsonProperty("available")]
        public double AvaliableBalance { get; set; }
        [JsonProperty("hold")]
        public double HoldBalance { get; set; }
    }
}
