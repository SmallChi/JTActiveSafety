﻿using JT808.Protocol.Formatters;
using JT808.Protocol.Interfaces;
using JT808.Protocol.MessageBody;
using JT808.Protocol.MessagePack;
using System.Collections.Generic;
using System.Text.Json;

namespace JT808.Protocol.Extensions.JTActiveSafety.MessageBody
{
    /// <summary>
    /// 查询基本信息
    /// </summary>
    public class JT808_0x8900_0xF7 : JT808_0x8900_BodyBase, IJT808MessagePackFormatter<JT808_0x8900_0xF7>, IJT808Analyze
    {
        /// <summary>
        /// 查询基本信息类型
        /// </summary>
        public override byte PassthroughType { get; set; } = JT808_JTActiveSafety_Constants.JT808_0X0900_0xF7;
        /// <summary>
        /// 外设ID列表总数
        /// </summary>
        public byte USBCount { get; set; }
        /// <summary>
        /// 外设ID
        /// </summary>
        public List<byte> MultipleUSB { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="writer"></param>
        /// <param name="config"></param>
        public void Analyze(ref JT808MessagePackReader reader, Utf8JsonWriter writer, IJT808Config config)
        {
            JT808_0x8900_0xF7 value = new JT808_0x8900_0xF7();
            value.USBCount = reader.ReadByte();
            writer.WriteNumber($"[{value.USBCount.ReadNumber()}]外设ID列表总数", value.USBCount);
            if (value.USBCount > 0)
            {
                writer.WriteStartArray("外设ID列表");
                for (int i = 0; i < value.USBCount; i++)
                {
                    writer.WriteStartObject();
                    byte usbId = reader.ReadByte();
                    writer.WriteNumber($"[{usbId.ReadNumber()}]外设ID", usbId);
                    writer.WriteEndObject();
                }
                writer.WriteEndArray();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="config"></param>
        /// <returns></returns>
        public JT808_0x8900_0xF7 Deserialize(ref JT808MessagePackReader reader, IJT808Config config)
        {
            JT808_0x8900_0xF7 value = new JT808_0x8900_0xF7();
            value.USBCount = reader.ReadByte();
            if (value.USBCount > 0)
            {
                value.MultipleUSB = new List<byte>();
                for (int i = 0; i < value.USBCount; i++)
                {
                    value.MultipleUSB.Add(reader.ReadByte());
                }
            }
            return value;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="value"></param>
        /// <param name="config"></param>
        public void Serialize(ref JT808MessagePackWriter writer, JT808_0x8900_0xF7 value, IJT808Config config)
        {
            if (value.MultipleUSB != null && value.MultipleUSB.Count > 0)
            {
                writer.WriteByte((byte)value.MultipleUSB.Count);
                foreach (var item in value.MultipleUSB)
                {
                    writer.WriteByte(item);
                }
            }
        }
    }
}
