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
        /// A concatenation of rich texts 
        /// </summary>
        public partial class RichText : Object
        {
            /// <summary>
            /// A concatenation of rich texts 
            /// </summary>
            public class RichTexts : RichText
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "richTexts";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Texts
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("texts")]
                public RichText[] Texts { get; set; }
            }
        }
    }
}