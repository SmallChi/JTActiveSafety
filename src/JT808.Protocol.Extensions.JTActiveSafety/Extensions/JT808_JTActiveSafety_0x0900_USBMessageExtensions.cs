using JT808.Protocol.Extensions.JTActiveSafety.Enums;
using JT808.Protocol.Extensions.JTActiveSafety.MessageBody;
using JT808.Protocol.MessagePack;

namespace JT808.Protocol.Extensions.JTActiveSafety.Extensions
{
#warning 由于透传消息类型没有向下传递导致下面获取不到，先用这种方式临时处理
    public static class JT808_JTActiveSafety_0x0900_USBMessageExtensions
    {
        /// <summary>
        /// 解析透传对象扩展
        /// </summary>
        /// <param name="jT808_JTActiveSafety_0X0900_USBMessage"></param>
        /// <param name="jT808_JTActiveSafety_0X0900_Type"></param>
        public static void ParseObject(this JT808_JTActiveSafety_0x0900_USBMessage jT808_JTActiveSafety_0X0900_USBMessage, JT808_JTActiveSafety_0x0900_Type jT808_JTActiveSafety_0X0900_Type)
        {
            switch(jT808_JTActiveSafety_0X0900_Type)
            {
                case JT808_JTActiveSafety_0x0900_Type.QueryState:
                    JT808MessagePackReader QueryStateMessagePackReader = new JT808MessagePackReader(jT808_JTActiveSafety_0X0900_USBMessage.MessageContent);
                    jT808_JTActiveSafety_0X0900_USBMessage.MessageContentObejct= JT808_JTActiveSafety_0x0900_USB_0xF7.Instance.Deserialize(ref QueryStateMessagePackReader, null);
                    break;
                case JT808_JTActiveSafety_0x0900_Type.QueryInfomation:
                    JT808MessagePackReader QueryInfomationMessagePackReader = new JT808MessagePackReader(jT808_JTActiveSafety_0X0900_USBMessage.MessageContent);
                    jT808_JTActiveSafety_0X0900_USBMessage.MessageContentObejct = JT808_JTActiveSafety_0x0900_USB_0xF7.Instance.Deserialize(ref QueryInfomationMessagePackReader, null);
                    break;
            }
        }
    }
}
