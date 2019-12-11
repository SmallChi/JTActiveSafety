using JT808.Protocol.Formatters;
using JT808.Protocol.MessagePack;

namespace JT808.Protocol.Extensions.JTActiveSafety.MessageBody
{
    /// <summary>
    ///  外设系统信息
    /// </summary>
    public class JT808_JTActiveSafety_0x0900_USB_0xF8 : JT808_JTActiveSafety_0x0900_USB_Base, IJT808MessagePackFormatter<JT808_JTActiveSafety_0x0900_USB_0xF8>
    {
        /// <summary>
        /// 公司名称长度
        /// </summary>
        public byte CompantNameLength { get; set; }
        /// <summary>
        /// 公司名称
        /// </summary>
        public string CompantName { get; set; }
        /// <summary>
        /// 产品型号长度
        /// </summary>
        public byte ProductModelLength { get; set; }
        /// <summary>
        /// 产品型号
        /// </summary>
        public string ProductModel { get; set; }
        /// <summary>
        /// 硬件版本号长度
        /// </summary>
        public byte HardwareVersionNumberLength { get; set; }
        /// <summary>
        /// 硬件版本号
        /// ASCII
        /// </summary>
        public string HardwareVersionNumber { get; set; }
        /// <summary>
        /// 软件版本号长度
        /// </summary>
        public byte SoftwareVersionNumberLength { get; set; }
        /// <summary>
        /// 软件版本号
        /// ASCII
        /// </summary>
        public string SoftwareVersionNumber { get; set; }
        /// <summary>
        /// 设备ID长度
        /// </summary>
        public byte DevicesIDLength { get; set; }
        /// <summary>
        /// 设备ID
        /// </summary>
        public string DevicesID { get; set; }
        /// <summary>
        /// 客户代码长度
        /// </summary>
        public byte CustomerCodeLength { get; set; }
        /// <summary>
        /// 客户代码
        /// </summary>
        public string CustomerCode { get; set; }

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
