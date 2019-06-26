using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public partial class TdApi
    {
        /// <summary>
        /// Returns stickers from the installed sticker sets that correspond to a given emoji. If the emoji is not empty, favorite and recently used stickers may also be returned 
        /// </summary>
        public class GetStickers : Function<Stickers>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getStickers";

            /// <summary>
            /// Extra data attached to the message
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// String representation of emoji. If empty, returns all known installed stickers 
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("emoji")]
            public string Emoji { get; set; }

            /// <summary>
            /// Maximum number of stickers to be returned
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("limit")]
            public int Limit { get; set; }
        }
    }
}