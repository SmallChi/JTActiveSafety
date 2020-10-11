using JTActiveSafety.Protocol.Buffers;
using JTActiveSafety.Protocol.Extensions;
using JTActiveSafety.Protocol.MessagePack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace JTActiveSafety.Protocol
{
    public static class JTActiveSafetySerializer
    {
        public static byte[] Serialize(JTActiveSafetyPackage package, int minBufferSize = 65 * 1024)
        {
            byte[] buffer = JTActiveSafetyArrayPool.Rent(minBufferSize);
            try
            {
                JTActiveSafetyMessagePackWriter writer = new JTActiveSafetyMessagePackWriter(buffer);
                writer.WriteUInt32(package.FH_Flag);
                writer.WriteString(package.FileName.PadLeft(50, '\0'));
                writer.WriteUInt32(package.Offset);
                writer.WriteUInt32((uint)package.Bodies.Length);
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

        public static byte[] AnalyzeJsonBuffer(ReadOnlySpan<byte> bytes, JsonWriterOptions options = default)
        {
            JTActiveSafetyMessagePackReader reader = new JTActiveSafetyMessagePackReader(bytes);
            using (MemoryStream memoryStream = new MemoryStream())
            using (Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream, options))
            {
                writer.WriteStartObject();
                var header = reader.ReadUInt32();
                writer.WriteNumber($"[{ header.ReadNumber()}]头部", header);
                var FileName = reader.ReadString(50);
                writer.WriteString($"[文件名称]", FileName);
                var offset = reader.ReadUInt32();
                writer.WriteNumber($"{offset.ReadNumber()}[数据偏移量]", offset);
                var length = reader.ReadUInt32();
                writer.WriteNumber($"{length.ReadNumber()}[数据长度]", length);
                var bodies = reader.ReadRemainArray().ToArray();
                writer.WriteString("[数据体]", string.Join(" ", (bodies).Select(p => p.ToString("X2"))));
                writer.WriteEndObject();
                writer.Flush();
                return memoryStream.ToArray();
            }
        }
        public static string Analyze(ReadOnlySpan<byte> bytes, JsonWriterOptions options = default)
        {
            string json = Encoding.UTF8.GetString(AnalyzeJsonBuffer(bytes, options));
            return json;
        }
    }
}
