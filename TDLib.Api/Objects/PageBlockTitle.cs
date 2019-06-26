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
        /// The title of a page 
        /// </summary>
        public partial class PageBlock : Object
        {
            /// <summary>
            /// The title of a page 
            /// </summary>
            public class PageBlockTitle : PageBlock
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "pageBlockTitle";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Title
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("title")]
                public RichText Title { get; set; }
            }
        }
    }
}