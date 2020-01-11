using JT808.Protocol.Formatters;
using JT808.Protocol.MessagePack;

namespace JT808.Protocol.Extensions.JTActiveSafety.MessageBody
{
    /// <summary>
    /// 文件上传完成消息
    /// </summary>
    public class JT808_0x1212 : JT808Bodies, IJT808MessagePackFormatter<JT808_0x1212>
    {
        public override string Description => "文件上传完成消息";
        /// <summary>
        /// 文件名称长度
        /// </summary>
        public byte FileNameLength { get; set; }
        /// <summary>
        /// 文件名称
        /// <文件类型>_<通道号>_<报警类型>_<序号>_<报警编号>.<后缀名>
        /// </summary>
        public string FileName { get; set; }
        /// <summary>
        /// 文件类型
        /// </summary>
        public byte FileType { get; set; }
        /// <summary>
        /// 文件大小
        /// </summary>
        public uint FileSize { get; set; }
        public override ushort MsgId => 0x1212;

        public JT808_0x1212 Deserialize(ref JT808MessagePackReader reader, IJT808Config config)
        {
            JT808_0x1212 jT808_0X1212 = new JT808_0x1212();
            jT808_0X1212.FileNameLength = reader.ReadByte();
            jT808_0X1212.FileName = reader.ReadString(jT808_0X1212.FileNameLength);
            jT808_0X1212.FileType = reader.ReadByte();
            jT808_0X1212.FileSize = reader.ReadUInt32();
            return jT808_0X1212;
        }

        public void Serialize(ref JT808MessagePackWriter writer, JT808_0x1212 value, IJT808Config config)
        {
            writer.Skip(1, out int FileNameLengthPosition);
            writer.WriteString(value.FileName);
            writer.WriteByteReturn((byte)(writer.GetCurrentPosition() - FileNameLengthPosition - 1), FileNameLengthPosition);
            writer.WriteByte(value.FileType);
            writer.WriteUInt32(value.FileSize);
        }
    }
}
