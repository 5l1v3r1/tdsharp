using System;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        /// <summary>
        /// Edits the time when a scheduled message will be sent. Scheduling state of all messages in the same album or forwarded together with the message will be also changed 
        /// </summary>
        public class EditMessageSchedulingState : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "editMessageSchedulingState";

            /// <summary>
            /// Extra data attached to the message
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// The chat the message belongs to 
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("chat_id")]
            public long ChatId { get; set; }

            /// <summary>
            /// Identifier of the message 
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("message_id")]
            public long MessageId { get; set; }

            /// <summary>
            /// The new message scheduling state. Pass null to send the message immediately
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("scheduling_state")]
            public MessageSchedulingState SchedulingState { get; set; }
        }


        /// <summary>
        /// Edits the time when a scheduled message will be sent. Scheduling state of all messages in the same album or forwarded together with the message will be also changed 
        /// </summary>
        public static Task<Ok> EditMessageSchedulingStateAsync(this Client client,
            long chatId = default(long),
            long messageId = default(long),
            MessageSchedulingState schedulingState = default(MessageSchedulingState))
        {
            return client.ExecuteAsync(new EditMessageSchedulingState
            {
                ChatId = chatId,
                MessageId = messageId,
                SchedulingState = schedulingState,
            });
        }
    }
}