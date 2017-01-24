using OneSignal.CSharp.SDK.Serializers;
using RestSharp;

namespace OneSignal.CSharp.SDK.Resources.App
{
    public class AppResource : BaseResource, IAppResource
    {
        public AppResource(string apiKey, string apiUri) : base(apiKey, apiUri)
        {
        }

        public AppAddResult CreateApp(AppCreateOptions appCreateOptions)
        {
            // TODO
            //var request = new RestRequest("app", Method.POST);
            //request.AddHeader("Authorization", string.Format("Basic {0}", base.ApiKey));
            //request.RequestFormat = DataFormat.Json;
            //request.JsonSerializer = new NewtonsoftJsonSerializer();
            //request.AddBody(appCreateOptions);
            //var response = base.RestClient.Execute<AppCreateOptions>(request);
            //if (response.ErrorException != null)
            //{
            //    throw response.ErrorException;
            //}
            //return response.Data;
            return null;
        }
    }
}
