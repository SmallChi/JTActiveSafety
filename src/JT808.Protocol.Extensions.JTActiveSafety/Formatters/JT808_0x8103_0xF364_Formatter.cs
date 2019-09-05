using JT808.Protocol.Extensions.JTActiveSafety.MessageBody;
using JT808.Protocol.Formatters;
using JT808.Protocol.MessagePack;
using System;
using System.Collections.Generic;
using System.Text;

namespace JT808.Protocol.Extensions.JTActiveSafety.Formatters
{
    public class JT808_0x8103_0xF364_Formatter : IJT808MessagePackFormatter<JT808_0x8103_0xF364>
    {
        public JT808_0x8103_0xF364 Deserialize(ref JT808MessagePackReader reader, IJT808Config config)
        {
            JT808_0x8103_0xF364 jT808_0X8103_0XF364 = new JT808_0x8103_0xF364();
            jT808_0X8103_0XF364.ParamId = reader.ReadUInt32();
            jT808_0X8103_0XF364.ParamLength = reader.ReadByte();
            jT808_0X8103_0XF364.AlarmJudgeSpeedThreshold= reader.ReadByte();
            jT808_0X8103_0XF364.WarningVolume = reader.ReadByte();
            jT808_0X8103_0XF364.ActivePhotographyStrategy = reader.ReadByte();
            jT808_0X8103_0XF364.ActivelyTimePhotoInterval = reader.ReadUInt16();
            jT808_0X8103_0XF364.ActiveDistancePhotographyDistanceInterval = reader.ReadUInt16();
            jT808_0X8103_0XF364.SingleInitiativePhotos = reader.ReadByte();
            jT808_0X8103_0XF364.SingleInitiativePhotosInterval = reader.ReadByte();
            jT808_0X8103_0XF364.PhotoResolution = reader.ReadByte();
            jT808_0X8103_0XF364.VideoRecordingResolution = reader.ReadByte();
            jT808_0X8103_0XF364.AlarmEnable = reader.ReadUInt32();
            jT808_0X8103_0XF364.EventEnable = reader.ReadUInt32();
            jT808_0X8103_0XF364.Placeholder1 = reader.ReadByte();
            jT808_0X8103_0XF364.DistanceThresholdObstacleAlarm = reader.ReadByte();
            jT808_0X8103_0XF364.HierarchicalSpeedThresholdObstacleAlarm = reader.ReadByte();
            jT808_0X8103_0XF364.VideoRecordingTimeBeforeAndAfterObstacleAlarm = reader.ReadByte();
            jT808_0X8103_0XF364.BarrierAlarmPhotographs = reader.ReadByte();
            jT808_0X8103_0XF364.ObstacleAlarmInterval = reader.ReadByte();
            jT808_0X8103_0XF364.FrequentChannelChangeAlarmJudgmentTimePeriod = reader.ReadByte();
            jT808_0X8103_0XF364.FrequentAlarmJudgmentNumberChannelChange = reader.ReadByte();
            jT808_0X8103_0XF364.HierarchicalSpeedThresholdFrequentChannelChangeAlarm = reader.ReadByte();
            jT808_0X8103_0XF364.VideoRecordingTimeBeforeAndAfterFrequentLaneChangeAlarm = reader.ReadByte();
            jT808_0X8103_0XF364.FrequentChannelChangeAlarmPhotos = reader.ReadByte();
            jT808_0X8103_0XF364.FrequentLaneChangeAlarmInterval = reader.ReadByte();
            jT808_0X8103_0XF364.GradedSpeedThresholdLaneDeviationAlarm = reader.ReadByte();
            jT808_0X8103_0XF364.VideoRecordingTimeBeforeAndAfterLaneDepartureAlarm = reader.ReadByte();
            jT808_0X8103_0XF364.LaneDepartureAlarmPhoto = reader.ReadByte();
            jT808_0X8103_0XF364.LaneDepartureAlarmPhotoInterval = reader.ReadByte();
            jT808_0X8103_0XF364.ForwardCollisionWarningTimeThreshold = reader.ReadByte();
            jT808_0X8103_0XF364.HierarchicalSpeedThresholdForwardCollisionWarning = reader.ReadByte();
            jT808_0X8103_0XF364.VideoRecordingTimeBeforeAndAfterForwardCollisionAlarm = reader.ReadByte();
            jT808_0X8103_0XF364.ForwardCollisionAlarmPhotographs = reader.ReadByte();
            jT808_0X8103_0XF364.ForwardCollisionAlarmInterval = reader.ReadByte();
            jT808_0X8103_0XF364.PedestrianCollisionAlarmTimeThreshold = reader.ReadByte();
            jT808_0X8103_0XF364.PedestrianCollisionAlarmEnablingSpeedThreshold = reader.ReadByte();
            jT808_0X8103_0XF364.VideoRecordingTimeBeforeAndAfterPedestrianCollisionAlarm = reader.ReadByte();
            jT808_0X8103_0XF364.PedestrianCollisionAlarmPhotos = reader.ReadByte();
            jT808_0X8103_0XF364.PedestrianCollisionAlarmInterval = reader.ReadByte();
            jT808_0X8103_0XF364.VehicleDistanceMonitoringAlarmDistanceThreshold = reader.ReadByte();
            jT808_0X8103_0XF364.VehicleDistanceMonitoringAndAlarmClassificationSpeedThreshold = reader.ReadByte();
            jT808_0X8103_0XF364.VideoRecordingTimeBeforeAndAfterAlarmVehicleProximity = reader.ReadByte();
            jT808_0X8103_0XF364.AlarmPhotoVehicleCloseDistance = reader.ReadByte();
            jT808_0X8103_0XF364.AlarmPhotoVehicleCloseDistanceInterval = reader.ReadByte();
            jT808_0X8103_0XF364.RoadSignRecognitionPhotographs = reader.ReadByte();
            jT808_0X8103_0XF364.RoadSignRecognitionPhotographsInterval = reader.ReadByte();
            jT808_0X8103_0XF364.Placeholder2 = reader.ReadArray(4).ToArray();
            return jT808_0X8103_0XF364;
        }

