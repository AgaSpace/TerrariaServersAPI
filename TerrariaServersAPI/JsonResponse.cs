#region Using

using Newtonsoft.Json;

#endregion

namespace TerrariaServersAPI
{
    public struct JsonResponse
    {
        /// <summary>
        /// Response received from API.
        /// </summary>
        [JsonProperty("response")]
        public int Response;
        /// <summary>
        /// The identifier is responsible for what type of data will be returned in the response.
        /// Accepts only JSON value. You can put anything, but you will receive an answer in JSON.
        /// </summary>
        [JsonProperty("identifier")]
        public string Identifier;
    }
}
