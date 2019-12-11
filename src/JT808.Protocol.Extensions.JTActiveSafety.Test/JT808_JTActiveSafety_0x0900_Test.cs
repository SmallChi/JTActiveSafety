using JT808.Protocol.Extensions.JTActiveSafety.MessageBody;
using JT808.Protocol.MessageBody;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace JT808.Protocol.Extensions.JTActiveSafety.Test
{
    public class JT808_JTActiveSafety_0x0900_Test
    {
        JT808Serializer JT808Serializer;
        public JT808_JTActiveSafety_0x0900_Test()
        {
            ServiceCollection serviceDescriptors = new ServiceCollection();
            serviceDescriptors.AddJT808Configure()
                                        .AddJTActiveSafetyConfigure();
            IJT808Config jT808Config = serviceDescriptors.BuildServiceProvider().GetRequiredService<IJT808Config>();
            JT808Serializer = new JT808Serializer(jT808Config);
        }
        [Fact]
        public void Serializer()
        {
            JT808_JTActiveSafety_0x0900 jT808UploadLocationRequest = new JT808_JTActiveSafety_0x0900
            {
                USBMessageCount=2,
                USBMessages=new List<JT808_JTActiveSafety_0x0900_USBMessage> {
                            new JT808_JTActiveSafety_0x0900_USBMessage{
                                USBID=1,
                                MessageContentObejct=new JT808_JTActiveSafety_0x0900_USB_0xF7{
                                AlarmStatus=1,
                                WorkingCondition=2
                            }
                        },
                new JT808_JTActiveSafety_0x0900_USBMessage{
                            USBID=2,
                            MessageContentObejct=new JT808_JTActiveSafety_0x0900_USB_0xF8{
                                CompantName="CompantName",
                                CustomerCode="CustomerCode",
                                DevicesID="DevicesID",
                                HardwareVersionNumber="HardwareVersionNumber",
                                ProductModel="ProductModel",
                                SoftwareVersionNumber="SoftwareVersionNumber"
                            }                             
                         }
                }
            };
            var hex = JT808Serializer.Serialize(jT808UploadLocationRequest).ToHexString();
            Assert.Equal("0201050200000001025C0B436F6D70616E744E616D650C50726F647563744D6F64656C15486172647761726556657273696F6E4E756D62657215536F66747761726556657273696F6E4E756D626572094465766963657349440C437573746F6D6572436F6465", hex);
        }
        [Fact]
        public void Deserialize()
        {
            var jT808UploadLocationRequest = JT808Serializer.Deserialize<JT808_JTActiveSafety_0x0900>("0201050200000001025C0B436F6D70616E744E616D650C50726F647563744D6F64656C15486172647761726556657273696F6E4E756D62657215536F66747761726556657273696F6E4E756D626572094465766963657349440C437573746F6D6572436F6465".ToHexBytes());
            Assert.Equal(2, jT808UploadLocationRequest.USBMessageCount);

            Assert.Equal(1, jT808UploadLocationRequest.USBMessages[0].USBID);
            JT808_JTActiveSafety_0x0900_USB_0xF7 jT808_JTActiveSafety_0X0900_USB_0XF7 = JT808Serializer.Deserialize< JT808_JTActiveSafety_0x0900_USB_0xF7 >(jT808UploadLocationRequest.USBMessages[0].MessageContent) ;
            Assert.Equal(1u, jT808_JTActiveSafety_0X0900_USB_0XF7.AlarmStatus);
            Assert.Equal(2, jT808_JTActiveSafety_0X0900_USB_0XF7.WorkingCondition);

            Assert.Equal(2, jT808UploadLocationRequest.USBMessages[1].USBID);
            JT808_JTActiveSafety_0x0900_USB_0xF8 jT808_JTActiveSafety_0X0900_USB_0XF8 = JT808Serializer.Deserialize<JT808_JTActiveSafety_0x0900_USB_0xF8>(jT808UploadLocationRequest.USBMessages[1].MessageContent); ;
            Assert.Equal("CompantName", jT808_JTActiveSafety_0X0900_USB_0XF8.CompantName);
            Assert.Equal("CompantName".Length, jT808_JTActiveSafety_0X0900_USB_0XF8.CompantNameLength);
            Assert.Equal("CustomerCode", jT808_JTActiveSafety_0X0900_USB_0XF8.CustomerCode);
            Assert.Equal("CustomerCode".Length, jT808_JTActiveSafety_0X0900_USB_0XF8.CustomerCodeLength);
            Assert.Equal("DevicesID", jT808_JTActiveSafety_0X0900_USB_0XF8.DevicesID);
            Assert.Equal("DevicesID".Length, jT808_JTActiveSafety_0X0900_USB_0XF8.DevicesIDLength);
            Assert.Equal("HardwareVersionNumber", jT808_JTActiveSafety_0X0900_USB_0XF8.HardwareVersionNumber);
            Assert.Equal("HardwareVersionNumber".Length, jT808_JTActiveSafety_0X0900_USB_0XF8.HardwareVersionNumberLength);
            Assert.Equal("ProductModel", jT808_JTActiveSafety_0X0900_USB_0XF8.ProductModel);
            Assert.Equal("ProductModel".Length, jT808_JTActiveSafety_0X0900_USB_0XF8.ProductModelLength);
            Assert.Equal("SoftwareVersionNumber", jT808_JTActiveSafety_0X0900_USB_0XF8.SoftwareVersionNumber);
            Assert.Equal("SoftwareVersionNumber".Length, jT808_JTActiveSafety_0X0900_USB_0XF8.SoftwareVersionNumberLength);
        }
    }
}
