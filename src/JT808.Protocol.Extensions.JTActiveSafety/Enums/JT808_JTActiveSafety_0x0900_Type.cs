using System;
using System.Collections.Generic;
using System.Text;

namespace JT808.Protocol.Extensions.JTActiveSafety.Enums
{
    public enum JT808_JTActiveSafety_0x0900_Type : byte
    {
        /// <summary>
        /// 状态查询
        /// 外设状态信息：外设工作状态、设备报警信息
        /// </summary>
        QueryState = 0xF7,
        /// <summary>
        /// 信息查询
        /// 外设传感器的基本信息：公司信息、产品代码、版本号、外设ID、客户代码。
        /// </summary>
        QueryInfomation = 0xF8
    }
}
