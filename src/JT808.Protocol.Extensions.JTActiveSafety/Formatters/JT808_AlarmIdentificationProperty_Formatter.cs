using JT808.Protocol.Extensions.JTActiveSafety.Metadata;
using JT808.Protocol.Formatters;
using JT808.Protocol.MessagePack;
using System;
using System.Collections.Generic;
using System.Text;

namespace JT808.Protocol.Extensions.JTActiveSafety.Formatters
{
    public class JT808_AlarmIdentificationProperty_Formatter : IJT808MessagePackFormatter<AlarmIdentificationProperty>
    {
        public readonly static JT808_AlarmIdentificationProperty_Formatter Instance = new JT808_AlarmIdentificationProperty_Formatter();
        public AlarmIdentificationProperty Deserialize(ref JT808MessagePackReader reader, IJT808Config config)
        {
            AlarmIdentificationProperty alarmIdentification = new AlarmIdentificationProperty();
            alarmIdentification.TerminalID = reader.ReadString(7);
            alarmIdentification.Time = reader.ReadDateTime6();
            alarmIdentification.SN = reader.ReadByte();
            alarmIdentification.AttachCount = reader.ReadByte();
            alarmIdentification.Retain = reader.ReadByte();
            return alarmIdentification;
        }

        public void Serialize(ref JT808MessagePackWriter writer, AlarmIdentificationProperty value, IJT808Config config)
        {
            if (value == null)
            {
                throw new NullReferenceException($"{nameof(AlarmIdentificationProperty)}不为空");
            }
            writer.WriteString(value.TerminalID);
            writer.WriteDateTime6(value.Time);
            writer.WriteByte(value.SN);
            writer.WriteByte(value.AttachCount);
            writer.WriteByte(value.Retain);
        }
    }
}
