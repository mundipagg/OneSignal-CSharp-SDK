![OneSignal Logo](https://onesignal.com/assets/common/logo_onesignal_color.png)

# OneSignal-CSharp
A General purpose rest ApiClient write in C# language for the OneSignal API

[![Build status](https://ci.appveyor.com/api/projects/status/iund7iijr534jghd/branch/master?svg=true)](https://ci.appveyor.com/project/MundiPagg/onesignal-csharp-sdk/branch/master)

## Install via NuGet

```
PM> Install-Package OneSignal.CSharp.SDK
```

## How to use

```csharp
var client = new OneSignalClient("ZWM3YThlMmQtMzY1NC00ODI1LTlkYjMtMTk3MzI2OTQzMjVh");

var options = new NotificationCreateOptions();

options.AppId = "089e4845-9849-4157-8b29-71e174af3abf";
options.IncludedSegments = new List<string> { "All" };
options.Contents.Add(LanguageCodes.English, "Hello world!");

client.Notifications.Create(options);
```

## OneSignal Api Oficial Documentation
[OneSignal Server API](https://documentation.onesignal.com/reference)
