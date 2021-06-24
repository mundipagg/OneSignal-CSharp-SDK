using System;
using System.Net;
using OneSignal.CSharp.SDK.Serializers;
using RestSharp;

namespace OneSignal.CSharp.SDK.Resources.Devices
{
    /// <summary>
    /// Implementation of BaseResource, used to help client add or edit device.
    /// </summary>
    public class DevicesResource : BaseResource, IDevicesResource
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="apiKey">Your OneSignal API key</param>
        /// <param name="apiUri">API uri (https://onesignal.com/api/v1/notifications)</param>
        public DevicesResource(string apiKey, string apiUri) : base(apiKey, apiUri)
        {
        }

        /// <summary>
        /// Adds new device into OneSignal App.
        /// </summary>
        /// <param name="options">Here you can specify options used to add new device.</param>
        /// <returns>Result of device add operation.</returns>
        public DeviceAddResult Add(DeviceAddOptions options)
        {
            var restRequest = new RestRequest("players", Method.POST);

            restRequest.AddHeader("Authorization", string.Format("Basic {0}", base.ApiKey));

            restRequest.RequestFormat = DataFormat.Json;
            restRequest.JsonSerializer = new NewtonsoftJsonSerializer();
            restRequest.AddBody(options);

            var restResponse = base.RestClient.Execute<DeviceAddResult>(restRequest);

            if (restResponse.ErrorException != null)
            {
                throw restResponse.ErrorException;
            }

            return restResponse.Data;
        }

        /// <summary>
        /// Edits existing device defined in OneSignal App.
        /// </summary>
        /// <param name="id">Id of the device</param>
        /// <param name="options">Options used to modify attributes of the device.</param>
        /// <exception cref="Exception"></exception>
        public void Edit(string id, DeviceEditOptions options)
        {
            RestRequest restRequest = new RestRequest("players/{id}", Method.PUT);

            restRequest.AddHeader("Authorization", string.Format("Basic {0}", base.ApiKey));

            restRequest.AddUrlSegment("id", id);

            restRequest.RequestFormat = DataFormat.Json;
            restRequest.JsonSerializer = new NewtonsoftJsonSerializer();
            restRequest.AddBody(options);

            IRestResponse restResponse = base.RestClient.Execute(restRequest);

            if (restResponse.ErrorException != null)
            {
                throw restResponse.ErrorException;
            }
        }


		/// <summary>
		/// View the details of an existing device in one of your OneSignal apps
		/// </summary>
		/// <param name="id">Player's OneSignal ID</param>
		/// <returns></returns>
		public DeviceViewResult View(string id)
		{
			var baseRequestPath = "players/{0}";

			RestRequest restRequest = new RestRequest(string.Format(baseRequestPath, id), Method.GET);

			restRequest.AddHeader("Authorization", string.Format("Basic {0}", base.ApiKey));

			restRequest.RequestFormat = DataFormat.Json;
			restRequest.JsonSerializer = new NewtonsoftJsonSerializer();

			IRestResponse<DeviceViewResult> restResponse = base.RestClient.Execute<DeviceViewResult>(restRequest);

			if (restResponse.ErrorException != null)
			{
				throw restResponse.ErrorException;
			}
			else if (restResponse.StatusCode != HttpStatusCode.OK && restResponse.Content != null)
			{
				throw new Exception(restResponse.Content);
			}

			return restResponse.Data;
		}

	}
}
