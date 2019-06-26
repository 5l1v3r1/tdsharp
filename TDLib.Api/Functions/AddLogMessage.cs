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
        /// Adds a message to TDLib internal log. This is an offline method. Can be called before authorization. Can be called synchronously
        /// </summary>
        public class AddLogMessage : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "addLogMessage";

            /// <summary>
            /// Extra data attached to the message
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Minimum verbosity level needed for the message to be logged, 0-1023 
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("verbosity_level")]
            public int VerbosityLevel { get; set; }

            /// <summary>
            /// Text of a message to log
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("text")]
            public string Text { get; set; }
        }
    }
}