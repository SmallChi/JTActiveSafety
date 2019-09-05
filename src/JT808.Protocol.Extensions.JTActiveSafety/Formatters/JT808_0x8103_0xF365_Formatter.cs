using JT808.Protocol.Extensions.JTActiveSafety.MessageBody;
using JT808.Protocol.Formatters;
using JT808.Protocol.MessagePack;
using System;
using System.Collections.Generic;
using System.Text;

namespace JT808.Protocol.Extensions.JTActiveSafety.Formatters
{
    public class JT808_0x8103_0xF365_Formatter : IJT808MessagePackFormatter<JT808_0x8103_0xF365>
    {
        public JT808_0x8103_0xF365 Deserialize(ref JT808MessagePackReader reader, IJT808Config config)
        {
            JT808_0x8103_0xF365 jT808_0X8103_0XF365 = new JT808_0x8103_0xF365();
            jT808_0X8103_0XF365.ParamId = reader.ReadUInt32();
            jT808_0X8103_0XF365.ParamLength = reader.ReadByte();
            jT808_0X8103_0XF365.AlarmJudgeSpeedThreshold = reader.ReadByte();
            jT808_0X8103_0XF365.WarningVolume = reader.ReadByte();
            jT808_0X8103_0XF365.ActivePhotographyStrategy = reader.ReadByte();
            jT808_0X8103_0XF365.ActivelyTimePhotoInterval = reader.ReadUInt16();
            jT808_0X8103_0XF365.ActiveDistancePhotographyDistanceInterval = reader.ReadUInt16();
            jT808_0X8103_0XF365.SingleInitiativePhotos = reader.ReadByte();
            jT808_0X8103_0XF365.SingleInitiativePhotosInterval = reader.ReadByte();
            jT808_0X8103_0XF365.PhotoResolution = reader.ReadByte();
            jT808_0X8103_0XF365.VideoRecordingResolution = reader.ReadByte();
            jT808_0X8103_0XF365.AlarmEnable = reader.ReadUInt32();
            jT808_0X8103_0XF365.EventEnable = reader.ReadUInt32();
            jT808_0X8103_0XF365.TimeIntervalSmokingAlarmJudgment = reader.ReadUInt16();
            jT808_0X8103_0XF365.CallAlarmDetermineTimeInterval = reader.ReadUInt16();
            jT808_0X8103_0XF365.Reserve = reader.ReadArray(3).ToArray();
            jT808_0X8103_0XF365.GradedSpeedThresholdFatigueDrivingAlarm = reader.ReadByte();
            jT808_0X8103_0XF365.VideoRecordingTimeBeforeAndAfterFatigueDrivingAlarm = reader.ReadByte();
            jT808_0X8103_0XF365.FatigueDrivingAlarmPhotograph = reader.ReadByte();
            jT808_0X8103_0XF365.FatigueDrivingAlarmPhotographInterval = reader.ReadByte();
            jT808_0X8103_0XF365.ClassifiedSpeedThresholdCallAlarm = reader.ReadByte();
            jT808_0X8103_0XF365.VideoRecordingTimeBeforeAndAfterCallAlarm = reader.ReadByte();
            jT808_0X8103_0XF365.CallAlarmTakePicturesDriverFacialFeatures = reader.ReadByte();
            jT808_0X8103_0XF365.CallAlarmTakePicturesDriverFacialFeaturesInterval = reader.ReadByte();
            jT808_0X8103_0XF365.ClassifiedSpeedThresholdSmokingAlarm = reader.ReadByte();
            jT808_0X8103_0XF365.VideoRecordingTimeBeforeAndAfterSmokingAlarm = reader.ReadByte();
            jT808_0X8103_0XF365.SmokingAlarmPhotographsDriverFaceCharacteristics = reader.ReadByte();
            jT808_0X8103_0XF365.SmokingAlarmPhotographsDriverFaceCharacteristicsInterval = reader.ReadByte();
            jT808_0X8103_0XF365.ClassifiedSpeedThresholdDistractedDrivingAlarm = reader.ReadByte();
            jT808_0X8103_0XF365.DistractedDrivingAlarmPhotography = reader.ReadByte();
            jT808_0X8103_0XF365.DistractedDrivingAlarmPhotographyInterval = reader.ReadByte();
            jT808_0X8103_0XF365.VideoRecordingTimeAbnormalDrivingBehavior = reader.ReadByte();
            jT808_0X8103_0XF365.PhotographsAbnormalDrivingBehavior = reader.ReadByte();
            jT808_0X8103_0XF365.PictureIntervalAbnormalDrivingBehavior = reader.ReadByte();
            jT808_0X8103_0XF365.DriverIdentificationTrigger = reader.ReadByte();
            jT808_0X8103_0XF365.Retain = reader.ReadArray(reader.ReadCurrentRemainContentLength()).ToArray();
            return jT808_0X8103_0XF365;
        }

