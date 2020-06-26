using System.IO;
using Newtonsoft.Json;
using RestSharp.Serializers;

namespace OneSignal.Serializers
{
    /// <summary>
    /// Custom implementation to Json serializer in order to comply with REST Sharp requirements.
    /// </summary>
    public class NewtonsoftJsonSerializer : ISerializer
    {
        private readonly Newtonsoft.Json.JsonSerializer _serializer;

        /// <summary>
        /// Content type.
        /// </summary>
        public string ContentType
        {
            get { return "application/json"; }
            set { }
        }

        /// <summary>
        /// Date format.
        /// </summary>
        public string DateFormat { get; set; }

        /// <summary>
        /// Namespace.
        /// </summary>
        public string Namespace { get; set; }

        /// <summary>
        /// Root element.
        /// </summary>
        public string RootElement { get; set; }

        /// <summary>
        /// Serializes object.
        /// </summary>
        /// <param name="obj">Object to serialize.</param>
        /// <returns></returns>
        public string Serialize(object obj)
        {
            using (var stringWriter = new StringWriter())
            {
                using (var jsonTextWriter = new JsonTextWriter(stringWriter))
                {
                    jsonTextWriter.Formatting = Formatting.Indented;
                    jsonTextWriter.QuoteChar = '"';

                    _serializer.Serialize(jsonTextWriter, obj);

                    var result = stringWriter.ToString();
                    return result;
                }
            }
        }

        /// <summary>
        /// Default constructor that prevents null values to be serialized.
        /// </summary>
        public NewtonsoftJsonSerializer()
        {
            _serializer = new Newtonsoft.Json.JsonSerializer
            {
                MissingMemberHandling = MissingMemberHandling.Ignore,
                NullValueHandling = NullValueHandling.Ignore,
                DefaultValueHandling = DefaultValueHandling.Include
            };
        }
    }
}
