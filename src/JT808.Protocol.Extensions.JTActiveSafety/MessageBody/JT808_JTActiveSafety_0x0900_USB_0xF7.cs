using JT808.Protocol.Attributes;
using JT808.Protocol.Extensions.JTActiveSafety.Formatters;
using System;
using System.Collections.Generic;
using System.Text;

namespace JT808.Protocol.Extensions.JTActiveSafety.MessageBody
{
    [JT808Formatter(typeof(JT808_JTActiveSafety_0x0900_USB_0xF7_Formatter))]
    public class JT808_JTActiveSafety_0x0900_USB_0xF7 : JT808_JTActiveSafety_0x0900_USB_Base
    {
        /// <summary>
        /// 工作状态
        /// </summary>
        public byte WorkingCondition { get; set; }
        /// <summary>
        /// 报警状态
        /// </summary>
        public uint AlarmStatus { get; set; }
    }
}
