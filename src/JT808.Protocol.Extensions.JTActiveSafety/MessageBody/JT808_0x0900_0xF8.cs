using JT808.Protocol.Extensions.JTActiveSafety.Metadata;
using JT808.Protocol.Formatters;
using JT808.Protocol.MessageBody;
using JT808.Protocol.MessagePack;
using System;
using System.Collections.Generic;
using System.Text;

namespace JT808.Protocol.Extensions.JTActiveSafety.MessageBody
{
    public class JT808_0x0900_0xF8 : JT808_0x0900_BodyBase, IJT808MessagePackFormatter<JT808_0x0900_0xF8>
    {
        public override byte PassthroughType { get; set; } = JT808_JTActiveSafety_Constants.JT808_0X0900_0xF8;
        /// <summary>
        /// 消息列表总数
        /// </summary>
        public byte USBMessageCount { get; set; }
        public List<JT808_0x0900_0xF8_USB> USBMessages { get; set; }
        public JT808_0x0900_0xF8 Deserialize(ref JT808MessagePackReader reader, IJT808Config config)
        {
            JT808_0x0900_0xF8 value = new JT808_0x0900_0xF8();
            value.USBMessageCount = reader.ReadByte();
            if (value.USBMessageCount > 0)
            {
                value.USBMessages = new List<JT808_0x0900_0xF8_USB>();
                for (int i = 0; i < value.USBMessageCount; i++)
                {
                    JT808_0x0900_0xF8_USB item = new JT808_0x0900_0xF8_USB();
                    item.USBID = reader.ReadByte();
                    item.MessageLength = reader.ReadByte();
                    item.CompantNameLength = reader.ReadByte();
                    item.CompantName = reader.ReadString(item.CompantNameLength);
                    item.ProductModelLength = reader.ReadByte();
                    item.ProductModel = reader.ReadString(item.ProductModelLength);
                    item.HardwareVersionNumberLength = reader.ReadByte();
                    item.HardwareVersionNumber = reader.ReadString(item.HardwareVersionNumberLength);
                    item.SoftwareVersionNumberLength = reader.ReadByte();
                    item.SoftwareVersionNumber = reader.ReadString(item.SoftwareVersionNumberLength);
                    item.DevicesIDLength = reader.ReadByte();
                    item.DevicesID = reader.ReadString(item.DevicesIDLength);
                    item.CustomerCodeLength = reader.ReadByte();
                    item.CustomerCode = reader.ReadString(item.CustomerCodeLength);
                    value.USBMessages.Add(item);
                }
            }
            return value;
        }

        public void Serialize(ref JT808MessagePackWriter writer, JT808_0x0900_0xF8 value, IJT808Config config)
        {
            if (value.USBMessages != null && value.USBMessages.Count > 0)
            {
                writer.WriteByte((byte)value.USBMessages.Count);
                foreach (var item in value.USBMessages)
                {
                    writer.WriteByte(item.USBID);
                    writer.Skip(1,out int messageLengthPosition);

                    writer.Skip(1, out int CompantNameLengthPosition);
                    writer.WriteString(item.CompantName);
                    writer.WriteByteReturn((byte)(writer.GetCurrentPosition() - CompantNameLengthPosition - 1), CompantNameLengthPosition);

                    writer.Skip(1, out int ProductModelLengthPosition);
                    writer.WriteString(item.ProductModel);
                    writer.WriteByteReturn((byte)(writer.GetCurrentPosition() - ProductModelLengthPosition - 1), ProductModelLengthPosition);

                    writer.Skip(1, out int HardwareVersionNumberLengthPosition);
                    writer.WriteString(item.HardwareVersionNumber);
                    writer.WriteByteReturn((byte)(writer.GetCurrentPosition() - HardwareVersionNumberLengthPosition - 1), HardwareVersionNumberLengthPosition);

                    writer.Skip(1, out int SoftwareVersionNumberLengthPosition);
                    writer.WriteString(item.SoftwareVersionNumber);
                    writer.WriteByteReturn((byte)(writer.GetCurrentPosition() - SoftwareVersionNumberLengthPosition - 1), SoftwareVersionNumberLengthPosition);

                    writer.Skip(1, out int DevicesIDLengthPosition);
                    writer.WriteString(item.DevicesID);
                    writer.WriteByteReturn((byte)(writer.GetCurrentPosition() - DevicesIDLengthPosition - 1), DevicesIDLengthPosition);

                    writer.Skip(1, out int CustomerCodeLengthPosition);
                    writer.WriteString(item.CustomerCode);
                    writer.WriteByteReturn((byte)(writer.GetCurrentPosition() - CustomerCodeLengthPosition - 1), CustomerCodeLengthPosition);

                    writer.WriteByteReturn((byte)(writer.GetCurrentPosition() - messageLengthPosition - 1), messageLengthPosition);
                }
            }
        }
    }
}
