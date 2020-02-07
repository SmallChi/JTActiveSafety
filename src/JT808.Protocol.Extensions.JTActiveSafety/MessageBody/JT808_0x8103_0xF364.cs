using JT808.Protocol.Formatters;
using JT808.Protocol.MessageBody;
using JT808.Protocol.MessagePack;

namespace JT808.Protocol.Extensions.JTActiveSafety.MessageBody
{
    /// <summary>
    /// 高级驾驶辅助系统参数
    /// </summary>
    public class JT808_0x8103_0xF364 : JT808_0x8103_BodyBase, IJT808MessagePackFormatter<JT808_0x8103_0xF364>
    {
        public override uint ParamId { get; set; } = JT808_JTActiveSafety_Constants.JT808_0X8103_0xF364;
        public override byte ParamLength { get; set; }
        /// <summary>
        /// 报警判断速度阈值
        /// </summary>
        public byte AlarmJudgeSpeedThreshold { get; set; }
        /// <summary>
        /// 报警提示音量
        /// </summary>
        public byte WarningVolume { get; set; }
        /// <summary>
        /// 主动拍照策略
        /// </summary>
        public byte ActivePhotographyStrategy { get; set; }
        /// <summary>
        /// 主动定时拍照时间间隔
        /// </summary>
        public ushort ActivelyTimePhotoInterval { get; set; }
        /// <summary>
        /// 主动定距拍照距离间隔
        /// </summary>
        public ushort ActiveDistancePhotographyDistanceInterval { get; set; }
        /// <summary>
        /// 单次主动拍照张数
        /// </summary>
        public byte SingleInitiativePhotos { get; set; }
        /// <summary>
        /// 单次主动拍照时间间隔
        /// </summary>
        public byte SingleInitiativePhotosInterval { get; set; }
        /// <summary>
        /// 拍照分辨率
        /// </summary>
        public byte PhotoResolution { get; set; }
        /// <summary>
        /// 视频录制分辨率
        /// </summary>
        public byte VideoRecordingResolution { get; set; }
        /// <summary>
        /// 报警使能
        /// </summary>
        public uint AlarmEnable { get; set; }
        /// <summary>
        /// 事件使能
        /// </summary>
        public uint EventEnable { get; set; }
        /// <summary>
        /// 预留字段
        /// </summary>
        public byte Placeholder1 { get; set; }
        /// <summary>
        /// 障碍物报警距离阈值
        /// </summary>
        public byte DistanceThresholdObstacleAlarm { get; set; }
        /// <summary>
        /// 障碍物报警分级速度阈值
        /// </summary>
        public byte HierarchicalSpeedThresholdObstacleAlarm { get; set; }
        /// <summary>
        /// 障碍物报警前后视频录制时间
        /// </summary>
        public byte VideoRecordingTimeBeforeAndAfterObstacleAlarm { get; set; }
        /// <summary>
        /// 障碍物报警拍照张数
        /// </summary>
        public byte BarrierAlarmPhotographs { get; set; }
        /// <summary>
        /// 障碍物报警拍照间隔
        /// </summary>
        public byte ObstacleAlarmInterval { get; set; }
        /// <summary>
        /// 频繁变道报警判断时间段
        /// </summary>
        public byte FrequentChannelChangeAlarmJudgmentTimePeriod { get; set; }

