namespace OneSignal.CSharp.SDK.Resources.Notifications
{
    public interface INotificationsResource
    {
        NotificationCreateResult Create(NotificationCreateOptions options);
        NotificationCancelResult Cancel(NotificationCancelOptions options);
    }
}
