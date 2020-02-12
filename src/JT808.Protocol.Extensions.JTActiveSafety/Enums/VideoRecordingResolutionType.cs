using System;
using System.Collections.Generic;
using System.Text;

namespace JT808.Protocol.Extensions.JTActiveSafety.Enums
{
    /// <summary>
    /// 视频录制分辨率
    /// </summary>
    public enum VideoRecordingResolutionType:byte
    {
        CIF=0x01,
        HD1=0x02,
        D1=0x03,
        WD1=0x04,
        VGA=0x05,
        _720P=0x06,
        _1080P=0x07,
        不修改参数=0xFF
    }
}
