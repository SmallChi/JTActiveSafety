using JT808.Protocol.Attributes;
using JT808.Protocol.Extensions.JTActiveSafety.Formatters;
using JT808.Protocol.MessageBody;
using System;
using System.Collections.Generic;
using System.Text;

namespace JT808.Protocol.Extensions.JTActiveSafety.MessageBody
{
    /// <summary>
    /// 驾驶员状态监测系统参数
    /// </summary>
    [JT808Formatter(typeof(JT808_0x8103_0xF365_Formatter))]
    public class JT808_0x8103_0xF365 : JT808_0x8103_BodyBase
    {
        public override uint ParamId { get; set; } = 0xF365;
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
        /// 吸烟报警判断时间间隔
        /// </summary>
        public ushort TimeIntervalSmokingAlarmJudgment { get; set; }
        /// <summary>
        /// 接打电话报警判断时间间隔
        /// </summary>
        public ushort CallAlarmDetermineTimeInterval{ get; set; }
        /// <summary>
        /// 预留字段
        /// </summary>
        public byte[] Reserve { get; set; } = new byte[3];
        /// <summary>
        /// 疲劳驾驶报警分级速度阈值
        /// </summary>
        public byte GradedSpeedThresholdFatigueDrivingAlarm { get; set; }
        /// <summary>
        /// 疲劳驾驶报警前后视频录制时间
        /// </summary>
        public byte VideoRecordingTimeBeforeAndAfterFatigueDrivingAlarm { get; set; }
        /// <summary>
        /// 疲劳驾驶报警拍照张数
        /// </summary>
        public byte FatigueDrivingAlarmPhotograph { get; set; }
        /// <summary>
        /// 疲劳驾驶报警拍照间隔时间
        /// </summary>
        public byte FatigueDrivingAlarmPhotographInterval { get; set; }
        /// <summary>
        /// 接打电话报警分级速度阈值
        /// </summary>
        public byte ClassifiedSpeedThresholdCallAlarm{ get; set; }
        /// <summary>
        /// 接打电话报警前后视频录制时间
        /// </summary>
        public byte VideoRecordingTimeBeforeAndAfterCallAlarm{ get; set; }
        /// <summary>
        /// 接打电话报警拍驾驶员面部特征照片张数
        /// </summary>
        public byte CallAlarmTakePicturesDriverFacialFeatures{ get; set; }
        /// <summary>
        /// 接打电话报警拍驾驶员面部特征照片间隔时间
        /// </summary>
        public byte CallAlarmTakePicturesDriverFacialFeaturesInterval { get; set; }
        /// <summary>
        /// 抽烟报警分级车速阈值
        /// </summary>
        public byte ClassifiedSpeedThresholdSmokingAlarm{ get; set; }
        /// <summary>
        /// 抽烟报警前后视频录制时间
        /// </summary>
        public byte VideoRecordingTimeBeforeAndAfterSmokingAlarm{ get; set; }
        /// <summary>
        /// 抽烟报警拍驾驶员面部特征照片张数
        /// </summary>
        public byte SmokingAlarmPhotographsDriverFaceCharacteristics { get; set; }
        /// <summary>
        /// 抽烟报警拍驾驶员面部特征照片间隔时间
        /// </summary>
        public byte SmokingAlarmPhotographsDriverFaceCharacteristicsInterval { get; set; }
        /// <summary>
        /// 分神驾驶报警分级车速阈值
        /// </summary>
        public byte ClassifiedSpeedThresholdDistractedDrivingAlarm { get; set; }
        /// <summary>
        /// 分神驾驶报警拍照张数
        /// </summary>
        public byte DistractedDrivingAlarmPhotography{ get; set; }
        /// <summary>
        /// 分神驾驶报警拍照间隔时间
        /// </summary>
        public byte DistractedDrivingAlarmPhotographyInterval { get; set; }
        /// <summary>
        /// 驾驶行为异常视频录制时间
        /// </summary>
        public byte VideoRecordingTimeAbnormalDrivingBehavior{ get; set; }
        /// <summary>
        /// 驾驶行为异常抓拍照片张数
        /// </summary>
        public byte PhotographsAbnormalDrivingBehavior{ get; set; }
        /// <summary>
        /// 驾驶行为异常拍照间隔
        /// </summary>
        public byte PictureIntervalAbnormalDrivingBehavior{ get; set; }
        /// <summary>
        /// 驾驶员身份识别触发
        /// </summary>
        public byte DriverIdentificationTrigger { get; set; }
        /// <summary>
        /// 保留字段
        /// </summary>
        public byte[] Retain { get; set; } = new byte[2];
    }
}
