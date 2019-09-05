using JT808.Protocol.Extensions.JTActiveSafety.MessageBody;
using JT808.Protocol.Formatters;
using JT808.Protocol.MessagePack;
using System;
using System.Collections.Generic;
using System.Text;

namespace JT808.Protocol.Extensions.JTActiveSafety.Formatters
{
    public class JT808_JTActiveSafety_0x0900_USB_0xF8_Formatter : IJT808MessagePackFormatter<JT808_JTActiveSafety_0x0900_USB_0xF8>
    {
        public readonly static JT808_JTActiveSafety_0x0900_USB_0xF8_Formatter Instance = new JT808_JTActiveSafety_0x0900_USB_0xF8_Formatter();
        public JT808_JTActiveSafety_0x0900_USB_0xF8 Deserialize(ref JT808MessagePackReader reader, IJT808Config config)
        {
            JT808_JTActiveSafety_0x0900_USB_0xF8 jT808_JTActiveSafety_0X0900_USB_0XF8 = new JT808_JTActiveSafety_0x0900_USB_0xF8();
            jT808_JTActiveSafety_0X0900_USB_0XF8.CompantNameLength = reader.ReadByte();
            jT808_JTActiveSafety_0X0900_USB_0XF8.CompantName = reader.ReadString(jT808_JTActiveSafety_0X0900_USB_0XF8.CompantNameLength);
            jT808_JTActiveSafety_0X0900_USB_0XF8.ProductModelLength = reader.ReadByte();
            jT808_JTActiveSafety_0X0900_USB_0XF8.ProductModel = reader.ReadString(jT808_JTActiveSafety_0X0900_USB_0XF8.ProductModelLength);
            jT808_JTActiveSafety_0X0900_USB_0XF8.HardwareVersionNumberLength = reader.ReadByte();
            jT808_JTActiveSafety_0X0900_USB_0XF8.HardwareVersionNumber = reader.ReadString(jT808_JTActiveSafety_0X0900_USB_0XF8.HardwareVersionNumberLength);
            jT808_JTActiveSafety_0X0900_USB_0XF8.SoftwareVersionNumberLength = reader.ReadByte();
            jT808_JTActiveSafety_0X0900_USB_0XF8.SoftwareVersionNumber = reader.ReadString(jT808_JTActiveSafety_0X0900_USB_0XF8.SoftwareVersionNumberLength);
            jT808_JTActiveSafety_0X0900_USB_0XF8.DevicesIDLength = reader.ReadByte();
            jT808_JTActiveSafety_0X0900_USB_0XF8.DevicesID = reader.ReadString(jT808_JTActiveSafety_0X0900_USB_0XF8.DevicesIDLength);
            jT808_JTActiveSafety_0X0900_USB_0XF8.CustomerCodeLength = reader.ReadByte();
            jT808_JTActiveSafety_0X0900_USB_0XF8.CustomerCode = reader.ReadString(jT808_JTActiveSafety_0X0900_USB_0XF8.CustomerCodeLength);
            return jT808_JTActiveSafety_0X0900_USB_0XF8;
        }

        public void Serialize(ref JT808MessagePackWriter writer, JT808_JTActiveSafety_0x0900_USB_0xF8 value, IJT808Config config)
        {
            writer.Skip(1, out int CompantNameLengthPosition);
            writer.WriteString(value.CompantName);
            writer.WriteByteReturn((byte)(writer.GetCurrentPosition() - CompantNameLengthPosition - 1), CompantNameLengthPosition);

            writer.Skip(1, out int ProductModelLengthPosition);
            writer.WriteString(value.ProductModel);
            writer.WriteByteReturn((byte)(writer.GetCurrentPosition() - ProductModelLengthPosition - 1), ProductModelLengthPosition);

            writer.Skip(1, out int HardwareVersionNumberLengthPosition);
            writer.WriteString(value.HardwareVersionNumber);
            writer.WriteByteReturn((byte)(writer.GetCurrentPosition() - HardwareVersionNumberLengthPosition - 1), HardwareVersionNumberLengthPosition);

            writer.Skip(1, out int SoftwareVersionNumberLengthPosition);
            writer.WriteString(value.SoftwareVersionNumber);
            writer.WriteByteReturn((byte)(writer.GetCurrentPosition() - SoftwareVersionNumberLengthPosition - 1), SoftwareVersionNumberLengthPosition);

            writer.Skip(1, out int DevicesIDLengthPosition);
            writer.WriteString(value.DevicesID);
            writer.WriteByteReturn((byte)(writer.GetCurrentPosition() - DevicesIDLengthPosition - 1), DevicesIDLengthPosition);

            writer.Skip(1, out int CustomerCodeLengthPosition);
            writer.WriteString(value.CustomerCode);
            writer.WriteByteReturn((byte)(writer.GetCurrentPosition() - CustomerCodeLengthPosition - 1), CustomerCodeLengthPosition);
        }
    }
}