        public void Serialize(ref JT808MessagePackWriter writer, JT808_0x8103_0xF365 value, IJT808Config config)
        {
            writer.WriteUInt32(value.ParamId);
            writer.Skip(1, out int ParamLengthPosition);
            writer.WriteByte(value.AlarmJudgeSpeedThreshold);
            writer.WriteByte(value.WarningVolume);
            writer.WriteByte(value.ActivePhotographyStrategy);
            writer.WriteUInt16(value.ActivelyTimePhotoInterval);
            writer.WriteUInt16(value.ActiveDistancePhotographyDistanceInterval);
            writer.WriteByte(value.SingleInitiativePhotos);
            writer.WriteByte(value.SingleInitiativePhotosInterval);
            writer.WriteByte(value.PhotoResolution);
            writer.WriteByte(value.VideoRecordingResolution);
            writer.WriteUInt32(value.AlarmEnable);
            writer.WriteUInt32(value.EventEnable);
            writer.WriteUInt16(value.TimeIntervalSmokingAlarmJudgment);
            writer.WriteUInt16(value.CallAlarmDetermineTimeInterval);
            writer.WriteArray(value.Reserve);
            writer.WriteByte(value.GradedSpeedThresholdFatigueDrivingAlarm);
            writer.WriteByte(value.VideoRecordingTimeBeforeAndAfterFatigueDrivingAlarm);
            writer.WriteByte(value.FatigueDrivingAlarmPhotograph);
            writer.WriteByte(value.FatigueDrivingAlarmPhotographInterval);
            writer.WriteByte(value.ClassifiedSpeedThresholdCallAlarm);
            writer.WriteByte(value.VideoRecordingTimeBeforeAndAfterCallAlarm);
            writer.WriteByte(value.CallAlarmTakePicturesDriverFacialFeatures);
            writer.WriteByte(value.CallAlarmTakePicturesDriverFacialFeaturesInterval);
            writer.WriteByte(value.ClassifiedSpeedThresholdSmokingAlarm);
            writer.WriteByte(value.VideoRecordingTimeBeforeAndAfterSmokingAlarm);
            writer.WriteByte(value.SmokingAlarmPhotographsDriverFaceCharacteristics);
            writer.WriteByte(value.SmokingAlarmPhotographsDriverFaceCharacteristicsInterval);
            writer.WriteByte(value.ClassifiedSpeedThresholdDistractedDrivingAlarm);
            writer.WriteByte(value.DistractedDrivingAlarmPhotography);
            writer.WriteByte(value.DistractedDrivingAlarmPhotographyInterval);
            writer.WriteByte(value.VideoRecordingTimeAbnormalDrivingBehavior);
            writer.WriteByte(value.PhotographsAbnormalDrivingBehavior);
            writer.WriteByte(value.PictureIntervalAbnormalDrivingBehavior);
            writer.WriteByte(value.DriverIdentificationTrigger);
            writer.WriteArray(value.Retain);
            writer.WriteByteReturn((byte)(writer.GetCurrentPosition() - ParamLengthPosition - 1), ParamLengthPosition);
        }
    }
}
