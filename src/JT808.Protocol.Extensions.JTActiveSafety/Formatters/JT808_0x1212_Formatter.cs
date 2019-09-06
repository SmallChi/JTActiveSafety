using JT808.Protocol.Extensions.JTActiveSafety.MessageBody;
using JT808.Protocol.Extensions.JTActiveSafety.Metadata;
using JT808.Protocol.Formatters;
using JT808.Protocol.MessagePack;
using System;
using System.Collections.Generic;
using System.Text;

namespace JT808.Protocol.Extensions.JTActiveSafety.Formatters
{
    public class JT808_0x1212_Formatter : IJT808MessagePackFormatter<JT808_0x1212>
    {
        public JT808_0x1212 Deserialize(ref JT808MessagePackReader reader, IJT808Config config)
        {
            JT808_0x1212 jT808_0X1212 = new JT808_0x1212();
            jT808_0X1212.FileNameLength= reader.ReadByte();
            jT808_0X1212.FileName= reader.ReadString(jT808_0X1212.FileNameLength);
            jT808_0X1212.FileType = reader.ReadByte();
            jT808_0X1212.FileSize= reader.ReadUInt32();
            return jT808_0X1212;
        }

        public void Serialize(ref JT808MessagePackWriter writer, JT808_0x1212 value, IJT808Config config)
        {
            writer.Skip(1, out int FileNameLengthPosition);
            writer.WriteString(value.FileName);
            writer.WriteByteReturn((byte)(writer.GetCurrentPosition() - FileNameLengthPosition - 1), FileNameLengthPosition);
            writer.WriteByte(value.FileType);
            writer.WriteUInt32(value.FileSize);
        }
    }
}
