using JT808.Protocol.Attributes;
using JT808.Protocol.Extensions.JTActiveSafety.Formatters;
using JT808.Protocol.MessageBody;
using System;
using System.Collections.Generic;
using System.Text;

namespace JT808.Protocol.Extensions.JTActiveSafety.MessageBody
{
    /// <summary>
    /// 盲区监测系统参数
    /// </summary>
    [JT808Formatter(typeof(JT808_0x8103_0xF367_Formatter))]
    public class JT808_0x8103_0xF367 : JT808_0x8103_BodyBase
    {
        public override uint ParamId { get; set; } = 0xF367;
        public override byte ParamLength { get; set; } = 2;
        /// <summary>
        /// 后方接近报警时间阈值
        /// </summary>
        public byte RearApproachAlarmTimeThreshold { get; set; }
        /// <summary>
        /// 侧后方接近报警时间阈值
        /// </summary>
        public byte LateralRearApproachAlarmTimeThreshold { get; set; }
    }
}
