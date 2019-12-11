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
    /// 胎压监测系统报警信息
    /// </summary>
    public class JT808_0x0200_0x66 : JT808_0x0200_BodyBase, IJT808MessagePackFormatter<JT808_0x0200_0x66>
    {
        public override byte AttachInfoId { get; set; } = 0x66;
        public override byte AttachInfoLength { get; set; }
        /// <summary>
        /// 报警ID
        /// </summary>
        public uint AlarmId { get; set; }
        /// <summary>
        /// 标志状态
        /// </summary>
        public byte FlagState { get; set; }
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
        /// <summary>
        /// 报警/事件列表总数
        /// </summary>
        public byte AlarmOrEventCount { get; set; }
        /// <summary>
        /// 报警/事件信息列表
        /// </summary>
        public List<AlarmOrEventProperty> AlarmOrEvents { get; set; }

        public JT808_0x0200_0x66 Deserialize(ref JT808MessagePackReader reader, IJT808Config config)
        {
            JT808_0x0200_0x66 jT808_0X0200_0X66 = new JT808_0x0200_0x66();
            jT808_0X0200_0X66.AttachInfoId = reader.ReadByte();
            jT808_0X0200_0X66.AttachInfoLength = reader.ReadByte();
            jT808_0X0200_0X66.AlarmId = reader.ReadUInt32();
            jT808_0X0200_0X66.FlagState = reader.ReadByte();
            jT808_0X0200_0X66.Speed = reader.ReadByte();
            jT808_0X0200_0X66.Altitude = reader.ReadUInt16();
            jT808_0X0200_0X66.Latitude = (int)reader.ReadUInt32();
            jT808_0X0200_0X66.Longitude = (int)reader.ReadUInt32();
            jT808_0X0200_0X66.AlarmTime = reader.ReadDateTime6();
            jT808_0X0200_0X66.VehicleState = reader.ReadUInt16();
            jT808_0X0200_0X66.AlarmIdentification = new AlarmIdentificationProperty
            {
                TerminalID = reader.ReadString(7),
                Time = reader.ReadDateTime6(),
                SN = reader.ReadByte(),
                AttachCount = reader.ReadByte(),
                Retain = reader.ReadByte()
            };
            jT808_0X0200_0X66.AlarmOrEventCount = reader.ReadByte();
            if (jT808_0X0200_0X66.AlarmOrEventCount > 0)
            {
                jT808_0X0200_0X66.AlarmOrEvents = new List<AlarmOrEventProperty>();
                for (int i = 0; i < jT808_0X0200_0X66.AlarmOrEventCount; i++)
                {
                    AlarmOrEventProperty alarmOrEventProperty = new AlarmOrEventProperty();
                    alarmOrEventProperty.TirePressureAlarmPosition = reader.ReadByte();
                    alarmOrEventProperty.AlarmOrEventType = reader.ReadUInt16();
                    alarmOrEventProperty.TirePressure = reader.ReadUInt16();
                    alarmOrEventProperty.TireTemperature = reader.ReadUInt16();
                    alarmOrEventProperty.BatteryLevel = reader.ReadUInt16();
                    jT808_0X0200_0X66.AlarmOrEvents.Add(alarmOrEventProperty);
                }
            }
            return jT808_0X0200_0X66;
        }

        public void Serialize(ref JT808MessagePackWriter writer, JT808_0x0200_0x66 value, IJT808Config config)
        {
            writer.WriteByte(value.AttachInfoId);
            writer.Skip(1, out int AttachInfoLengthPosition);
            writer.WriteUInt32(value.AlarmId);
            writer.WriteByte(value.FlagState);
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
            if (value.AlarmOrEvents.Count > 0)
            {
                writer.WriteByte((byte)value.AlarmOrEvents.Count);
                foreach (var item in value.AlarmOrEvents)
                {
                    writer.WriteByte(item.TirePressureAlarmPosition);
                    writer.WriteUInt16(item.AlarmOrEventType);
                    writer.WriteUInt16(item.TirePressure);
                    writer.WriteUInt16(item.TireTemperature);
                    writer.WriteUInt16(item.BatteryLevel);
                }
            }
            writer.WriteByteReturn((byte)(writer.GetCurrentPosition() - AttachInfoLengthPosition - 1), AttachInfoLengthPosition);
        }
    }
}