        public void Serialize(ref JT808MessagePackWriter writer, JT808_0x8103_0xF364 value, IJT808Config config)
        {
            writer.WriteUInt32(value.ParamId);
            writer.Skip(1,out int ParamLengthPosition);
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
            writer.WriteByte(value.Placeholder1);
            writer.WriteByte(value.DistanceThresholdObstacleAlarm);
            writer.WriteByte(value.HierarchicalSpeedThresholdObstacleAlarm);
            writer.WriteByte(value.VideoRecordingTimeBeforeAndAfterObstacleAlarm);
            writer.WriteByte(value.BarrierAlarmPhotographs);
            writer.WriteByte(value.ObstacleAlarmInterval);
            writer.WriteByte(value.FrequentChannelChangeAlarmJudgmentTimePeriod);
            writer.WriteByte(value.FrequentAlarmJudgmentNumberChannelChange);
            writer.WriteByte(value.HierarchicalSpeedThresholdFrequentChannelChangeAlarm);
            writer.WriteByte(value.VideoRecordingTimeBeforeAndAfterFrequentLaneChangeAlarm);
            writer.WriteByte(value.FrequentChannelChangeAlarmPhotos);
            writer.WriteByte(value.FrequentLaneChangeAlarmInterval);
            writer.WriteByte(value.GradedSpeedThresholdLaneDeviationAlarm);
            writer.WriteByte(value.VideoRecordingTimeBeforeAndAfterLaneDepartureAlarm);
            writer.WriteByte(value.LaneDepartureAlarmPhoto);
            writer.WriteByte(value.LaneDepartureAlarmPhotoInterval);
            writer.WriteByte(value.ForwardCollisionWarningTimeThreshold);
            writer.WriteByte(value.HierarchicalSpeedThresholdForwardCollisionWarning);
            writer.WriteByte(value.VideoRecordingTimeBeforeAndAfterForwardCollisionAlarm);
            writer.WriteByte(value.ForwardCollisionAlarmPhotographs);
            writer.WriteByte(value.ForwardCollisionAlarmInterval);
            writer.WriteByte(value.PedestrianCollisionAlarmTimeThreshold);
            writer.WriteByte(value.PedestrianCollisionAlarmEnablingSpeedThreshold);
            writer.WriteByte(value.VideoRecordingTimeBeforeAndAfterPedestrianCollisionAlarm);
            writer.WriteByte(value.PedestrianCollisionAlarmPhotos);
            writer.WriteByte(value.PedestrianCollisionAlarmInterval);
            writer.WriteByte(value.VehicleDistanceMonitoringAlarmDistanceThreshold);
            writer.WriteByte(value.VehicleDistanceMonitoringAndAlarmClassificationSpeedThreshold);
            writer.WriteByte(value.VideoRecordingTimeBeforeAndAfterAlarmVehicleProximity);
            writer.WriteByte(value.AlarmPhotoVehicleCloseDistance);
            writer.WriteByte(value.AlarmPhotoVehicleCloseDistanceInterval);
            writer.WriteByte(value.RoadSignRecognitionPhotographs);
            writer.WriteByte(value.RoadSignRecognitionPhotographsInterval);
            writer.WriteArray(value.Placeholder2);
            writer.WriteByteReturn((byte)(writer.GetCurrentPosition() - ParamLengthPosition - 1), ParamLengthPosition);
        }
    }
}
