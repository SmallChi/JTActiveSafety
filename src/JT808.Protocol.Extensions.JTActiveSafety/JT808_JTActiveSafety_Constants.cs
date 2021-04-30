﻿using System;
using System.Collections.Generic;
using System.Text;

namespace JT808.Protocol.Extensions.JTActiveSafety
{
    /// <summary>
    /// 主动安全常量
    /// </summary>
    public static class JT808_JTActiveSafety_Constants
    {
        /// <summary>
        /// 附加信息ID 高级驾驶辅助系统报警信息
        /// </summary>
        public const byte JT808_0X0200_0x64 = 0x64;
        /// <summary>
        /// 附加信息ID 驾驶员状态监测系统报警信息
        /// </summary>
        public const byte JT808_0X0200_0x65 = 0x65;
        /// <summary>
        /// 附加信息ID 胎压监测系统报警信息
        /// </summary>
        public const byte JT808_0X0200_0x66 = 0x66;
        /// <summary>
        /// 附加信息ID 盲区监测系统报警信息
        /// </summary>
        public const byte JT808_0X0200_0x67 = 0x67;
        /// <summary>
        /// 高级驾驶辅助系统参数设置
        /// </summary>
        public const uint JT808_0X8103_0xF364 = 0xF364;
        /// <summary>
        /// 驾驶员状态监测系统参数设置
        /// </summary>
        public const uint JT808_0X8103_0xF365 = 0xF365;
        /// <summary>
        /// 胎压监测系统参数设置
        /// </summary>
        public const uint JT808_0X8103_0xF366 = 0xF366;
        /// <summary>
        /// 盲区监测系统参数设置
        /// </summary>
        public const uint JT808_0X8103_0xF367 = 0xF367;
        /// <summary>
        /// 状态查询
        /// </summary>
        public const byte JT808_0X0900_0xF7 = 0xF7;
        /// <summary>
        /// 信息查询
        /// </summary>
        public const byte JT808_0X0900_0xF8 = 0xF8;
    }
}
