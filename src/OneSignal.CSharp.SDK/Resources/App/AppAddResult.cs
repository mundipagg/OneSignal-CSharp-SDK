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
    /// https://documentation.onesignal.com/reference#create-an-app
    /// </summary>
    public class AppAddResult
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("players")]
        public int Players { get; set; }
        [JsonProperty("messagable_players")]
        public int MessagablePlayers { get; set; }
        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
        [JsonProperty("gcm_key")]
        public string GcmKey { get; set; }
        [JsonProperty("chrome_web_origin")]
        public string ChromeWebOrigin { get; set; }
        [JsonProperty("chrome_web_default_notification_icon")]
        public string ChromeWebDefaultNotificationIcon { get; set; }
        [JsonProperty("chrome_web_sub_domain")]
        public string ChromeWebSubDomain { get; set; }
        [JsonProperty("apns_env")]
        public string ApnsEnv { get; set; }
        [JsonProperty("apns_certificate")]
        public string ApnsCertificate { get; set; }
        [JsonProperty("apns_safari_certificates")]
        public string ApnsSafariCertificates { get; set; }
        [JsonProperty("safari_apns_certificate")]
        public string SafariApnsCertificate { get; set; }
        [JsonProperty("safari_site_origin")]
        public string SafariSiteOrgin { get; set; }
        [JsonProperty("safari_push_id")]
        public string SafariPushId { get; set; }
        [JsonProperty("safari_icon_16_16")]
        public string SafariIcon16X16 { get; set; }
        [JsonProperty("safari_icon_32_32")]
        public string SafariIcon32X32 { get; set; }
        [JsonProperty("safari_icon_64_64")]
        public string SafariIcon64X64 { get; set; }
        [JsonProperty("safari_icon_128_128")]
        public string SafariIcon128X128 { get; set; }
        [JsonProperty("safari_icon_256_256")]
        public string SafariIcon256X256 { get; set; }
    }
}
