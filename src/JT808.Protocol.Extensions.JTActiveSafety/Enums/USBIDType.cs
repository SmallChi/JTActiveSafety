using System;
using System.Collections.Generic;
using System.Text;

namespace JT808.Protocol.Extensions.JTActiveSafety.Enums
{
    public enum USBIDType:byte
    {
        ADAS=0x64,
        DSM=0x65,
        TPMS=0x66,
        BSD=0x67
    }
}
