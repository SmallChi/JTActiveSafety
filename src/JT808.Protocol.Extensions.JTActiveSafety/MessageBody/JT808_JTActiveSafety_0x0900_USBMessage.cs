using System;
using System.Collections.Generic;
using System.Text;

namespace JT808.Protocol.Extensions.JTActiveSafety.MessageBody
{
    /// <summary>
    /// 外设消息结构
    /// </summary>
    public class JT808_JTActiveSafety_0x0900_USBMessage
    {
        /// <summary>
        /// 外设ID
        /// </summary>
        public byte USBID { get; set; }
        /// <summary>
        /// 消息长度
        /// </summary>
        public byte MessageLength { get; set; }
        /// <summary>
        /// 消息内容
        /// </summary>
        public byte[] MessageContent { get; set; }
        /// <summary>
        /// 消息内容对象
        /// </summary>
        public JT808_JTActiveSafety_0x0900_USB_Base MessageContentObejct { get; set; }
    }
}
