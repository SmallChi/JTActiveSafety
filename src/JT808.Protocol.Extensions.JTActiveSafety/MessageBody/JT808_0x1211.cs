using JT808.Protocol.Formatters;
using JT808.Protocol.Interfaces;
using JT808.Protocol.MessagePack;
using System.Text.Json;

namespace JT808.Protocol.Extensions.JTActiveSafety.MessageBody
{
    /// <summary>
    /// 文件信息上传
    /// </summary>
    public class JT808_0x1211 : JT808Bodies, IJT808MessagePackFormatter<JT808_0x1211>, IJT808Analyze
    {
        public override string Description => "文件信息上传";
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

        public override ushort MsgId => 0x1211;

        public void Analyze(ref JT808MessagePackReader reader, Utf8JsonWriter writer, IJT808Config config)
        {
            JT808_0x1211 value = new JT808_0x1211();
            value.FileNameLength = reader.ReadByte();
            writer.WriteNumber($"[{value.FileNameLength.ReadNumber()}]文件名称长度", value.FileNameLength);
            string fileNameHex = reader.ReadVirtualArray(value.FileNameLength).ToArray().ToHexString();
            value.FileName = reader.ReadString(value.FileNameLength);
            writer.WriteString($"[{fileNameHex}]文件名称", value.FileName);
            value.FileType = reader.ReadByte();
            writer.WriteNumber($"[{value.FileType.ReadNumber()}]文件类型", value.FileType);
            value.FileSize = reader.ReadUInt32();
            writer.WriteNumber($"[{value.FileSize.ReadNumber()}]文件大小", value.FileSize);
        }

        public JT808_0x1211 Deserialize(ref JT808MessagePackReader reader, IJT808Config config)
        {
            JT808_0x1211 value = new JT808_0x1211();
            value.FileNameLength = reader.ReadByte();
            value.FileName = reader.ReadString(value.FileNameLength);
            value.FileType = reader.ReadByte();
            value.FileSize = reader.ReadUInt32();
            return value;
        }

        public void Serialize(ref JT808MessagePackWriter writer, JT808_0x1211 value, IJT808Config config)
        {
            writer.Skip(1, out int FileNameLengthPosition);
            writer.WriteString(value.FileName);
            writer.WriteByteReturn((byte)(writer.GetCurrentPosition() - FileNameLengthPosition - 1), FileNameLengthPosition);
            writer.WriteByte(value.FileType);
            writer.WriteUInt32(value.FileSize);
        }
    }
}
