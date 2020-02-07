using JT808.Protocol.Extensions.JTActiveSafety.Metadata;
using JT808.Protocol.Formatters;
using JT808.Protocol.MessageBody;
using JT808.Protocol.MessagePack;
using System;
using System.Collections.Generic;
using System.Text;

namespace JT808.Protocol.Extensions.JTActiveSafety.MessageBody
{
    /// <summary>
    /// 盲区监测系统报警信息
    /// </summary>
    public class JT808_0x0200_0x67 : JT808_0x0200_BodyBase, IJT808MessagePackFormatter<JT808_0x0200_0x67>
    {
        public override byte AttachInfoId { get; set; } = JT808_JTActiveSafety_Constants.JT808_0X0200_0x67;
        public override byte AttachInfoLength { get; set; } = 26;
        /// <summary>
        /// 报警ID
        /// </summary>
        public uint AlarmId { get; set; }
        /// <summary>
        /// 标志状态
        /// </summary>
        public byte FlagState { get; set; }
        /// <summary>
        /// 报警/事件类型
        /// </summary>
        public byte AlarmOrEventType{ get; set; }
        /// <summary>
        /// 报警/事件类型
        /// </summary>
        public byte AlarmLevel { get; set; }
        /// <summary>
        /// 车速
        /// </summary>
        public byte Speed { get; set; }
        /// <summary>
        /// 高程
        /// </summary>
        public ushort Altitude { get; set; }
        /// <summary>
        /// 纬度
        /// </summary>
        public int Latitude { get; set; }
        /// <summary>
        /// 经度
        /// </summary>
        public int Longitude { get; set; }
        /// <summary>
        /// 日期时间
        /// YYMMDDhhmmss
        /// BCD[6]
        /// </summary>
        public DateTime AlarmTime { get; set; }
        /// <summary>
        /// 车辆状态
        /// </summary>
        public ushort VehicleState { get; set; }
        /// <summary>
        /// 报警标识号
        /// </summary>
        public AlarmIdentificationProperty AlarmIdentification { get; set; }

        public JT808_0x0200_0x67 Deserialize(ref JT808MessagePackReader reader, IJT808Config config)
        {
            JT808_0x0200_0x67 jT808_0X0200_0X67 = new JT808_0x0200_0x67();
            jT808_0X0200_0X67.AttachInfoId = reader.ReadByte();
            jT808_0X0200_0X67.AttachInfoLength = reader.ReadByte();
            jT808_0X0200_0X67.AlarmId = reader.ReadUInt32();
            jT808_0X0200_0X67.FlagState = reader.ReadByte();
            jT808_0X0200_0X67.AlarmOrEventType = reader.ReadByte();
            jT808_0X0200_0X67.AlarmLevel = reader.ReadByte();
            jT808_0X0200_0X67.Speed = reader.ReadByte();
            jT808_0X0200_0X67.Altitude = reader.ReadUInt16();
            jT808_0X0200_0X67.Latitude = (int)reader.ReadUInt32();
            jT808_0X0200_0X67.Longitude = (int)reader.ReadUInt32();
            jT808_0X0200_0X67.AlarmTime = reader.ReadDateTime6();
            jT808_0X0200_0X67.VehicleState = reader.ReadUInt16();
            jT808_0X0200_0X67.AlarmIdentification = new AlarmIdentificationProperty
            {
                TerminalID = reader.ReadString(7),
                Time = reader.ReadDateTime6(),
                SN = reader.ReadByte(),
                AttachCount = reader.ReadByte(),
                Retain = reader.ReadByte()
            };
            return jT808_0X0200_0X67;
        }

        public void Serialize(ref JT808MessagePackWriter writer, JT808_0x0200_0x67 value, IJT808Config config)
        {
            writer.WriteByte(value.AttachInfoId);
            writer.WriteByte(value.AttachInfoLength);
            writer.WriteUInt32(value.AlarmId);
            writer.WriteByte(value.FlagState);
            writer.WriteByte(value.AlarmOrEventType);
            writer.WriteByte(value.AlarmLevel);
            writer.WriteByte(value.Speed);
            writer.WriteUInt16(value.Altitude);
            writer.WriteUInt32((uint)value.Latitude);
            writer.WriteUInt32((uint)value.Longitude);
            writer.WriteDateTime6(value.AlarmTime);
            writer.WriteUInt16(value.VehicleState);
            if (value.AlarmIdentification == null)
            {
                throw new NullReferenceException($"{nameof(AlarmIdentificationProperty)}不为空");
            }
            writer.WriteString(value.AlarmIdentification.TerminalID);
            writer.WriteDateTime6(value.AlarmIdentification.Time);
            writer.WriteByte(value.AlarmIdentification.SN);
            writer.WriteByte(value.AlarmIdentification.AttachCount);
            writer.WriteByte(value.AlarmIdentification.Retain);
        }
    }
}
