using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;

namespace OneSignal.CSharp.SDK.Resources.App
{
    /// <summary>
    /// API Documentation: https://documentation.onesignal.com/reference#create-an-app
    /// </summary>

    public class AppCreateOptions
    {
        /// <summary>
        /// Required The name of your new app, as displayed on your apps list on the dashboard. This can be renamed later.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// iOS - Either sandbox or production
        /// </summary>
        [JsonProperty("apns_env")]
        public string ApnsEnv { get; set; }
        /// <summary>
        /// iOS - Your apple push notification p12 certificate file, converted to a string and Base64 encoded.
        /// </summary>
        [JsonProperty("apns_12")]
        public string ApnsP12 { get; set; }
        /// <summary>
        /// iOS - Password for the apns_p12 file
        /// </summary>
        [JsonProperty("apns_p12_password")]
        public string ApnsP12Password { get; set; }
        /// <summary>
        /// Android - Your Google Push Messaging Auth Key 
        /// </summary>
        [JsonProperty("gcm_key")]
        public string GcmKey { get; set; }
        /// <summary>
        /// Android - Your Google Push Messaging Auth Key
        /// </summary>
        [JsonProperty("android_gcm_sender_id")]
        public string AndroidGcmSenderId { get; set; }
        /// <summary>
        /// Chrome, Firefox - The URL to your website. This field is required if you wish to enable web push and specify other web push parameters.
        /// </summary>
        [JsonProperty("chrome_web_origin")]
        public string ChromeWebOrign { get; set; }
        /// <summary>
        /// Chrome - Your default notification icon. Should be 80x80 pixels.
        /// </summary>
        [JsonProperty("chrome_web_default_notification_icon")]
        public string ChromeWebDefaultNotificationIcon { get; set; }
        /// <summary>
        /// Chrome - A subdomain of your choice in order to support Chrome Web Push on non-HTTPS websites. This field must be set in order for the chrome_web_gcm_sender_id property to be processed.
        /// </summary>
        [JsonProperty("chrome_web_sub_domain")]
        public string ChromeWebSubDomain { get; set; }
        /// <summary>
        /// Safari - Your apple push notification p12 certificate file for Safari Push Notifications, converted to a string and Base64 encoded.
        /// </summary>
        [JsonProperty("safari_apns_p12_password")]
        public string SafariApnsP12 { get; set; }
        /// <summary>
        /// Safari - The URL to your website
        /// </summary>
        [JsonProperty("site_name")]
        public string SiteName { get; set; }
        /// <summary>
        /// Safari - The hostname to your website including http(s)://
        /// </summary>
        [JsonProperty("safari_site_origin")]
        public string SafariaSiteOrigin { get; set; }
        /// <summary>
        /// Safari - A url for a 16x16 png notification icon
        /// </summary>
        [JsonProperty("safari_icon_16_16")]
        public string SafariIcon16X16 { get; set; }
        /// <summary>
        /// Safari - A url for a 32x32 png notification icon
        /// </summary>
        [JsonProperty("safari_icon_32_32")]
        public string SafariIcon32X32 { get; set; }
        /// <summary>
        /// Safari - A url for a 64x64 png notification icon
        /// </summary>
        [JsonProperty("safari_icon_64_64")]
        public string SafariIcon64X64 { get; set; }
        /// <summary>
        /// Safari - A url for a 128 x 128 png notification icon
        /// </summary>
        [JsonProperty("safari_icon_128_128")]
        public string SafariIcon128X128 { get; set; }
        /// <summary>
        /// Safari - A url for a 256 x 256 png notification icon
        /// </summary>
        [JsonProperty("safari_icon_256_256")]
        public string SafariIcon256X256 { get; set; }
        /// <summary>
        /// Your Google Push Messaging Auth Key if you use Chrome Apps / Extensions.
        /// </summary>
        [JsonProperty("chrome_key")]
        public string ChromeKey { get; set; }

        public AppCreateOptions()
        {

        }
    }
}
