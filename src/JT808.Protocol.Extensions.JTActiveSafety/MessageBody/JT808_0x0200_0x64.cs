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
    /// 高级驾驶辅助系统报警信息
    /// </summary>
    public class JT808_0x0200_0x64 : JT808_0x0200_BodyBase, IJT808MessagePackFormatter<JT808_0x0200_0x64>
    {
        public override byte AttachInfoId { get; set; } = JT808_JTActiveSafety_Constants.JT808_0X0200_0x64;
        public override byte AttachInfoLength { get; set; } = 32;
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
        /// 前车车速
        /// </summary>
        public byte VehicleSpeed { get; set; }
        /// <summary>
        /// 前车/行人距离
        /// </summary>
        public byte CarOrPedestrianDistanceAhead { get; set; }
        /// <summary>
        /// 偏离类型
        /// </summary>
        public byte DeviateType { get; set; }
        /// <summary>
        /// 道路标志识别类型
        /// </summary>
        public byte RoadSignIdentificationType { get; set; }
        /// <summary>
        /// 道路标志识别类型
        /// </summary>
        public byte RoadSignIdentificationData { get; set; }
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

        public JT808_0x0200_0x64 Deserialize(ref JT808MessagePackReader reader, IJT808Config config)
        {          
            JT808_0x0200_0x64 jT808_0X0200_0X64 = new JT808_0x0200_0x64();
            jT808_0X0200_0X64.AttachInfoId = reader.ReadByte();
            jT808_0X0200_0X64.AttachInfoLength = reader.ReadByte();
            jT808_0X0200_0X64.AlarmId = reader.ReadUInt32();
            jT808_0X0200_0X64.FlagState = reader.ReadByte();
            jT808_0X0200_0X64.AlarmOrEventType = reader.ReadByte();
            jT808_0X0200_0X64.AlarmLevel = reader.ReadByte();
            jT808_0X0200_0X64.VehicleSpeed = reader.ReadByte();
            jT808_0X0200_0X64.CarOrPedestrianDistanceAhead = reader.ReadByte();
            jT808_0X0200_0X64.DeviateType = reader.ReadByte();
            jT808_0X0200_0X64.RoadSignIdentificationType = reader.ReadByte();
            jT808_0X0200_0X64.RoadSignIdentificationData = reader.ReadByte();
            jT808_0X0200_0X64.Speed = reader.ReadByte();
            jT808_0X0200_0X64.Altitude = reader.ReadUInt16();
            jT808_0X0200_0X64.Latitude = (int)reader.ReadUInt32();
            jT808_0X0200_0X64.Longitude = (int)reader.ReadUInt32();
            jT808_0X0200_0X64.AlarmTime = reader.ReadDateTime6();
            jT808_0X0200_0X64.VehicleState = reader.ReadUInt16();
            jT808_0X0200_0X64.AlarmIdentification = new AlarmIdentificationProperty
            {
                TerminalID = reader.ReadString(7),
                Time = reader.ReadDateTime6(),
                SN = reader.ReadByte(),
                AttachCount = reader.ReadByte(),
                Retain = reader.ReadByte()
            };
            return jT808_0X0200_0X64;
        }

        public void Serialize(ref JT808MessagePackWriter writer, JT808_0x0200_0x64 value, IJT808Config config)
        {
            writer.WriteByte(value.AttachInfoId);
            writer.WriteByte(value.AttachInfoLength);
            writer.WriteUInt32(value.AlarmId);
            writer.WriteByte(value.FlagState);
            writer.WriteByte(value.AlarmOrEventType);
            writer.WriteByte(value.AlarmLevel);
            writer.WriteByte(value.VehicleSpeed);
            writer.WriteByte(value.CarOrPedestrianDistanceAhead);
            writer.WriteByte(value.DeviateType);
            writer.WriteByte(value.RoadSignIdentificationType);
            writer.WriteByte(value.RoadSignIdentificationData);
            writer.WriteByte(value.Speed);
            writer.WriteUInt16(value.Altitude);
            writer.WriteUInt32((uint)value.Latitude);
            writer.WriteUInt32((uint)value.Longitude);
            writer.WriteDateTime6(value.AlarmTime);
            writer.WriteUInt16(value.VehicleState);
            if (value.AlarmIdentification == null) {
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
