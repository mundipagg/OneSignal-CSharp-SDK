using Newtonsoft.Json;
using System;

namespace OneSignal.Resources.Notifications
{
    /// <summary>
    /// Get delivery and convert report about single notification.
    /// See <see cref="!:https://documentation.onesignal.com/reference#view-notification">API Documentation</see> for more info.
    /// </summary>
    public class NotificationViewOptions
    {
        /// <summary><br/>
        /// Your OneSignal application ID, which can be found on our dashboard at onesignal.com under App Settings > Keys &amp; IDs. <br/>
        /// It is a UUID and looks similar to 8250eaf6-1a58-489e-b136-7c74a864b434.<br/>
        /// </summary>
        [JsonProperty("app_id")]
        public Guid AppId { get; set; }


        /// <summary><br/>
        /// Notification ID 
        /// </summary>
        [JsonProperty("id")]
        public Guid Id { get; set; }

    }
}
