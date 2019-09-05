using JT808.Protocol.Attributes;
using JT808.Protocol.Extensions.JTActiveSafety.Formatters;
using System;
using System.Collections.Generic;
using System.Text;

namespace JT808.Protocol.Extensions.JTActiveSafety.MessageBody
{
    [JT808Formatter(typeof(JT808_JTActiveSafety_0x0900_USB_0xF8_Formatter))]
    public class JT808_JTActiveSafety_0x0900_USB_0xF8 : JT808_JTActiveSafety_0x0900_USB_Base
    {
        /// <summary>
        /// 公司名称长度
        /// </summary>
        public byte CompantNameLength { get; set; }
        /// <summary>
        /// 公司名称
        /// </summary>
        public string CompantName { get; set; }
        /// <summary>
        /// 产品型号长度
        /// </summary>
        public byte ProductModelLength { get; set; }
        /// <summary>
        /// 产品型号
        /// </summary>
        public string ProductModel { get; set; }
        /// <summary>
        /// 硬件版本号长度
        /// </summary>
        public byte HardwareVersionNumberLength { get; set; }
        /// <summary>
        /// 硬件版本号
        /// ASCII
        /// </summary>
        public string HardwareVersionNumber { get; set; }
        /// <summary>
        /// 软件版本号长度
        /// </summary>
        public byte SoftwareVersionNumberLength { get; set; }
        /// <summary>
        /// 软件版本号
        /// ASCII
        /// </summary>
        public string SoftwareVersionNumber { get; set; }
        /// <summary>
        /// 设备ID长度
        /// </summary>
        public byte DevicesIDLength { get; set; }
        /// <summary>
        /// 设备ID
        /// </summary>
        public string DevicesID { get; set; }
        /// <summary>
        /// 客户代码长度
        /// </summary>
        public byte CustomerCodeLength { get; set; }
        /// <summary>
        /// 客户代码
        /// </summary>
        public string CustomerCode { get; set; }
    }
}
