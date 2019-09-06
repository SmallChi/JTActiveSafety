using System;
using System.Collections.Generic;
using System.Text;

namespace JTActiveSafety.Protocol
{
    public class JTActiveSafetyPackage
    {
        /// <summary>
        /// 帧头标识
        /// </summary>
        public static byte[] FH_Bytes = new byte[] { 0x30, 0x31, 0x63, 0x64 };
        /// <summary>
        /// 帧头标识
        /// </summary>
        public const uint FH = 0x30316364;
        /// <summary>
        /// 帧头标识
        /// 固定为0x30 0x31 0x63 0x64
        /// </summary>
        public uint FH_Flag { get; set; } = FH;
        /// <summary>
        /// 文件名称
        /// </summary>
        public string FileName { get; set; }
        /// <summary>
        /// 数据偏移量
        /// </summary>
        public uint Offset { get; set; }
        /// <summary>
        /// 数据长度
        /// </summary>
        public uint Length { get; set; }
        /// <summary>
        /// 数据体
        /// 默认长度64K，文件小于64K 则为实际长度
        /// </summary>
        public byte[] Bodies{ get; set; }
    }
}
