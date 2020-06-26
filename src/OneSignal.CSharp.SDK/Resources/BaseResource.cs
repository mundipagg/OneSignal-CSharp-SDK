using RestSharp;

namespace OneSignal.Resources
{
    /// <summary>
    /// Abstract class which helps easier implementation of new client resources.
    /// </summary>
    public abstract class BaseResource
    {
        /// <summary>
        /// Rest client reference.
        /// </summary>
        protected RestClient RestClient { get; set; }

        /// <summary>
        /// Your OneSignal Api key.
        /// </summary>
        protected string ApiKey { get; set; }

        /// <summary>
        /// Default constructor.
        /// </summary>
        /// <param name="apiKey">Your OneSignal API key</param>
        /// <param name="apiUri">API uri (https://onesignal.com/api/v1/notifications)</param>
        protected BaseResource(string apiKey, string apiUri)
        {
            ApiKey = apiKey;
            RestClient = new RestClient(apiUri);
        }
    }
}
