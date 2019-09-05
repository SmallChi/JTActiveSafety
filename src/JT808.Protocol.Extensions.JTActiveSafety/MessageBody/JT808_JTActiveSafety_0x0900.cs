using JT808.Protocol.Attributes;
using JT808.Protocol.Extensions.JTActiveSafety.Formatters;
using JT808.Protocol.MessageBody;
using System;
using System.Collections.Generic;
using System.Text;

namespace JT808.Protocol.Extensions.JTActiveSafety.MessageBody
{
    /// <summary>
    /// 上传基本信息
    /// </summary>
    [JT808Formatter(typeof(JT808_JTActiveSafety_0x0900_Formatter))]
    public class JT808_JTActiveSafety_0x0900 : JT808_0x0900_BodyBase
    {
        /// <summary>
        /// 消息列表总数
        /// </summary>
        public byte USBMessageCount { get; set; }

        public List<JT808_JTActiveSafety_0x0900_USBMessage> USBMessages { get; set; }
    }
}
