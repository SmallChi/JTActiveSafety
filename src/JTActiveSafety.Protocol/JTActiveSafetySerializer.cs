using JTActiveSafety.Protocol.Buffers;
using JTActiveSafety.Protocol.MessagePack;
using System;
using System.Collections.Generic;
using System.Text;

namespace JTActiveSafety.Protocol
{
    public static class JTActiveSafetySerializer
    {
        public static byte[] Serialize(JTActiveSafetyPackage package, int minBufferSize = 4096)
        {
            byte[] buffer = JTActiveSafetyArrayPool.Rent(minBufferSize);
            try
            {
                JTActiveSafetyMessagePackWriter writer = new JTActiveSafetyMessagePackWriter(buffer);
                writer.WriteUInt32(package.FH_Flag);
                writer.WriteString(package.FileName);
                writer.WriteUInt32(package.Offset);
                writer.WriteUInt32(package.Length);
                writer.WriteArray(package.Bodies);
                return writer.FlushAndGetArray();
            }
            finally
            {
                JTActiveSafetyArrayPool.Return(buffer);
            }
        }

        public static JTActiveSafetyPackage Deserialize(ReadOnlySpan<byte> bytes)
        {
            JTActiveSafetyPackage jTActiveSafetyPackage= new JTActiveSafetyPackage();
            JTActiveSafetyMessagePackReader reader = new JTActiveSafetyMessagePackReader(bytes);
            jTActiveSafetyPackage.FH_Flag = reader.ReadUInt32();
            jTActiveSafetyPackage.FileName = reader.ReadString(50);
            jTActiveSafetyPackage.Offset= reader.ReadUInt32();
            jTActiveSafetyPackage.Length = reader.ReadUInt32();
            jTActiveSafetyPackage.Bodies = reader.ReadRemainArray().ToArray();
            return jTActiveSafetyPackage;
        }
    }
}
