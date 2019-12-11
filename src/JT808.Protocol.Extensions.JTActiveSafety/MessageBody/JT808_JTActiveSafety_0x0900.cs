using JT808.Protocol.Formatters;
using JT808.Protocol.MessageBody;
using JT808.Protocol.MessagePack;
using System.Collections.Generic;

namespace JT808.Protocol.Extensions.JTActiveSafety.MessageBody
{
    /// <summary>
    /// 上传基本信息
    /// </summary>
    public class JT808_JTActiveSafety_0x0900 : JT808_0x0900_BodyBase, IJT808MessagePackFormatter<JT808_JTActiveSafety_0x0900>
    {
        /// <summary>
        /// 消息列表总数
        /// </summary>
        public byte USBMessageCount { get; set; }

        public List<JT808_JTActiveSafety_0x0900_USBMessage> USBMessages { get; set; }

        public JT808_JTActiveSafety_0x0900 Deserialize(ref JT808MessagePackReader reader, IJT808Config config)
        {
            JT808_JTActiveSafety_0x0900 jT808_JTActiveSafety_0X0900 = new JT808_JTActiveSafety_0x0900();
            jT808_JTActiveSafety_0X0900.USBMessageCount = reader.ReadByte();
            if (jT808_JTActiveSafety_0X0900.USBMessageCount > 0)
            {
                jT808_JTActiveSafety_0X0900.USBMessages = new List<JT808_JTActiveSafety_0x0900_USBMessage>();
                for (int i = 0; i < jT808_JTActiveSafety_0X0900.USBMessageCount; i++)
                {
                    JT808_JTActiveSafety_0x0900_USBMessage jT808_JTActiveSafety_0X0900_USBMessage = new JT808_JTActiveSafety_0x0900_USBMessage();
                    jT808_JTActiveSafety_0X0900_USBMessage.USBID = reader.ReadByte();
                    jT808_JTActiveSafety_0X0900_USBMessage.MessageLength = reader.ReadByte();
                    jT808_JTActiveSafety_0X0900_USBMessage.MessageContent = reader.ReadArray(jT808_JTActiveSafety_0X0900_USBMessage.MessageLength).ToArray();
                    jT808_JTActiveSafety_0X0900.USBMessages.Add(jT808_JTActiveSafety_0X0900_USBMessage);
                }
            }
            return jT808_JTActiveSafety_0X0900;
        }

        public void Serialize(ref JT808MessagePackWriter writer, JT808_JTActiveSafety_0x0900 value, IJT808Config config)
        {
            if (value.USBMessages != null && value.USBMessages.Count > 0)
            {
                writer.WriteByte((byte)value.USBMessages.Count);
                foreach (var item in value.USBMessages)
                {
                    writer.WriteByte(item.USBID);
                    if (item.MessageContent != null && item.MessageContent.Length > 0)
                    {
                        writer.WriteByte((byte)item.MessageContent.Length);
                        writer.WriteArray(item.MessageContent);
                    }
                    else if (item.MessageContentObejct != null)
                    {
                        writer.Skip(1, out int MessageContentLengthPosition);
                        object obj = config.GetMessagePackFormatterByType(item.MessageContentObejct.GetType());
                        JT808MessagePackFormatterResolverExtensions.JT808DynamicSerialize(obj, ref writer, item.MessageContentObejct, config);
                        writer.WriteByteReturn((byte)(writer.GetCurrentPosition() - MessageContentLengthPosition - 1), MessageContentLengthPosition);
                    }
                }
            }
        }
    }
}
