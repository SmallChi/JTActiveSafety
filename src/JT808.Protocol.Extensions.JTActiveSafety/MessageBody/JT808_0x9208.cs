using JT808.Protocol.Attributes;
using JT808.Protocol.Extensions.JTActiveSafety.Formatters;
using JT808.Protocol.Extensions.JTActiveSafety.Metadata;
using System;
using System.Collections.Generic;
using System.Text;

namespace JT808.Protocol.Extensions.JTActiveSafety.MessageBody
{
    /// <summary>
    /// 报警附件上传指令
    /// </summary>
    [JT808Formatter(typeof(JT808_0x9208_Formatter))]
    public class JT808_0x9208:JT808Bodies
    {
        public byte AttachmentServerIPLength { get; set; }
        public string AttachmentServerIP { get; set; }
        public ushort AttachmentServerIPTcpPort { get; set; }
        public ushort AttachmentServerIPUdpPort { get; set; }
        /// <summary>
        /// 报警标识号
        /// </summary>
        public AlarmIdentificationProperty AlarmIdentification { get; set; }
        /// <summary>
        /// 平台给报警分配的唯一编号
        /// 32
        /// </summary>
        public string AlarmId { get; set; }
        /// <summary>
        /// 预留
        /// </summary>
        public byte[] Retain { get; set; } = new byte[16];
    }
}
