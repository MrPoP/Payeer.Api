using Payeer.Api.Json;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Payeer.Api.Entities.Enums
{
    [JsonConverter(typeof(TolerantEnumConverter))]
    public enum CurrencyType
    {
        [EnumMember(Value = "USD")]
        USD,
        [EnumMember(Value = "RUB")]
        RUB,
        [EnumMember(Value = "EUR")]
        EUR,
        [EnumMember(Value = "BTC")]
        BTC,
        [EnumMember(Value = "ETH")]
        ETH,
        [EnumMember(Value = "BCH")]
        BCH,
        [EnumMember(Value = "LTC")]
        LTC,
        [EnumMember(Value = "DASH")]
        DASH,
        [EnumMember(Value = "USDT")]
        USDT,
        [EnumMember(Value = "XRP")]
        XRP,
        [EnumMember(Value = "DOGE")]
        DOGE,
        [EnumMember(Value = "TRX")]
        TRX
    }
}
