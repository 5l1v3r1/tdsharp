using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public class AddChatMembers : Function<Ok>
        {
            [JsonProperty("@type")] public override string DataType { get; set; } = "addChatMembers";

            [JsonProperty("@extra")] public override string Extra { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("chat_id")]
            public long ChatId { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("user_ids")]
            public int[] UserIds { get; set; }
        }
    }
}