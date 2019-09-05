using JT808.Protocol.Attributes;
using JT808.Protocol.Extensions.JTActiveSafety.Formatters;
using JT808.Protocol.MessageBody;
using System;
using System.Collections.Generic;
using System.Text;

namespace JT808.Protocol.Extensions.JTActiveSafety.MessageBody
{
    /// <summary>
    /// 高级驾驶辅助系统参数
    /// </summary>
    [JT808Formatter(typeof(JT808_0x8103_0xF364_Formatter))]
    public class JT808_0x8103_0xF364 : JT808_0x8103_BodyBase
    {
        public override uint ParamId { get; set; } = 0xF364;
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
    }
}
