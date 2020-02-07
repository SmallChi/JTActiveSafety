using JT808.Protocol.Formatters;
using JT808.Protocol.MessageBody;
using JT808.Protocol.MessagePack;

namespace JT808.Protocol.Extensions.JTActiveSafety.MessageBody
{
    /// <summary>
    /// 盲区监测系统参数
    /// </summary>
    public class JT808_0x8103_0xF367 : JT808_0x8103_BodyBase, IJT808MessagePackFormatter<JT808_0x8103_0xF367>
    {
        public override uint ParamId { get; set; } = JT808_JTActiveSafety_Constants.JT808_0X8103_0xF367;
        public override byte ParamLength { get; set; } = 2;
        /// <summary>
        /// 后方接近报警时间阈值
        /// </summary>
        public byte RearApproachAlarmTimeThreshold { get; set; }
        /// <summary>
        /// 侧后方接近报警时间阈值
        /// </summary>
        public byte LateralRearApproachAlarmTimeThreshold { get; set; }

        public JT808_0x8103_0xF367 Deserialize(ref JT808MessagePackReader reader, IJT808Config config)
        {
            JT808_0x8103_0xF367 jT808_0X8103_0XF367 = new JT808_0x8103_0xF367();
            jT808_0X8103_0XF367.ParamId = reader.ReadUInt32();
            jT808_0X8103_0XF367.ParamLength = reader.ReadByte();
            jT808_0X8103_0XF367.RearApproachAlarmTimeThreshold = reader.ReadByte();
            jT808_0X8103_0XF367.LateralRearApproachAlarmTimeThreshold = reader.ReadByte();
            return jT808_0X8103_0XF367;
        }

        public void Serialize(ref JT808MessagePackWriter writer, JT808_0x8103_0xF367 value, IJT808Config config)
        {
            writer.WriteUInt32(value.ParamId);
            writer.WriteByte(2);
            writer.WriteByte(value.RearApproachAlarmTimeThreshold);
            writer.WriteByte(value.LateralRearApproachAlarmTimeThreshold);
        }
    }
}
