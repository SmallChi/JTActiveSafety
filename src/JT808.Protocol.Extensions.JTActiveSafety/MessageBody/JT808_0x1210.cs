using JT808.Protocol.Attributes;
using JT808.Protocol.Extensions.JTActiveSafety.Formatters;
using JT808.Protocol.Extensions.JTActiveSafety.Metadata;
using System;
using System.Collections.Generic;
using System.Text;

namespace JT808.Protocol.Extensions.JTActiveSafety.MessageBody
{
    /// <summary>
    /// 报警附件信息消息
    /// </summary>
    [JT808Formatter(typeof(JT808_0x1210_Formatter))]
    public class JT808_0x1210:JT808Bodies
    {
        /// <summary>
        /// 终端ID
        /// 7 个字节，由大写字母和数字组成，此终端ID 由制造商自行定义，位数不足时，后补“0x00”
        /// </summary>
        public string TerminalID { get; set; }
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
        /// 信息类型
        /// 0x00：正常报警文件信息
        /// 0x01：补传报警文件信息
        /// </summary>
        public byte InfoType { get; set; }
        /// <summary>
        /// 附件数量
        /// </summary>
        public byte AttachCount { get; set; }
        /// <summary>
        /// 附件信息列表
        /// </summary>
        public List<AttachProperty> AttachInfos { get; set; }
    }
}
