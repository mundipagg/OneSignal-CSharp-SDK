using OneSignal.CSharp.SDK.Resources.Notifications;
using OneSignal.CSharp.SDK.Resources.Devices;

namespace OneSignal.CSharp.SDK
{
    public interface IOneSignalClient
    {
        IDevicesResource Devices { get; }
        INotificationsResource Notifications { get; }
    }
}
