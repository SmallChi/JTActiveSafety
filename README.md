# JTActiveSafety

JTActiveSafety协议、道路运输车辆主动安全智能防控系统-主动安全通讯协议主要分为两大部分。

1. 设备终端到平台的通信也就是JT808
2. 设备终端上传的附件数据也就是附件服务器

[![MIT Licence](https://img.shields.io/github/license/mashape/apistatus.svg)](https://github.com/SmallChi/JTActiveSafety/blob/master/LICENSE)[![Build Status](https://travis-ci.org/SmallChi/JTActiveSafety.svg?branch=master)](https://travis-ci.org/SmallChi/JTActiveSafety)

## 基于JT808扩展的JTActiveSafety消息协议

### JT808扩展协议消息对照表

| 序号  | 消息ID | 完成情况 | 测试情况 | 消息体名称 |
| :---: | :---: | :---: | :---: | :---:|

### 使用方法

```dotnet
IServiceCollection serviceDescriptors1 = new ServiceCollection();
serviceDescriptors1.AddJT808Configure()
                   .AddJTActiveSafetyConfigure();
```
