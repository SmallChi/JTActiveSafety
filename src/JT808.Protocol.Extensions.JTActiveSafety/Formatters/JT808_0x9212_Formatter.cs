using JT808.Protocol.Extensions.JTActiveSafety.MessageBody;
using JT808.Protocol.Extensions.JTActiveSafety.Metadata;
using JT808.Protocol.Formatters;
using JT808.Protocol.MessagePack;
using System;
using System.Collections.Generic;
using System.Text;

namespace JT808.Protocol.Extensions.JTActiveSafety.Formatters
{
    public class JT808_0x9212_Formatter : IJT808MessagePackFormatter<JT808_0x9212>
    {
        public JT808_0x9212 Deserialize(ref JT808MessagePackReader reader, IJT808Config config)
        {
            JT808_0x9212 jT808_0X9212 = new JT808_0x9212();
            jT808_0X9212.FileNameLength = reader.ReadByte();
            jT808_0X9212.FileName = reader.ReadString(jT808_0X9212.FileNameLength);
            jT808_0X9212.FileType = reader.ReadByte();
            jT808_0X9212.UploadResult = reader.ReadByte();
            jT808_0X9212.DataPackageCount= reader.ReadByte();
            if (jT808_0X9212.DataPackageCount > 0)
            {
                jT808_0X9212.DataPackages = new List<DataPackageProperty>();
                for(int i=0;i< jT808_0X9212.DataPackageCount; i++)
                {
                    DataPackageProperty dataPackageProperty = new DataPackageProperty();
                    dataPackageProperty.Offset = reader.ReadUInt32();
                    dataPackageProperty.Length = reader.ReadUInt32();
                    jT808_0X9212.DataPackages.Add(dataPackageProperty);
                }
            }
            return jT808_0X9212;
        }

        public void Serialize(ref JT808MessagePackWriter writer, JT808_0x9212 value, IJT808Config config)
        {
            writer.Skip(1, out int FileNameLengthPosition);
            writer.WriteString(value.FileName);
            writer.WriteByteReturn((byte)(writer.GetCurrentPosition() - FileNameLengthPosition - 1), FileNameLengthPosition);
            writer.WriteByte(value.FileType);
            writer.WriteByte(value.UploadResult);
            if(value.DataPackages!=null && value.DataPackages.Count > 0)
            {
                writer.WriteByte((byte)value.DataPackages.Count);
                foreach (var item in value.DataPackages)
                {
                    writer.WriteUInt32(item.Offset);
                    writer.WriteUInt32(item.Length);
                }
            }
            else
            {
                writer.WriteByte(0);
            }
        }
    }
}
