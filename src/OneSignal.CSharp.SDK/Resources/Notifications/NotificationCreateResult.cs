using System.Collections.Generic;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace OneSignal.CSharp.SDK.Resources.Notifications
{
    /// <summary>
    /// Result of notification create operation.
    /// </summary>
    public class NotificationCreateResult
    {
        /// <summary>
        /// Returns the number of recepients who received the message.
        /// </summary>
        [DeserializeAs(Name = "recipients")]
        public int Recipients { get; set; }

        /// <summary>
        /// Returns the id of the result.
        /// </summary>
        [DeserializeAs(Name = "id")]
        public string Id { get; set; }

        /// <summary><br/>
        /// Even if NotificationCreateResult is not null, you should always check the Error object for ErrorResultType.
        /// If ErrorResultType is HasInvalidPlayerIds or HasAllInvalidPlayerIds, than InvalidPlayerIds array will contain the list of not valid player ids. 
        /// See the details <see cref="!:https://documentation.onesignal.com/reference#section-results-create-notification">here</see>.<br/>
        /// </summary>
        [JsonProperty("errors")]
        [JsonConverter(typeof(NotificationCreateResultJsonConverter))]
        public NotificationErrorResult Error { get; set; }
    }
}
