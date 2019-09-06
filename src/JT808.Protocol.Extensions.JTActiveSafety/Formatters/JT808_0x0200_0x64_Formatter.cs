using JT808.Protocol.Extensions.JTActiveSafety.MessageBody;
using JT808.Protocol.Extensions.JTActiveSafety.Metadata;
using JT808.Protocol.Formatters;
using JT808.Protocol.MessagePack;
using System;
using System.Collections.Generic;
using System.Text;

namespace JT808.Protocol.Extensions.JTActiveSafety.Formatters
{
    public class JT808_0x0200_0x64_Formatter : IJT808MessagePackFormatter<JT808_0x0200_0x64>
    {
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
            jT808_0X0200_0X64.AlarmIdentification = JT808_AlarmIdentificationProperty_Formatter.Instance.Deserialize(ref reader, config);
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
            JT808_AlarmIdentificationProperty_Formatter.Instance.Serialize(ref writer, value.AlarmIdentification, config);
        }
    }
}
