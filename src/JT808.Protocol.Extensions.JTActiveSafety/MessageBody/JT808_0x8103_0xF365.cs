using JT808.Protocol.Formatters;
using JT808.Protocol.MessageBody;
using JT808.Protocol.MessagePack;

namespace JT808.Protocol.Extensions.JTActiveSafety.MessageBody
{
    /// <summary>
    /// 驾驶员状态监测系统参数
    /// </summary>
    public class JT808_0x8103_0xF365 : JT808_0x8103_BodyBase, IJT808MessagePackFormatter<JT808_0x8103_0xF365>
    {
        public override uint ParamId { get; set; } = JT808_JTActiveSafety_Constants.JT808_0X8103_0xF365;
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
