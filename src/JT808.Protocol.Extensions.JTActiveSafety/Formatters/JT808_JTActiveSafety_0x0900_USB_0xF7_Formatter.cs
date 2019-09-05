using JT808.Protocol.Extensions.JTActiveSafety.MessageBody;
using JT808.Protocol.Formatters;
using JT808.Protocol.MessagePack;
using System;
using System.Collections.Generic;
using System.Text;

namespace JT808.Protocol.Extensions.JTActiveSafety.Formatters
{
    public class JT808_JTActiveSafety_0x0900_USB_0xF7_Formatter : IJT808MessagePackFormatter<JT808_JTActiveSafety_0x0900_USB_0xF7>
    {
        public readonly static JT808_JTActiveSafety_0x0900_USB_0xF7_Formatter Instance = new JT808_JTActiveSafety_0x0900_USB_0xF7_Formatter();
        public JT808_JTActiveSafety_0x0900_USB_0xF7 Deserialize(ref JT808MessagePackReader reader, IJT808Config config)
        {
            JT808_JTActiveSafety_0x0900_USB_0xF7 jT808_JTActiveSafety_0X0900_USB_0XF7 = new JT808_JTActiveSafety_0x0900_USB_0xF7();
            jT808_JTActiveSafety_0X0900_USB_0XF7.WorkingCondition = reader.ReadByte();
            jT808_JTActiveSafety_0X0900_USB_0XF7.AlarmStatus = reader.ReadUInt32();
            return jT808_JTActiveSafety_0X0900_USB_0XF7;
        }

        public void Serialize(ref JT808MessagePackWriter writer, JT808_JTActiveSafety_0x0900_USB_0xF7 value, IJT808Config config)
        {
            writer.WriteByte(value.WorkingCondition);
            writer.WriteUInt32(value.AlarmStatus);
        }
    }
}
