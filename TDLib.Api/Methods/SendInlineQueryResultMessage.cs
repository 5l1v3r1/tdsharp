using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public class SendInlineQueryResultMessage : Method<Message>
    {

        [JsonProperty("@type")]
        public override string DataType { get; set; } = "sendInlineQueryResultMessage";

        [JsonProperty("@extra")]
        public override string Extra { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("chat_id")]
        public long ChatId { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("reply_to_message_id")]
        public long ReplyToMessageId { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("disable_notification")]
        public bool DisableNotification { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("from_background")]
        public bool FromBackground { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("query_id")]
        public string QueryId { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("result_id")]
        public string ResultId { get; set; }

    }

}