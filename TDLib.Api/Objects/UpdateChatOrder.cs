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
        /// The order of the chat in the chat list has changed. Instead of this update updateChatLastMessage, updateChatIsPinned or updateChatDraftMessage might be sent 
        /// </summary>
        public partial class Update : Object
        {
            /// <summary>
            /// The order of the chat in the chat list has changed. Instead of this update updateChatLastMessage, updateChatIsPinned or updateChatDraftMessage might be sent 
            /// </summary>
            public class UpdateChatOrder : Update
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "updateChatOrder";

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
                /// New value of the order
                /// </summary>
                [JsonConverter(typeof(Converter.Int64))]
                [JsonProperty("order")]
                public Int64 Order { get; set; }
            }
        }
    }
}