using JT808.Protocol.Extensions.JTActiveSafety.MessageBody;
using JT808.Protocol.Extensions.JTActiveSafety.Metadata;
using JT808.Protocol.Formatters;
using JT808.Protocol.MessagePack;
using System;
using System.Collections.Generic;
using System.Text;

namespace JT808.Protocol.Extensions.JTActiveSafety.Formatters
{
    public class JT808_0x9208_Formatter : IJT808MessagePackFormatter<JT808_0x9208>
    {
        public JT808_0x9208 Deserialize(ref JT808MessagePackReader reader, IJT808Config config)
        {
            JT808_0x9208 jT808_0X9208 = new JT808_0x9208();
            jT808_0X9208.AttachmentServerIPLength = reader.ReadByte();
            jT808_0X9208.AttachmentServerIP = reader.ReadString(jT808_0X9208.AttachmentServerIPLength);
            jT808_0X9208.AttachmentServerIPTcpPort = reader.ReadUInt16();
            jT808_0X9208.AttachmentServerIPUdpPort = reader.ReadUInt16();
            jT808_0X9208.AlarmIdentification = JT808_AlarmIdentificationProperty_Formatter.Instance.Deserialize(ref reader, config);
            jT808_0X9208.AlarmId = reader.ReadString(32);
            jT808_0X9208.Retain = reader.ReadArray(16).ToArray();
            return jT808_0X9208;
        }

        public void Serialize(ref JT808MessagePackWriter writer, JT808_0x9208 value, IJT808Config config)
        {
            writer.Skip(1, out int AttachmentServerIPLengthPosition);
            writer.WriteString(value.AttachmentServerIP);
            writer.WriteByteReturn((byte)(writer.GetCurrentPosition()- AttachmentServerIPLengthPosition-1), AttachmentServerIPLengthPosition);
            writer.WriteUInt16(value.AttachmentServerIPTcpPort);
            writer.WriteUInt16(value.AttachmentServerIPUdpPort);
            JT808_AlarmIdentificationProperty_Formatter.Instance.Serialize(ref writer, value.AlarmIdentification, config);
            writer.WriteString(value.AlarmId);
            writer.WriteArray(value.Retain);
        }
    }
}
