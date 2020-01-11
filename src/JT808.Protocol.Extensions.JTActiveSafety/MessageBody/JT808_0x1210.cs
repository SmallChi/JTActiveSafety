using JT808.Protocol.Extensions.JTActiveSafety.Metadata;
using JT808.Protocol.Formatters;
using JT808.Protocol.MessagePack;
using System;
using System.Collections.Generic;
using System.Text;

namespace JT808.Protocol.Extensions.JTActiveSafety.MessageBody
{
    /// <summary>
    /// 报警附件信息消息
    /// </summary>
    public class JT808_0x1210:JT808Bodies, IJT808MessagePackFormatter<JT808_0x1210>
    {
        /// <summary>
        /// 终端ID
        /// 7 个字节，由大写字母和数字组成，此终端ID 由制造商自行定义，位数不足时，后补“0x00”
        /// </summary>
        public string TerminalID { get; set; }
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
        /// 信息类型
        /// 0x00：正常报警文件信息
        /// 0x01：补传报警文件信息
        /// </summary>
        public byte InfoType { get; set; }
        /// <summary>
        /// 附件数量
        /// </summary>
        public byte AttachCount { get; set; }
        /// <summary>
        /// 附件信息列表
        /// </summary>
        public List<AttachProperty> AttachInfos { get; set; }

        public override ushort MsgId => 0x1210;

        public override string Description => "报警附件信息消息";

        public JT808_0x1210 Deserialize(ref JT808MessagePackReader reader, IJT808Config config)
        {
            JT808_0x1210 jT808_0X1210 = new JT808_0x1210();
            jT808_0X1210.TerminalID = reader.ReadString(7);
            jT808_0X1210.AlarmIdentification = new AlarmIdentificationProperty
            {
                TerminalID = reader.ReadString(7),
                Time = reader.ReadDateTime6(),
                SN = reader.ReadByte(),
                AttachCount = reader.ReadByte(),
                Retain = reader.ReadByte()
            };
            jT808_0X1210.AlarmId = reader.ReadString(32);
            jT808_0X1210.InfoType = reader.ReadByte();
            jT808_0X1210.AttachCount = reader.ReadByte();
            if (jT808_0X1210.AttachCount > 0)
            {
                jT808_0X1210.AttachInfos = new List<AttachProperty>();
                for (int i = 0; i < jT808_0X1210.AttachCount; i++)
                {
                    AttachProperty attachProperty = new AttachProperty();
                    attachProperty.FileNameLength = reader.ReadByte();
                    attachProperty.FileName = reader.ReadString(attachProperty.FileNameLength);
                    attachProperty.FileSize = reader.ReadUInt32();
                    jT808_0X1210.AttachInfos.Add(attachProperty);
                }
            }
            return jT808_0X1210;
        }

        public void Serialize(ref JT808MessagePackWriter writer, JT808_0x1210 value, IJT808Config config)
        {
            writer.WriteString(value.TerminalID.PadRight(7, '0'));
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
            writer.WriteByte(value.InfoType);
            if (value.AttachInfos != null && value.AttachInfos.Count > 0)
            {
                writer.WriteByte((byte)value.AttachInfos.Count);
                foreach (var item in value.AttachInfos)
                {
                    writer.Skip(1, out int FileNameLengthPosition);
                    writer.WriteString(item.FileName);
                    writer.WriteByteReturn((byte)(writer.GetCurrentPosition() - FileNameLengthPosition - 1), FileNameLengthPosition);
                    writer.WriteUInt32(item.FileSize);
                }
            }
            else
            {
                writer.WriteByte(0);
            }
        }
    }
}
