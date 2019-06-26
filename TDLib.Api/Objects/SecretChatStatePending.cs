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
        /// The secret chat is not yet created; waiting for the other user to get online
        /// </summary>
        public partial class SecretChatState : Object
        {
            /// <summary>
            /// The secret chat is not yet created; waiting for the other user to get online
            /// </summary>
            public class SecretChatStatePending : SecretChatState
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "secretChatStatePending";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }
            }
        }
    }
}