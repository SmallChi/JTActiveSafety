using System;
using System.Collections.Generic;
using System.Text;

namespace JT808.Protocol.Extensions.JTActiveSafety.Enums
{
    /// <summary>
    /// 拍照分辨率
    /// </summary>
    public enum PhotoResolutionType:byte
    {
        x352_288=0x01,
        x704_288=0x02,
        x704_576=0x03,
        x640_480=0x04,
        x1280_720=0x05,
        x1920_1080=0x06,
        不修改参数=0xFF
    }
}
