using JT808.Protocol.Formatters;
using JT808.Protocol.MessagePack;

namespace JT808.Protocol.Extensions.JTActiveSafety.MessageBody
{
    /// <summary>
    ///  外设工作状态
    /// </summary>
    public class JT808_JTActiveSafety_0x0900_USB_0xF7 : JT808_JTActiveSafety_0x0900_USB_Base, IJT808MessagePackFormatter<JT808_JTActiveSafety_0x0900_USB_0xF7>
    {
        public static JT808_JTActiveSafety_0x0900_USB_0xF7 Instance = new JT808_JTActiveSafety_0x0900_USB_0xF7();
        /// <summary>
        /// 工作状态
        /// </summary>
        public byte WorkingCondition { get; set; }
        /// <summary>
        /// 报警状态
        /// </summary>
        public uint AlarmStatus { get; set; }

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
