using JT808.Protocol.Formatters;
using JT808.Protocol.MessageBody;
using JT808.Protocol.MessagePack;

namespace JT808.Protocol.Extensions.JTActiveSafety.MessageBody
{
    /// <summary>
    /// 胎压监测系统参数
    /// </summary>
    public class JT808_0x8103_0xF366 : JT808_0x8103_BodyBase, IJT808MessagePackFormatter<JT808_0x8103_0xF366>
    {
        public override uint ParamId { get; set; } = 0xF366;
        public override byte ParamLength { get; set; } = 46;
        /// <summary>
        /// 轮胎规格型号 12位
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

        public JT808_0x8103_0xF366 Deserialize(ref JT808MessagePackReader reader, IJT808Config config)
        {
            JT808_0x8103_0xF366 jT808_0X8103_0XF366 = new JT808_0x8103_0xF366();
            jT808_0X8103_0XF366.ParamId = reader.ReadUInt32();
            jT808_0X8103_0XF366.ParamLength = reader.ReadByte();
            jT808_0X8103_0XF366.TyreSpecificationType = reader.ReadString(12);
            jT808_0X8103_0XF366.TyrePressureUnit = reader.ReadUInt16();
            jT808_0X8103_0XF366.NormalFetalPressure = reader.ReadUInt16();
            jT808_0X8103_0XF366.ThresholdUnbalancedTirePressure = reader.ReadUInt16();
            jT808_0X8103_0XF366.SlowLeakageThreshold = reader.ReadUInt16();
            jT808_0X8103_0XF366.LowVoltageThreshold = reader.ReadUInt16();
            jT808_0X8103_0XF366.HighVoltageThreshold = reader.ReadUInt16();
            jT808_0X8103_0XF366.HighTemperatureThreshold = reader.ReadUInt16();
            jT808_0X8103_0XF366.VoltageThreshold = reader.ReadUInt16();
            jT808_0X8103_0XF366.TimedReportingInterval = reader.ReadUInt16();
            jT808_0X8103_0XF366.Retain = reader.ReadArray(reader.ReadCurrentRemainContentLength()).ToArray();
            return jT808_0X8103_0XF366;
        }

        public void Serialize(ref JT808MessagePackWriter writer, JT808_0x8103_0xF366 value, IJT808Config config)
        {
            writer.WriteUInt32(value.ParamId);
            writer.Skip(1, out int ParamLengthPosition);
            writer.WriteString(value.TyreSpecificationType);
            writer.WriteUInt16(value.TyrePressureUnit);
            writer.WriteUInt16(value.NormalFetalPressure);
            writer.WriteUInt16(value.ThresholdUnbalancedTirePressure);
            writer.WriteUInt16(value.SlowLeakageThreshold);
            writer.WriteUInt16(value.LowVoltageThreshold);
            writer.WriteUInt16(value.HighVoltageThreshold);
            writer.WriteUInt16(value.HighTemperatureThreshold);
            writer.WriteUInt16(value.VoltageThreshold);
            writer.WriteUInt16(value.TimedReportingInterval);
            writer.WriteArray(value.Retain);
            writer.WriteByteReturn((byte)(writer.GetCurrentPosition() - ParamLengthPosition - 1), ParamLengthPosition);
        }
    }
}
