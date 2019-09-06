using JT808.Protocol.Extensions.JTActiveSafety.MessageBody;
using JT808.Protocol.Extensions.JTActiveSafety.Metadata;
using JT808.Protocol.Formatters;
using JT808.Protocol.MessagePack;
using System;
using System.Collections.Generic;
using System.Text;

namespace JT808.Protocol.Extensions.JTActiveSafety.Formatters
{
    public class JT808_0x0200_0x66_Formatter : IJT808MessagePackFormatter<JT808_0x0200_0x66>
    {
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
            jT808_0X0200_0X66.AlarmIdentification = JT808_AlarmIdentificationProperty_Formatter.Instance.Deserialize(ref reader, config);
            jT808_0X0200_0X66.AlarmOrEventCount = reader.ReadByte();
            if (jT808_0X0200_0X66.AlarmOrEventCount > 0)
            {
                jT808_0X0200_0X66.AlarmOrEvents = new List<AlarmOrEventProperty>();
                for(int i=0;i< jT808_0X0200_0X66.AlarmOrEventCount; i++)
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
            JT808_AlarmIdentificationProperty_Formatter.Instance.Serialize(ref writer, value.AlarmIdentification, config);
            if (value.AlarmOrEvents.Count > 0)
            {
                writer.WriteByte((byte)value.AlarmOrEvents.Count);
                foreach(var item in value.AlarmOrEvents)
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
