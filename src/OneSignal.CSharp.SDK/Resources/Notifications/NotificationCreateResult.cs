using System.Collections.Generic;
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

        /// <summary>
        /// Return errors of the result
        /// </summary>
        [DeserializeAs(Name = "errors")]
        public List<string> Errors { get; set; }
    }
}
