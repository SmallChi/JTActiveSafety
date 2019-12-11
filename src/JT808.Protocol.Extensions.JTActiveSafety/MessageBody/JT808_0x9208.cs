using JT808.Protocol.Extensions.JTActiveSafety.Metadata;
using JT808.Protocol.Formatters;
using JT808.Protocol.MessagePack;
using System;

namespace JT808.Protocol.Extensions.JTActiveSafety.MessageBody
{
    /// <summary>
    /// 报警附件上传指令
    /// </summary>
    public class JT808_0x9208:JT808Bodies, IJT808MessagePackFormatter<JT808_0x9208>
    {
        public byte AttachmentServerIPLength { get; set; }
        public string AttachmentServerIP { get; set; }
        public ushort AttachmentServerIPTcpPort { get; set; }
        public ushort AttachmentServerIPUdpPort { get; set; }
        /// <summary>
        /// 报警标识号
        /// </summary>
        public AlarmIdentificationProperty AlarmIdentification { get; set; }
        /// <summary>
        /// 平台给报警分配的唯一编号
        /// 32
        /// </summary>
        public string AlarmId { get; set; }
        /// <summary>
        /// 预留
        /// </summary>
        public byte[] Retain { get; set; } = new byte[16];

        public override ushort MsgId => 0x9208;

        public JT808_0x9208 Deserialize(ref JT808MessagePackReader reader, IJT808Config config)
        {
            JT808_0x9208 jT808_0X9208 = new JT808_0x9208();
            jT808_0X9208.AttachmentServerIPLength = reader.ReadByte();
            jT808_0X9208.AttachmentServerIP = reader.ReadString(jT808_0X9208.AttachmentServerIPLength);
            jT808_0X9208.AttachmentServerIPTcpPort = reader.ReadUInt16();
            jT808_0X9208.AttachmentServerIPUdpPort = reader.ReadUInt16();
            jT808_0X9208.AlarmIdentification = new AlarmIdentificationProperty
            {
                TerminalID = reader.ReadString(7),
                Time = reader.ReadDateTime6(),
                SN = reader.ReadByte(),
                AttachCount = reader.ReadByte(),
                Retain = reader.ReadByte()
            };
            jT808_0X9208.AlarmId = reader.ReadString(32);
            jT808_0X9208.Retain = reader.ReadArray(16).ToArray();
            return jT808_0X9208;
        }

        public void Serialize(ref JT808MessagePackWriter writer, JT808_0x9208 value, IJT808Config config)
        {
            writer.Skip(1, out int AttachmentServerIPLengthPosition);
            writer.WriteString(value.AttachmentServerIP);
            writer.WriteByteReturn((byte)(writer.GetCurrentPosition() - AttachmentServerIPLengthPosition - 1), AttachmentServerIPLengthPosition);
            writer.WriteUInt16(value.AttachmentServerIPTcpPort);
            writer.WriteUInt16(value.AttachmentServerIPUdpPort);
            if (value.AlarmIdentification == null)
            {
                throw new NullReferenceException($"{nameof(AlarmIdentificationProperty)}不为空");
            }
            writer.WriteString(value.AlarmIdentification.TerminalID);
            writer.WriteDateTime6(value.AlarmIdentification.Time);
            writer.WriteByte(value.AlarmIdentification.SN);
            writer.WriteByte(value.AlarmIdentification.AttachCount);
            writer.WriteByte(value.AlarmIdentification.Retain);
            writer.WriteString(value.AlarmId);
            writer.WriteArray(value.Retain);
        }
    }
}
