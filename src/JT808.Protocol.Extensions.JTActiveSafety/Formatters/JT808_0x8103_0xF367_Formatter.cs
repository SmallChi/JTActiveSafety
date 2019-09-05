using JT808.Protocol.Extensions.JTActiveSafety.MessageBody;
using JT808.Protocol.Formatters;
using JT808.Protocol.MessagePack;
using System;
using System.Collections.Generic;
using System.Text;

namespace JT808.Protocol.Extensions.JTActiveSafety.Formatters
{
    public class JT808_0x8103_0xF367_Formatter : IJT808MessagePackFormatter<JT808_0x8103_0xF367>
    {
        public JT808_0x8103_0xF367 Deserialize(ref JT808MessagePackReader reader, IJT808Config config)
        {
            JT808_0x8103_0xF367 jT808_0X8103_0XF367 = new JT808_0x8103_0xF367();
            jT808_0X8103_0XF367.ParamId = reader.ReadUInt32();
            jT808_0X8103_0XF367.ParamLength = reader.ReadByte();
            jT808_0X8103_0XF367.RearApproachAlarmTimeThreshold = reader.ReadByte();
            jT808_0X8103_0XF367.LateralRearApproachAlarmTimeThreshold = reader.ReadByte();
            return jT808_0X8103_0XF367;
        }

        public void Serialize(ref JT808MessagePackWriter writer, JT808_0x8103_0xF367 value, IJT808Config config)
        {
            writer.WriteUInt32(value.ParamId);
            writer.WriteByte(2);
            writer.WriteByte(value.RearApproachAlarmTimeThreshold);
            writer.WriteByte(value.LateralRearApproachAlarmTimeThreshold);
        }
    }
}
