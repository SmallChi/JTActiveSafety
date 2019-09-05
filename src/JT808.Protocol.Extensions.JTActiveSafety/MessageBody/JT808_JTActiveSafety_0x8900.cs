using JT808.Protocol.Attributes;
using JT808.Protocol.Extensions.JTActiveSafety.Formatters;
using JT808.Protocol.MessageBody;
using System;
using System.Collections.Generic;
using System.Text;

namespace JT808.Protocol.Extensions.JTActiveSafety.MessageBody
{
    /// <summary>
    /// 查询基本信息
    /// </summary>
    [JT808Formatter(typeof(JT808_JTActiveSafety_0x8900_Formatter))]
    public class JT808_JTActiveSafety_0x8900: JT808_0x8900_BodyBase
    {
        /// <summary>
        /// 外设ID列表总数
        /// </summary>
        public byte USBCount { get; set; }
        /// <summary>
        /// 外设ID
        /// </summary>
        public List<byte> MultipleUSB { get; set; }
    }
}