        /// <summary>
        /// 频繁变道报警判断次数
        /// </summary>
        public byte FrequentAlarmJudgmentNumberChannelChange { get; set; }
        /// <summary>
        /// 频繁变道报警分级速度阈值
        /// </summary>
        public byte HierarchicalSpeedThresholdFrequentChannelChangeAlarm { get; set; }
        /// <summary>
        /// 频繁变道报警前后视频录制时间
        /// </summary>
        public byte VideoRecordingTimeBeforeAndAfterFrequentLaneChangeAlarm { get; set; }
        /// <summary>
        /// 频繁变道报警拍照张数
        /// </summary>
        public byte FrequentChannelChangeAlarmPhotos { get; set; }
        /// <summary>
        /// 频繁变道报警拍照间隔
        /// </summary>
        public byte FrequentLaneChangeAlarmInterval { get; set; }
        /// <summary>
        /// 车道偏离报警分级速度阈值
        /// </summary>
        public byte GradedSpeedThresholdLaneDeviationAlarm { get; set; }
        /// <summary>
        /// 车道偏离报警前后视频录制时间
        /// </summary>
        public byte VideoRecordingTimeBeforeAndAfterLaneDepartureAlarm { get; set; }
        /// <summary>
        /// 车道偏离报警拍照张数
        /// </summary>
        public byte LaneDepartureAlarmPhoto { get; set; }
        /// <summary>
        /// 车道偏离报警拍照间隔
        /// </summary>
        public byte LaneDepartureAlarmPhotoInterval { get; set; }
        /// <summary>
        /// 前向碰撞报警时间阈值
        /// </summary>
        public byte ForwardCollisionWarningTimeThreshold { get; set; }
        /// <summary>
        /// 前向碰撞报警分级速度阈值
        /// </summary>
        public byte HierarchicalSpeedThresholdForwardCollisionWarning { get; set; }
        /// <summary>
        /// 前向碰撞报警前后视频录制时间
        /// </summary>
        public byte VideoRecordingTimeBeforeAndAfterForwardCollisionAlarm { get; set; }
        /// <summary>
        /// 前向碰撞报警拍照张数
        /// </summary>
        public byte ForwardCollisionAlarmPhotographs { get; set; }
        /// <summary>
        /// 前向碰撞报警拍照间隔
        /// </summary>
        public byte ForwardCollisionAlarmInterval { get; set; }
        /// <summary>
        /// 行人碰撞报警时间阈值
        /// </summary>
        public byte PedestrianCollisionAlarmTimeThreshold { get; set; }
        /// <summary>
        /// 行人碰撞报警使能速度阈值
        /// </summary>
        public byte PedestrianCollisionAlarmEnablingSpeedThreshold { get; set; }
        /// <summary>
        /// 行人碰撞报警前后视频录制时间
        /// </summary>
        public byte VideoRecordingTimeBeforeAndAfterPedestrianCollisionAlarm { get; set; }
        /// <summary>
        /// 行人碰撞报警拍照张数
        /// </summary>
        public byte PedestrianCollisionAlarmPhotos { get; set; }
        /// <summary>
        /// 行人碰撞报警拍照间隔
        /// </summary>
        public byte PedestrianCollisionAlarmInterval { get; set; }
        /// <summary>
        /// 车距监控报警距离阈值
        /// </summary>
        public byte VehicleDistanceMonitoringAlarmDistanceThreshold { get; set; }
        /// <summary>
        /// 车距监控报警分级速度阈值
        /// </summary>
        public byte VehicleDistanceMonitoringAndAlarmClassificationSpeedThreshold { get; set; }
        /// <summary>
        /// 车距过近报警前后视频录制时间
        /// </summary>
        public byte VideoRecordingTimeBeforeAndAfterAlarmVehicleProximity { get; set; }
        /// <summary>
        /// 车距过近报警拍照张数
        /// </summary>
        public byte AlarmPhotoVehicleCloseDistance { get; set; }
        /// <summary>
        /// 车距过近报警拍照间隔
        /// </summary>
        public byte AlarmPhotoVehicleCloseDistanceInterval { get; set; }
        /// <summary>
        /// 道路标志识别拍照张数
        /// </summary>
        public byte RoadSignRecognitionPhotographs { get; set; }
        /// <summary>
        /// 道路标志识别拍照间隔
        /// </summary>
        public byte RoadSignRecognitionPhotographsInterval { get; set; }
        /// <summary>
        /// 保留字段
        /// </summary>
        public byte[] Placeholder2 { get; set; } = new byte[4];

        public JT808_0x8103_0xF364 Deserialize(ref JT808MessagePackReader reader, IJT808Config config)
        {
            JT808_0x8103_0xF364 jT808_0X8103_0XF364 = new JT808_0x8103_0xF364();
            jT808_0X8103_0XF364.ParamId = reader.ReadUInt32();
            jT808_0X8103_0XF364.ParamLength = reader.ReadByte();
            jT808_0X8103_0XF364.AlarmJudgeSpeedThreshold = reader.ReadByte();
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
