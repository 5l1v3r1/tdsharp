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
        /// A photo message 
        /// </summary>
        public partial class PushMessageContent : Object
        {
            /// <summary>
            /// A photo message 
            /// </summary>
            public class PushMessageContentPhoto : PushMessageContent
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "pushMessageContentPhoto";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Message content; may be null 
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("photo")]
                public Photo Photo { get; set; }

                /// <summary>
                /// Photo caption 
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("caption")]
                public string Caption { get; set; }

                /// <summary>
                /// True, if the photo is secret 
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("is_secret")]
                public bool IsSecret { get; set; }

                /// <summary>
                /// True, if the message is a pinned message with the specified content
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("is_pinned")]
                public bool IsPinned { get; set; }
            }
        }
    }
}