using System;
using System.Collections.Generic;
using System.Text;

namespace JT808.Protocol.Extensions.JTActiveSafety.Enums
{
    /// <summary>
    /// 工作状态
    /// </summary>
    public enum WorkingConditionType:byte
    {
        正常工作=0x01,
        待机状态=0x02,
        升级维护=0x03,
        设备异常 = 0x04,
        断开连接 = 0x10,
    }
}
