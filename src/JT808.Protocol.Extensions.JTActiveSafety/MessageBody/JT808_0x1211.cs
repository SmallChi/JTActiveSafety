using JT808.Protocol.Attributes;
using JT808.Protocol.Extensions.JTActiveSafety.Formatters;
using System;
using System.Collections.Generic;
using System.Text;

namespace JT808.Protocol.Extensions.JTActiveSafety.MessageBody
{
    /// <summary>
    /// 文件信息上传
    /// </summary>
    [JT808Formatter(typeof(JT808_0x1211_Formatter))]
    public class JT808_0x1211 : JT808Bodies
    {
        /// <summary>
        /// 文件名称长度
        /// </summary>
        public byte FileNameLength { get; set; }
        /// <summary>
        /// 文件名称
        /// <文件类型>_<通道号>_<报警类型>_<序号>_<报警编号>.<后缀名>
        /// </summary>
        public string FileName { get; set; }
        /// <summary>
        /// 文件类型
        /// </summary>
        public byte FileType { get; set; }
        /// <summary>
        /// 文件大小
        /// </summary>
        public uint FileSize { get; set; }
    }
}
