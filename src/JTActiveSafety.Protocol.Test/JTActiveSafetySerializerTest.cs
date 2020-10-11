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
            Assert.Equal("3031636400000000000000000000000000000000000000000000000000000000000000000000000000000000616C61726D2E786C737800000001000000050102030405", hex);
        }

        [Fact]
        public void DeserializeTest1()
        {
            var data = "3031636400000000000000000000000000000000000000000000000000000000000000000000000000000000616C61726D2E786C737800000001000000050102030405".ToHexBytes();
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
            var data = "3031636400000000000000000000000000000000000000000000000000000000000000000000000000000000616C61726D2E786C737800000001000000050102030405".ToHexBytes();
            var json = JTActiveSafetySerializer.Analyze(data);
        }
    }
}
