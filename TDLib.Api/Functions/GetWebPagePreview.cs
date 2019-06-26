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
        /// Returns a web page preview by the text of the message. Do not call this function too often. Returns a 404 error if the web page has no preview 
        /// </summary>
        public class GetWebPagePreview : Function<WebPage>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getWebPagePreview";

            /// <summary>
            /// Extra data attached to the message
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Message text with formatting
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("text")]
            public FormattedText Text { get; set; }
        }
    }
}