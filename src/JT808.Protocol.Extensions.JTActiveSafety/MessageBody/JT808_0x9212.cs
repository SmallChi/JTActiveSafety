using JT808.Protocol.Attributes;
using JT808.Protocol.Extensions.JTActiveSafety.Formatters;
using JT808.Protocol.Extensions.JTActiveSafety.Metadata;
using System;
using System.Collections.Generic;
using System.Text;

namespace JT808.Protocol.Extensions.JTActiveSafety.MessageBody
{
    /// <summary>
    /// 文件上传完成消息应答
    /// </summary>
    [JT808Formatter(typeof(JT808_0x9212_Formatter))]
    public class JT808_0x9212:JT808Bodies
    {
        /// <summary>
        /// 文件名称长度
        /// </summary>
        public byte FileNameLength { get; set; }
        /// <summary>
        /// 文件名称
        /// </summary>
        public string FileName { get; set; }
        /// <summary>
        /// 文件类型
        /// </summary>
        public byte FileType { get; set; }
        /// <summary>
        /// 上传结果
        /// </summary>
        public byte UploadResult { get; set; }
        /// <summary>
        /// 补传数据包数量
        /// 需要补传的数据包数量，无补传时该值为0
        /// </summary>
        public byte DataPackageCount { get; set; }
        /// <summary>
        /// 补传数据包列表
        /// </summary>
        public List<DataPackageProperty> DataPackages { get; set; }
    }
}
