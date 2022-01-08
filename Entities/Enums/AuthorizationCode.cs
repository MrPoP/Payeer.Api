using Newtonsoft.Json;
using Payeer.Api.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Payeer.Api.Entities.Enums
{
    [JsonConverter(typeof(TolerantEnumConverter))]
    public enum AuthorizationCode
    {
        [EnumMember(Value = "0")]
        Successful,
        [EnumMember(Value = "1")]
        Failed
    }
}
