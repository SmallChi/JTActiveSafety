using JT808.Protocol.Formatters;
using JT808.Protocol.MessageBody;
using JT808.Protocol.MessagePack;
using System.Collections.Generic;

namespace JT808.Protocol.Extensions.JTActiveSafety.MessageBody
{
    /// <summary>
    /// 查询基本信息
    /// </summary>
    public class JT808_0x8900_0xF8 : JT808_0x8900_BodyBase, IJT808MessagePackFormatter<JT808_0x8900_0xF8>
    {
        public override byte PassthroughType { get; set; } = JT808_JTActiveSafety_Constants.JT808_0X0900_0xF8;
        /// <summary>
        /// 外设ID列表总数
        /// </summary>
        public byte USBCount { get; set; }
        /// <summary>
        /// 外设ID
        /// </summary>
        public List<byte> MultipleUSB { get; set; }

        public JT808_0x8900_0xF8 Deserialize(ref JT808MessagePackReader reader, IJT808Config config)
        {
            JT808_0x8900_0xF8 value = new JT808_0x8900_0xF8();
            value.USBCount = reader.ReadByte();
            if (value.USBCount > 0)
            {
                value.MultipleUSB = new List<byte>();
                for (int i = 0; i < value.USBCount; i++)
                {
                    value.MultipleUSB.Add(reader.ReadByte());
                }
            }
            return value;
        }

        public void Serialize(ref JT808MessagePackWriter writer, JT808_0x8900_0xF8 value, IJT808Config config)
        {
            if (value.MultipleUSB != null && value.MultipleUSB.Count > 0)
            {
                writer.WriteByte((byte)value.MultipleUSB.Count);
                foreach (var item in value.MultipleUSB)
                {
                    writer.WriteByte(item);
                }
            }
        }
    }
}
