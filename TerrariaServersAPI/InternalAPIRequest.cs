#region Using

using Newtonsoft.Json;

#endregion

namespace TerrariaServersAPI
{
    internal static class InternalAPIRequest
    {
        internal static HttpClient _client = new HttpClient();

        internal static async Task<CheckUserHasVoted> checkuserhasvoted(string url)
        {
            return (CheckUserHasVoted)await deserialize<Int32>(url);
        }
        internal static async Task<SetVoteAsClaimed> setvoteasclaimed(string url)
        {
            return (SetVoteAsClaimed)await deserialize<Int32>(url);
        }

        internal static async Task<JsonResponse> response(string url)
        {
            return await deserialize<JsonResponse>(url);
        }

        internal static async Task<VoterList> voterlist(string url)
        {
            return await deserialize<VoterList>(url);
        }
        internal static async Task<VotesList> voteslist(string url)
        {
            return await deserialize<VotesList>(url);
        }
        internal static async Task<ServerDetails> serverdetails(string url)
        {
            return await deserialize<ServerDetails>(url);
        }

        internal static async Task<T?> deserialize<T>(string url)
        {
            return JsonConvert.DeserializeObject<T>(await get(url));
        }
        internal static async Task<string> get(string url)
        {
            using (HttpResponseMessage response = await _client.GetAsync(url))
            {
                using (HttpContent content = response.Content)
                {
                    return await content.ReadAsStringAsync();
                }
            }
        }
    }
}
