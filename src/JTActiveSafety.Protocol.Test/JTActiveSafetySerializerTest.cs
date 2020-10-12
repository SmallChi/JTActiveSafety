using System;
using Xunit;
using JTActiveSafety.Protocol;
using JTActiveSafety.Protocol.Extensions;

namespace JTActiveSafety.Protocol.Test
{
    public class JTActiveSafetySerializerTest
    {
        [Fact]
        public void SerializeTest1()
        {
            JTActiveSafetyPackage package = new JTActiveSafetyPackage();
            package.FileName = "alarm.xlsx";
            package.Offset = 1;
            package.Bodies = new byte[5] { 1, 2, 3, 4, 5 };
            var hex = JTActiveSafetySerializer.Serialize(package).ToHexString();
            Assert.Equal("30 31 63 64 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 61 6C 61 72 6D 2E 78 6C 73 78 00 00 00 01 00 00 00 05 01 02 03 04 05", hex);
        }

        [Fact]
        public void DeserializeTest1()
        {
            var data = "30 31 63 64 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 61 6C 61 72 6D 2E 78 6C 73 78 00 00 00 01 00 00 00 05 01 02 03 04 05".ToHexBytes();
            var package = JTActiveSafetySerializer.Deserialize(data);
            Assert.Equal(JTActiveSafetyPackage.FH, package.FH_Flag);
            Assert.Equal("alarm.xlsx", package.FileName.TrimStart('\0'));
            Assert.Equal(1u, package.Offset);
            Assert.Equal(5u, package.Length);
            Assert.Equal(new byte[5] { 1, 2, 3, 4, 5 }, package.Bodies);
        }

        [Fact]
        public void AnalyzeTest1()
        {
            var data = "30 31 63 64 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 61 6C 61 72 6D 2E 78 6C 73 78 00 00 00 01 00 00 00 05 01 02 03 04 05".ToHexBytes();
            var json = JTActiveSafetySerializer.Analyze(data);
        }
    }
}
