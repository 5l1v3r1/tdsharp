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
        /// The view count of the message has changed 
        /// </summary>
        public partial class Update : Object
        {
            /// <summary>
            /// The view count of the message has changed 
            /// </summary>
            public class UpdateMessageViews : Update
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "updateMessageViews";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Chat identifier 
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("chat_id")]
                public long ChatId { get; set; }

                /// <summary>
                /// Message identifier 
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("message_id")]
                public long MessageId { get; set; }

                /// <summary>
                /// New value of the view count
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("views")]
                public int Views { get; set; }
            }
        }
    }
}