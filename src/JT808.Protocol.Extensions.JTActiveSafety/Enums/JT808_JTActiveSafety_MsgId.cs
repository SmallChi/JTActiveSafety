using System;
using System.Collections.Generic;
using System.Text;

namespace JT808.Protocol.Extensions.JTActiveSafety.Enums
{
    public enum JT808_JTActiveSafety_MsgId : ushort
    {
        报警附件信息消息= 0x1210,
        文件信息上传= 0x1211,
        文件上传完成消息 = 0x1212,
        报警附件上传指令 = 0x9208,
        文件上传完成消息应答 = 0x9212,
    }
}
