using JT808.Protocol.Extensions.JTActiveSafety.Enums;
using JT808.Protocol.Extensions.JTActiveSafety.MessageBody;
using JT808.Protocol.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace JT808.Protocol.Extensions.JTActiveSafety
{
    public static class JTActiveSafetyDependencyInjectionExtensions
    {
        public static IJT808Builder AddJTActiveSafetyConfigure(this IJT808Builder jT808Builder)
        {
            jT808Builder.Config.Register(Assembly.GetExecutingAssembly());
            jT808Builder.Config.MsgIdFactory.SetMap<JT808_0x1210>((ushort)JT808_JTActiveSafety_MsgId.报警附件信息消息, "");
            jT808Builder.Config.MsgIdFactory.SetMap<JT808_0x1211>((ushort)JT808_JTActiveSafety_MsgId.文件信息上传, "");
            jT808Builder.Config.MsgIdFactory.SetMap<JT808_0x1212>((ushort)JT808_JTActiveSafety_MsgId.文件上传完成消息, "");
            jT808Builder.Config.MsgIdFactory.SetMap<JT808_0x9208>((ushort)JT808_JTActiveSafety_MsgId.报警附件上传指令, "");
            jT808Builder.Config.MsgIdFactory.SetMap<JT808_0x9212>((ushort)JT808_JTActiveSafety_MsgId.文件上传完成消息应答, "");
            jT808Builder.Config.JT808_0X0200_Factory.JT808LocationAttachMethod.Add(JT808_JTActiveSafety_Constants.JT808_0X0200_0x64, typeof(JT808_0x0200_0x64));
            jT808Builder.Config.JT808_0X0200_Factory.JT808LocationAttachMethod.Add(JT808_JTActiveSafety_Constants.JT808_0X0200_0x65, typeof(JT808_0x0200_0x65));
            jT808Builder.Config.JT808_0X0200_Factory.JT808LocationAttachMethod.Add(JT808_JTActiveSafety_Constants.JT808_0X0200_0x66, typeof(JT808_0x0200_0x66));
            jT808Builder.Config.JT808_0X0200_Factory.JT808LocationAttachMethod.Add(JT808_JTActiveSafety_Constants.JT808_0X0200_0x67, typeof(JT808_0x0200_0x67));
            jT808Builder.Config.JT808_0X8103_Factory.ParamMethods.Add(JT808_JTActiveSafety_Constants.JT808_0X8103_0xF364, typeof(JT808_0x8103_0xF364));
            jT808Builder.Config.JT808_0X8103_Factory.ParamMethods.Add(JT808_JTActiveSafety_Constants.JT808_0X8103_0xF365, typeof(JT808_0x8103_0xF365));
            jT808Builder.Config.JT808_0X8103_Factory.ParamMethods.Add(JT808_JTActiveSafety_Constants.JT808_0X8103_0xF366, typeof(JT808_0x8103_0xF366));
            jT808Builder.Config.JT808_0X8103_Factory.ParamMethods.Add(JT808_JTActiveSafety_Constants.JT808_0X8103_0xF367, typeof(JT808_0x8103_0xF367));
            return jT808Builder;
        }
    }
}
