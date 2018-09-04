using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public class SendCallRating : Function<Ok>
        {
            [JsonProperty("@type")] public override string DataType { get; set; } = "sendCallRating";

            [JsonProperty("@extra")] public override string Extra { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("call_id")]
            public int CallId { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("rating")]
            public int Rating { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("comment")]
            public string Comment { get; set; }
        }
    }
}