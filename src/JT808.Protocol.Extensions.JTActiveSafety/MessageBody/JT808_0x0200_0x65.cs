using JT808.Protocol.Attributes;
using JT808.Protocol.Extensions.JTActiveSafety.Formatters;
using JT808.Protocol.Extensions.JTActiveSafety.Metadata;
using JT808.Protocol.MessageBody;
using System;
using System.Collections.Generic;
using System.Text;

namespace JT808.Protocol.Extensions.JTActiveSafety.MessageBody
{
    /// <summary>
    /// 驾驶员状态监测系统报警信息
    /// </summary>
    [JT808Formatter(typeof(JT808_0x0200_0x65_Formatter))]
    public class JT808_0x0200_0x65 : JT808_0x0200_BodyBase
    {
        public override byte AttachInfoId { get; set; } = 0x65;
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
        /// 疲劳程度
        /// </summary>
        public byte Fatigue { get; set; }
        /// <summary>
        /// 预留
        /// </summary>
        public byte[] Retain { get; set; } = new byte[4];
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
    }
}
