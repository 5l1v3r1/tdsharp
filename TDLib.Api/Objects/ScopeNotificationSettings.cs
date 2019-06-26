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
        /// Contains information about notification settings for several chats
        /// </summary>
        public class ScopeNotificationSettings : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "scopeNotificationSettings";

            /// <summary>
            /// Extra data attached to the message
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Time left before notifications will be unmuted, in seconds
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("mute_for")]
            public int MuteFor { get; set; }

            /// <summary>
            /// The name of an audio file to be used for notification sounds; only applies to iOS applications
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("sound")]
            public string Sound { get; set; }

            /// <summary>
            /// True, if message content should be displayed in notifications
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("show_preview")]
            public bool ShowPreview { get; set; }

            /// <summary>
            /// True, if notifications for incoming pinned messages will be created as for an ordinary unread message
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("disable_pinned_message_notifications")]
            public bool DisablePinnedMessageNotifications { get; set; }

            /// <summary>
            /// True, if notifications for messages with mentions will be created as for an ordinary unread message
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("disable_mention_notifications")]
            public bool DisableMentionNotifications { get; set; }
        }
    }
}