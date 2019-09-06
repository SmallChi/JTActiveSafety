using JT808.Protocol.Extensions.JTActiveSafety.MessageBody;
using JT808.Protocol.Extensions.JTActiveSafety.Metadata;
using JT808.Protocol.Formatters;
using JT808.Protocol.MessagePack;
using System;
using System.Collections.Generic;
using System.Text;

namespace JT808.Protocol.Extensions.JTActiveSafety.Formatters
{
    public class JT808_0x1210_Formatter : IJT808MessagePackFormatter<JT808_0x1210>
    {
        public JT808_0x1210 Deserialize(ref JT808MessagePackReader reader, IJT808Config config)
        {
            JT808_0x1210 jT808_0X1210 = new JT808_0x1210();
            jT808_0X1210.TerminalID = reader.ReadString(7);
            jT808_0X1210.AlarmIdentification = JT808_AlarmIdentificationProperty_Formatter.Instance.Deserialize(ref reader, config);
            jT808_0X1210.AlarmId = reader.ReadString(32);
            jT808_0X1210.InfoType = reader.ReadByte();
            jT808_0X1210.AttachCount = reader.ReadByte();
            if (jT808_0X1210.AttachCount > 0)
            {
                jT808_0X1210.AttachInfos = new List<AttachProperty>();
                for(int i=0;i< jT808_0X1210.AttachCount; i++)
                {
                    AttachProperty attachProperty = new AttachProperty();
                    attachProperty.FileNameLength= reader.ReadByte();
                    attachProperty.FileName= reader.ReadString(attachProperty.FileNameLength);
                    attachProperty.FileSize= reader.ReadUInt32();
                    jT808_0X1210.AttachInfos.Add(attachProperty);
                }
            }
            return jT808_0X1210;
        }

        public void Serialize(ref JT808MessagePackWriter writer, JT808_0x1210 value, IJT808Config config)
        {
            writer.WriteString(value.TerminalID.PadRight(7,'0'));
            JT808_AlarmIdentificationProperty_Formatter.Instance.Serialize(ref writer, value.AlarmIdentification, config);
            writer.WriteString(value.AlarmId);
            writer.WriteByte(value.InfoType);
            if(value.AttachInfos!=null && value.AttachInfos.Count > 0)
            {
                foreach(var item in value.AttachInfos)
                {
                    writer.Skip(1, out int FileNameLengthPosition);
                    writer.WriteString(item.FileName);
                    writer.WriteByteReturn((byte)(writer.GetCurrentPosition() - FileNameLengthPosition - 1), FileNameLengthPosition);
                    writer.WriteUInt32(item.FileSize);
                }
            }
            else
            {
                writer.WriteByte(0);
            }
        }
    }
}
