using Payeer.Api.Json;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Payeer.Api.Entities.Enums
{
    [JsonConverter(typeof(TolerantEnumConverter))]
    internal enum ActionType
    {
        [EnumMember(Value = "getBalance")]
        Get_Balance,
        [EnumMember(Value = "transfer")]
        Transfer,
        [EnumMember(Value = "checkUser")]
        Check_User,
        [EnumMember(Value = "getExchangeRate")]
        Exchange_Rate,
        [EnumMember(Value = "payoutChecking")]
        Can_Payout,
        [EnumMember(Value = "payout")]
        Payout,
        [EnumMember(Value = "getPaySystems")]
        Payment_Systems,
        [EnumMember(Value = "paymentDetails")]
        Payment_Details,
        [EnumMember(Value = "history")]
        History,
        [EnumMember(Value = "payoutDetails")]
        Payout_Details,
        [EnumMember(Value = "invoiceCreate")]
        Invoice_Create,
        [EnumMember(Value = "merchant")]
        Merchant,
    }
}
