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
        /// The payload from a general callback button 
        /// </summary>
        public partial class CallbackQueryPayload : Object
        {
            /// <summary>
            /// The payload from a general callback button 
            /// </summary>
            public class CallbackQueryPayloadData : CallbackQueryPayload
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "callbackQueryPayloadData";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Data that was attached to the callback button
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("data")]
                public byte[] Data { get; set; }
            }
        }
    }
}