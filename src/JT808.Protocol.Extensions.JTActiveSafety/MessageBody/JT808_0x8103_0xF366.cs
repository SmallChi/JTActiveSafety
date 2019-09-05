using JT808.Protocol.Attributes;
using JT808.Protocol.Extensions.JTActiveSafety.Formatters;
using JT808.Protocol.MessageBody;
using System;
using System.Collections.Generic;
using System.Text;

namespace JT808.Protocol.Extensions.JTActiveSafety.MessageBody
{
    /// <summary>
    /// 胎压监测系统参数
    /// </summary>
    [JT808Formatter(typeof(JT808_0x8103_0xF366_Formatter))]
    public class JT808_0x8103_0xF366 : JT808_0x8103_BodyBase
    {
        public override uint ParamId { get; set; } = 0xF366;
        public override byte ParamLength { get; set; } = 46;
        /// <summary>
        /// 轮胎规格型号
        /// </summary>
        public string TyreSpecificationType { get; set; }
        /// <summary>
        /// 胎压单位
        /// </summary>
        public ushort TyrePressureUnit { get; set; }
        /// <summary>
        /// 正常胎压值
        /// </summary>
        public ushort NormalFetalPressure { get; set; }
        /// <summary>
        /// 胎压不平衡门限
        /// </summary>
        public ushort ThresholdUnbalancedTirePressure { get; set; }
        /// <summary>
        /// 慢漏气门限
        /// </summary>
        public ushort SlowLeakageThreshold { get; set; }
        /// <summary>
        /// 低压阈值
        /// </summary>
        public ushort LowVoltageThreshold { get; set; }
        /// <summary>
        /// 高压阈值
        /// </summary>
        public ushort HighVoltageThreshold { get; set; }
        /// <summary>
        /// 高温阈值
        /// </summary>
        public ushort HighTemperatureThreshold { get; set; }
        /// <summary>
        /// 电压阈值
        /// </summary>
        public ushort VoltageThreshold { get; set; }
        /// <summary>
        /// 定时上报时间间隔
        /// </summary>
        public ushort TimedReportingInterval { get; set; }
        /// <summary>
        /// 保留项
        /// </summary>
        public byte[] Retain { get; set; } = new byte[6];
    }
}
