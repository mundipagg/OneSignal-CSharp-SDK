using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp.Deserializers;

namespace OneSignal.CSharp.SDK.Resources.Notifications
{
    /// <summary>
    /// Types of visibility for apps targeting Android API level 21+ running on Android 5.0+ devices.
    /// </summary>
    public enum AndroidVisibilityEnum
    {
        /// <summary>
        /// Public (default) (Shows the full message on the lock screen unless the user has disabled all notifications from showing on the lock screen. 
        /// Please consider the user and mark private if the contents are.)
        /// </summary>
        Public = 1,

        /// <summary>
        /// Private (Hides message contents on lock screen if the user set "Hide sensitive notification content" in the system settings)
        /// </summary>
        Private = 0,

        /// <summary>
        /// Secret (Notification does not show on the lock screen at all)
        /// </summary>
        Secret = -1
    }

    /// <summary>
    /// Describes whether to set or increase/decrease your app's iOS badge count by the ios_badgeCount specified count. Can specify None, SetTo, or Increase.
    /// </summary>
    public enum IosBadgeTypeEnum
    {
        /// <summary>
        /// Leaves the count unaffected.
        /// </summary>
        None,

        /// <summary>
        /// Directly sets the badge count to the number specified in ios_badgeCount.
        /// </summary>
        SetTo,

        /// <summary>
        /// Adds the number specified in ios_badgeCount to the total. Use a negative number to decrease the badge count.
        /// </summary>
        Increase
    }

    /// <summary>
    /// Possible options for delaying notification.
    /// </summary>
    public enum DelayedOptionEnum
    {
        /// <summary>
        /// Deliver at a specific time-of-day in each users own timezone
        /// </summary>
        TimeZone,

        /// <summary>
        /// Deliver at the same time of day as each user last used your app.
        /// </summary>
        LastActive,

        /// <summary>
        /// If send_after is used, this takes effect after the send_after time has elapsed.
        /// </summary>
        SendAfter
    }

    /// <summary>
    /// Class used to describe notification filter field type used in filter operations.
    /// </summary>
    public enum NotificationFilterFieldTypeEnum
    {
        /// <summary>
        /// relation = "&gt;" or "&lt;"<br/>
        /// hours_ago = number of hours before or after the users last session. Example: "1.1"
        /// </summary>
        LastSession,

        /// <summary>
        /// relation = "&gt;" or "&lt;"<br/>
        /// hours_ago = number of hours before or after the users first session. Example: "1.1"
        /// </summary>
        FirstSession,

        /// <summary>
        /// relation = "&gt;", "&lt;", "=" or "!="<br/>
        /// value = number sessions. Example: "1"
        /// </summary>
        SessionCount,

        /// <summary>
        /// relation = "&gt;" or "&lt;"<br/>
        /// value = Time in seconds the user has been in your app. Example: "3600"
        /// </summary>
        SessionTime,

        /// <summary>
        /// relation = "&gt;", "&lt;", or "="<br/>
        /// value = Amount in USD a user has spent on IAP (In App Purchases). Example: "0.99"
        /// </summary>
        AmountSpent,

        /// <summary>
        /// relation = "&gt;", "&lt;" or "="<br/>
        /// key = SKU purchased in your app as an IAP (In App Purchases). Example: "com.domain.100coinpack"<br/>
        /// value = value of SKU to compare to. Example: "0.99"
        /// </summary>
        BoughtSku,

        /// <summary>
        /// relation = "&gt;", "&lt;", "=", "!=", "exists" or "not_exists"<br/>
        /// key = Tag key to compare.<br/>
        /// value = Tag value to compare. Not required for "exists" or "not_exists".<br/>
        /// Example: See <see cref="!:https://documentation.onesignal.com/reference#section-formatting-filters">Formatting Filters</see>
        /// </summary>
        Tag,

        /// <summary>
        /// relation = "=" or "!="<br/>
        /// value = 2 character language code. Example: "en".<br/>
        /// For a list of all language codes go <see cref="!:https://documentation.onesignal.com/docs/language-localization">here</see>
        /// </summary>
        Language,

        /// <summary>
        /// relation = "&gt;", "&lt;", "=" or "!="<br/>
        /// value = app version. Example: "1.0.0"
        /// </summary>
        AppVersion,

        /// <summary>
        /// radius = in meters<br/>
        /// lat = latitude<br/>
        /// long = longitude<br/>
        /// 
        /// </summary>
        Location,

        /// <summary>
        /// value = email address
        /// </summary>
        Email
    }

    /// <summary>
    /// Helps distinguish the type of NotificationCreateResult, so that you can be given a proper result information.
    /// </summary>
    public enum ErrorResultTypeEnum
    {
        /// <summary>
        /// There was no error in notification create request.
        /// </summary>
        None,

        /// <summary>
        /// Notification content must not be null for any languages.
        /// </summary>
        NotificationContentEmpty,

        /// <summary>
        /// Returned if some used include_player_ids are valid, and some are not.
        /// Please process these on your server and remove them from your database if you are track them.
        /// </summary>
        HasInvalidPlayerIds,

        /// <summary>
        /// All included players are not subscribed
        /// </summary>
        HasAllInvalidPlayerIds
    }
}
