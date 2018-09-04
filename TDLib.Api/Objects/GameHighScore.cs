using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public class GameHighScore : Object
        {
            [JsonProperty("@type")] public override string DataType { get; set; } = "gameHighScore";

            [JsonProperty("@extra")] public override string Extra { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("position")]
            public int Position { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("user_id")]
            public int UserId { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("score")]
            public int Score { get; set; }
        }
    }
}