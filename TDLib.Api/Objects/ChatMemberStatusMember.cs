using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public partial class ChatMemberStatus : Object
        {
            public class ChatMemberStatusMember : ChatMemberStatus
            {
                [JsonProperty("@type")] public override string DataType { get; set; } = "chatMemberStatusMember";

                [JsonProperty("@extra")] public override string Extra { get; set; }
            }
        }
    }
}