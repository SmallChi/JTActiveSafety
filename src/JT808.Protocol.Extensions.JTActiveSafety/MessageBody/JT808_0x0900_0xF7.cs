using JT808.Protocol.Extensions.JTActiveSafety.Metadata;
using JT808.Protocol.Formatters;
using JT808.Protocol.MessageBody;
using JT808.Protocol.MessagePack;
using System;
using System.Collections.Generic;
using System.Text;

namespace JT808.Protocol.Extensions.JTActiveSafety.MessageBody
{
    public class JT808_0x0900_0xF7 : JT808_0x0900_BodyBase, IJT808MessagePackFormatter<JT808_0x0900_0xF7>
    {
        public override byte PassthroughType { get; set; } = JT808_JTActiveSafety_Constants.JT808_0X0900_0xF7;
        /// <summary>
        /// 消息列表总数
        /// </summary>
        public byte USBMessageCount { get; set; }
        
        public List<JT808_0x0900_0xF7_USB> USBMessages { get; set; }

        public JT808_0x0900_0xF7 Deserialize(ref JT808MessagePackReader reader, IJT808Config config)
        {
            JT808_0x0900_0xF7 value = new JT808_0x0900_0xF7();
            value.USBMessageCount = reader.ReadByte();
            if (value.USBMessageCount > 0)
            {
                value.USBMessages = new List<JT808_0x0900_0xF7_USB>();
                for (int i = 0; i < value.USBMessageCount; i++)
                {
                    JT808_0x0900_0xF7_USB item = new JT808_0x0900_0xF7_USB();
                    item.USBID = reader.ReadByte();
                    item.MessageLength = reader.ReadByte();
                    item.WorkingCondition = reader.ReadByte();
                    item.AlarmStatus = reader.ReadUInt32();
                    value.USBMessages.Add(item);
                }
            }
            return value;
        }

        public void Serialize(ref JT808MessagePackWriter writer, JT808_0x0900_0xF7 value, IJT808Config config)
        {
            if (value.USBMessages != null && value.USBMessages.Count > 0)
            {
                writer.WriteByte((byte)value.USBMessages.Count);
                foreach (var item in value.USBMessages)
                {
                    writer.WriteByte(item.USBID);
                    writer.WriteByte(5);
                    writer.WriteByte(item.WorkingCondition);
                    writer.WriteUInt32(item.AlarmStatus);
                }
            }
        }
    }
}
