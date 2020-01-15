# JTActiveSafety

JTActiveSafety协议、道路运输车辆主动安全智能防控系统-主动安全通讯协议主要分为两大部分。

1. 设备终端到平台的通信也就是JT808
2. 设备终端上传的附件数据也就是附件服务器

[![MIT Licence](https://img.shields.io/github/license/mashape/apistatus.svg)](https://github.com/SmallChi/JTActiveSafety/blob/master/LICENSE)[![Build Status](https://travis-ci.org/SmallChi/JTActiveSafety.svg?branch=master)](https://travis-ci.org/SmallChi/JTActiveSafety)

## 基于JT808扩展的JTActiveSafety消息协议

## NuGet安装

| Package Name          | Version                                            | Downloads                                           |
| --------------------- | -------------------------------------------------- | --------------------------------------------------- |
| Install-Package JT808 | ![JT808](https://img.shields.io/nuget/v/JT808.svg) | ![JT808](https://img.shields.io/nuget/dt/JT808.svg) |
| Install-Package JT808.Protocol.Extensions.JTActiveSafety| ![JT808.Protocol.Extensions.JTActiveSafety](https://img.shields.io/nuget/v/JT808.Protocol.Extensions.JTActiveSafety.svg) | ![JT808](https://img.shields.io/nuget/dt/JT808.Protocol.Extensions.JTActiveSafety.svg) |

### JT808扩展协议消息对照表

| 序号  | 消息ID | 完成情况 | 测试情况 | 消息体名称 |
| :---: | :---: | :---: | :---: | :---:|
| 1 | 0x1210 | √ | √ | 报警附件信息消息 |
| 2 | 0x1211 | √ | √ | 文件信息上传 |
| 3 | 0x1212 | √ | √ | 文件上传完成消息 |
| 4 | 0x9208 | √ | √ | 报警附件上传指令 |
| 5 | 0x9212 | √ | √ | 文件上传完成消息应答 |
| 6 | 0x0200_0x64 | √ | √ | 高级驾驶辅助系统报警信息 |
| 7 | 0x0200_0x65 | √ | √ | 驾驶员状态监测系统报警信息 |
| 8 | 0x0200_0x66 | √ | √ | 胎压监测系统报警信息 |
| 9 | 0x0200_0x67 | √ | √ | 盲区监测系统报警信息 |
| 10 | 0x8103_0xF364 | √ | √ | 高级驾驶辅助系统参数 |
| 11 | 0x8103_0xF365 | √ | √ | 驾驶员状态监测系统参数 |
| 12 | 0x8103_0xF366 | √ | √ | 胎压监测系统参数 |
| 13 | 0x8103_0xF367 | √ | √ | 盲区监测系统参数 |
| 14 | 0x0900 | √ | √ | 上传基本信息 |
| 15 | 0x0900_USB_0xF7 | √ | √ | 外设工作状态 |
| 16 | 0x0900_USB_0xF8 | √ | √ | 外设系统信息 |
| 17 | 0x8900 | √ | √ | 查询基本信息 |

### 使用方法

```dotnet
IServiceCollection serviceDescriptors1 = new ServiceCollection();
serviceDescriptors1.AddJT808Configure()
                   .AddJTActiveSafetyConfigure();
```