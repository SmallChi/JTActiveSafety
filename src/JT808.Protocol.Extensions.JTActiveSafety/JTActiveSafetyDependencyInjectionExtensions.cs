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
            return jT808Builder;
        }
    }
}
