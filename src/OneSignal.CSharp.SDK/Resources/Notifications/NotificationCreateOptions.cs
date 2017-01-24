using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace OneSignal.CSharp.SDK.Resources.Notifications
{
    /// <summary>
    /// API Documentation: https://documentation.onesignal.com/docs/notifications-create-notification
    /// </summary>
    public class NotificationCreateOptions
    {
        /// <summary>
        /// Your OneSignal application ID, which can be found on our dashboard at onesignal.com under App Settings > Keys & IDs. 
        /// It is a UUID and looks similar to 8250eaf6-1a58-489e-b136-7c74a864b434.
        /// </summary>
        [JsonProperty("app_id")]
        public Guid AppId { get; set; }

        /// <summary>
        /// The notification's content (excluding the title), a map of language codes to text for each language.
        /// Each hash must have a language code string for a key, mapped to the localized text you would like users to receive for that language.
        /// English must be included in the hash.
        /// Example: {"en": "English Message", "es": "Spanish Message"}
        /// See the language codes you can use here: https://documentation.onesignal.com/docs/frequently-asked-questions#section-what-languages-codes-can-i-use-
        /// </summary>
        [JsonProperty("contents")]
        public IDictionary<string, string> Contents { get; set; }

        /// <summary>
        /// The notification's title, a map of language codes to text for each language.
        /// Each hash must have a language code string for a key, mapped to the localized text you would like users to receive for that language.
        /// A default title may be displayed if a title is not provided. 
        /// Example: {"en": "English Title", "es": "Spanish Title"}
        /// See the language codes you can use here: https://documentation.onesignal.com/docs/frequently-asked-questions#section-what-languages-codes-can-i-use-
        /// </summary>
        [JsonProperty("headings")]
        public IDictionary<string, string> Headings { get; set; }

        /// <summary>
        /// A custom map of data that is passed back to your app.
        /// Example: {"abc": "123", "foo": "bar"}
        /// See the language codes you can use here: https://documentation.onesignal.com/docs/frequently-asked-questions#section-what-languages-codes-can-i-use-
        /// </summary>
        [JsonProperty("data")]
        public IDictionary<string, string> Data { get; set; }

        /// <summary>
        /// Targets notification recipients with filters. 
        /// This is a array of JSON objects containing field conditions to check.
        /// </summary>
        [JsonProperty("filters")]
		public IList<INotificationFilter> Filters { get; set; }

        /// <summary>
        /// Send based on OneSignal PlayerIds  
        /// </summary>
        [JsonProperty("include_player_ids")]
		public IList<string> IncludePlayerIds { get; set; }

        /// <summary>
        /// The segment names you want to target. 
        /// Users in these segments will receive a notification. 
        /// This targeting parameter is only compatible with excluded_segments.
        /// </summary>
        [JsonProperty("included_segments")]
        public IList<string> IncludedSegments { get; set; }

        ///<summary>
        /// Schedule notification for future delivery.
        ///Examples: All examples are the exact same date & time.
        ///"Thu Sep 24 2015 14:00:00 GMT-0700 (PDT)"
        ///"September 24th 2015, 2:00:00 pm UTC-07:00"
        ///"2015-09-24 14:00:00 GMT-0700"
        ///"Sept 24 2015 14:00:00 GMT-0700"
        ///"Thu Sep 24 2015 14:00:00 GMT-0700 (Pacific Daylight Time)"
        /// </summary>
        [JsonProperty("send_after")]
        public string SendAfter { get; set; }

        /// <summary>
        /// Sets the web push notification's icon. 
        /// An image URL linking to a valid image. 
        /// Common image types are supported; GIF will not animate. 
        /// We recommend 256x256 (at least 80x80) to display well on high DPI devices. 
        /// Firefox will also use this icon, unless you specify firefox_icon.
        /// </summary>
        [JsonProperty("chrome_web_icon")]
        public string ChromeWebIcon { get; set; }

        public NotificationCreateOptions()
        {
            Contents = new Dictionary<string, string>();
            Headings = new Dictionary<string, string>();
        }
    }
}
