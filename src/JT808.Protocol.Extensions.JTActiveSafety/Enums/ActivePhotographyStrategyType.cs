using System;
using System.Collections.Generic;
using System.Text;

namespace JT808.Protocol.Extensions.JTActiveSafety.Enums
{
    /// <summary>
    /// 主动拍照策略
    /// </summary>
    public enum ActivePhotographyStrategyType:byte
    {
        不开启=0x00,
        定时拍照=0x01,
        定距拍照=0x02,
        保留=0x03,
        不修改参数=0xFF
    }
}
