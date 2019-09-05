using JT808.Protocol.Extensions.JTActiveSafety.Enums;
using JT808.Protocol.Extensions.JTActiveSafety.MessageBody;
using JT808.Protocol.Formatters;
using JT808.Protocol.MessagePack;
using System;
using System.Collections.Generic;
using System.Text;

namespace JT808.Protocol.Extensions.JTActiveSafety.Formatters
{
    public class JT808_JTActiveSafety_0x0900_Formatter : IJT808MessagePackFormatter<JT808_JTActiveSafety_0x0900>
    {
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
                    jT808_JTActiveSafety_0X0900_USBMessage.USBID= reader.ReadByte();
                    jT808_JTActiveSafety_0X0900_USBMessage.MessageLength = reader.ReadByte();
                    jT808_JTActiveSafety_0X0900_USBMessage.MessageContent = reader.ReadArray(jT808_JTActiveSafety_0X0900_USBMessage.MessageLength).ToArray();
                    jT808_JTActiveSafety_0X0900.USBMessages.Add(jT808_JTActiveSafety_0X0900_USBMessage);
                }
            }
            return jT808_JTActiveSafety_0X0900;
        }

        public void Serialize(ref JT808MessagePackWriter writer, JT808_JTActiveSafety_0x0900 value, IJT808Config config)
        {
            if(value.USBMessages!=null && value.USBMessages.Count>0)
            {
                writer.WriteByte((byte)value.USBMessages.Count);
                foreach(var item in value.USBMessages)
                {
                    writer.WriteByte(item.USBID);
                    if(item.MessageContent!=null&& item.MessageContent.Length > 0)
                    {
                        writer.WriteByte((byte)item.MessageContent.Length);
                        writer.WriteArray(item.MessageContent);
                    }
                    else if (item.MessageContentObejct != null)
                    {
                        writer.Skip(1,out int MessageContentLengthPosition);
                        object obj = config.GetMessagePackFormatterByType(item.MessageContentObejct.GetType());
                        JT808MessagePackFormatterResolverExtensions.JT808DynamicSerialize(obj, ref writer, item.MessageContentObejct, config);
                        writer.WriteByteReturn((byte)(writer.GetCurrentPosition() - MessageContentLengthPosition - 1), MessageContentLengthPosition);
                    }
                }
            }
        }
    }
}
