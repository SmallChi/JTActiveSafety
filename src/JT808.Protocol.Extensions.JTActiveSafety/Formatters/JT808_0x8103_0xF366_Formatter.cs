using JT808.Protocol.Extensions.JTActiveSafety.MessageBody;
using JT808.Protocol.Formatters;
using JT808.Protocol.MessagePack;
using System;
using System.Collections.Generic;
using System.Text;

namespace JT808.Protocol.Extensions.JTActiveSafety.Formatters
{
    public class JT808_0x8103_0xF366_Formatter : IJT808MessagePackFormatter<JT808_0x8103_0xF366>
    {
        public JT808_0x8103_0xF366 Deserialize(ref JT808MessagePackReader reader, IJT808Config config)
        {
            JT808_0x8103_0xF366 jT808_0X8103_0XF366 = new JT808_0x8103_0xF366();
            jT808_0X8103_0XF366.ParamId = reader.ReadUInt32();
            jT808_0X8103_0XF366.ParamLength = reader.ReadByte();
            jT808_0X8103_0XF366.TyreSpecificationType= reader.ReadString(12);
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
