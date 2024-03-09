namespace TerrariaServersAPI
{
    public static class APIRequest
    {
        public const string default_url = "http://terraria-servers.com/api/";

        #region CheckUserHasVoted

        /// <summary>
        /// To check if a Steam User or Username has voted or not, and if the vote has been claimed or not. This can be used for a reward plugin. The API will only check for the last 24 hours.
        /// </summary>
        /// <param name="key">Your Server API Key.</param>
        /// <param name="nameOrId">User name or steam id. Case insensitive.</param>
        /// <param name="url">When using a different URL, you should indicate it (for example, if the creator of your server created the URL so as not to cause a bunch of requests to terraria-server.com)</param>
        /// <returns>A response containing information about the user's vote.</returns>
        /// <exception cref="ArgumentNullException">Called when the argument <paramref name="nameOrId"/> is null.</exception>
        /// <exception cref="ArgumentException">Called if <paramref name="nameOrId"/> does not contain some required information.</exception>
        public static async Task<CheckUserHasVoted> CheckUserHasVoted(string key, NameOrSteamId nameOrId,
            string? url = null)
        {
            if (nameOrId == null)
                throw new ArgumentNullException(nameof(nameOrId));
            if (nameOrId is not Name && nameOrId is not ID)
                throw new ArgumentException("The type is neither a number nor a string.");
            return await InternalAPIRequest.checkuserhasvoted((url ?? default_url) + $"?object=votes&element=claim&key={key}&{nameOrId}");
        }
        /// <summary>
        /// To check if a Steam User or Username has voted or not, and if the vote has been claimed or not. This can be used for a reward plugin. The API will only check for the last 24 hours.
        /// </summary>
        /// <param name="key">Your Server API Key.</param>
        /// <param name="nameOrId">User name or steam id. Case insensitive.</param>
        /// <param name="identifier"></param>
        /// <param name="url">When using a different URL, you should indicate it (for example, if the creator of your server created the URL so as not to cause a bunch of requests to terraria-server.com)</param>
        /// <returns>A response containing information about the user's vote in JSON format.</returns>
        /// <exception cref="ArgumentNullException">Called when the argument <paramref name="nameOrId"/> is null.</exception>
        /// <exception cref="ArgumentException">Called if <paramref name="nameOrId"/> does not contain some required information.</exception>
        public static async Task<JsonResponse> CheckUserHasVoted(string key, NameOrSteamId nameOrId, string identifier, 
            string? url = null)
        {
            if (nameOrId == null)
                throw new ArgumentNullException(nameof(nameOrId));
            if (nameOrId is not Name && nameOrId is not ID)
                throw new ArgumentException("The type is neither a number nor a string.");
            return await InternalAPIRequest.response((url ?? default_url) + $"?object=votes&element=claim&key={key}&{nameOrId}&identifier={identifier}");
        }

        #endregion
        #region SetVoteAsClaimed

        /// <summary>
        /// To set a vote as claimed for a Steam User or Username. This can be used for a reward plugin. The API will only set vote as claimed in the last 24 hours.
        /// </summary>
        /// <param name="key">Your Server API Key.</param>
        /// <param name="nameOrId">User name or steam id.</param>
        /// <param name="url">When using a different URL, you should indicate it (for example, if the creator of your server created the URL so as not to cause a bunch of requests to terraria-server.com)</param>
        /// <returns>Response containing information about the vote that has been claimed.</returns>
        /// <exception cref="ArgumentNullException">Called when the argument <paramref name="nameOrId"/> is null.</exception>
        /// <exception cref="ArgumentException">Called if <paramref name="nameOrId"/> does not contain some required information.</exception>
        public static async Task<SetVoteAsClaimed> SetVoteAsClaimed(string key, NameOrSteamId nameOrId,
            string? url = null)
        {
            if (nameOrId == null)
                throw new ArgumentNullException(nameof(nameOrId));
            if (nameOrId is not Name && nameOrId is not ID)
                throw new ArgumentException("The type is neither a number nor a string.");
            return await InternalAPIRequest.setvoteasclaimed((url ?? default_url) + $"?action=post&object=votes&element=claim&key={key}&{nameOrId}");
        }
        /// <summary>
        /// To set a vote as claimed for a Steam User or Username. This can be used for a reward plugin. The API will only set vote as claimed in the last 24 hours.
        /// </summary>
        /// <param name="key">Your Server API Key.</param>
        /// <param name="nameOrId">User name or steam id.</param>
        /// <param name="identifier"></param>
        /// <param name="url">When using a different URL, you should indicate it (for example, if the creator of your server created the URL so as not to cause a bunch of requests to terraria-server.com)</param>
        /// <returns>Response containing information about the vote that has been claimed in JSON format.</returns>
        /// <exception cref="ArgumentNullException">Called when the argument <paramref name="nameOrId"/> is null.</exception>
        /// <exception cref="ArgumentException">Called if <paramref name="nameOrId"/> does not contain some required information.</exception>
        public static async Task<JsonResponse> SetVoteAsClaimed(string key, NameOrSteamId nameOrId, string identifier,
            string? url = null)
        {
            if (nameOrId == null)
                throw new ArgumentNullException(nameof(nameOrId));
            if (nameOrId is not Name && nameOrId is not ID)
                throw new ArgumentException("The type is neither a number nor a string.");
            return await InternalAPIRequest.response((url ?? default_url) + $"?action=post&object=votes&element=claim&key={key}&{nameOrId}&identifier={identifier}");
        }

        #endregion

        #region GetVoterListAsync

        /// <summary>
        /// To get the list of voters for your server. Limited to the top 1000 results. Output is cached for 3 minutes.
        /// </summary>
        /// <param name="key">Your Server API Key.</param>
        /// <param name="month">Period to get.</param>
        /// <param name="limit">Result limit. Max value is 1000. Default value is 100.</param>
        /// <param name="rank">Rank voters by nickname or steamid. Default value is nickname.</param>
        /// <param name="url">When using a different URL, you should indicate it (for example, if the creator of your server created the URL so as not to cause a bunch of requests to terraria-server.com)</param>
        /// <returns>List of voters on your server.</returns>
        public static async Task<VoterList> GetVoterListAsync(string key, VoterListMonth month,
            int? limit = null, VoterListRank? rank = null, string? url = null)
        {
            return await InternalAPIRequest.voterlist((url ?? default_url) + $"?object=servers&element=voters&key={key}&month={month.ToString().ToLower()}&format=json{(limit.HasValue ? $"&limit={limit.Value}" : null)}{(rank.HasValue ? $"&rank={rank.Value.ToString().ToLower()}" : null)}");
        }

        #endregion
        #region GetVotesListAsync

        /// <summary>
        /// To get the list of votes for your server. Limited to the last 1000 results. Output is cached for 3 minutes.
        /// </summary>
        /// <param name="key">Your Server API Key</param>
        /// <param name="limit">Result limit. Max value is 1000. Default value is 100.</param>
        /// <param name="nameOrId">User name or steam id.</param>
        /// <param name="url">When using a different URL, you should indicate it (for example, if the creator of your server created the URL so as not to cause a bunch of requests to terraria-server.com)</param>
        /// <returns>A list of your server's votes.</returns>
        public static async Task<VotesList> GetVotesListAsync(string key, 
            int? limit = null, NameOrSteamId? nameOrId = null, string? url = null)
        {
            return await InternalAPIRequest.voteslist((url ?? default_url) + $"?object=servers&element=votes&key={key}&format=json{(limit.HasValue ? $"&limit={limit.Value}" : null)}{nameOrId?.ToString()}");
        }

        #endregion
        #region GetServerFullDetailsAsync

        /// <summary>
        /// To get the full detail of your server in json format. Can be used to create your own status page for example.
        /// Output is cached for 3 minutes.
        /// </summary>
        /// <param name="key">Your Server API Key</param>
        /// <param name="url">When using a different URL, you should indicate it (for example, if the creator of your server created the URL so as not to cause a bunch of requests to terraria-server.com)</param>
        /// <returns>Your server details.</returns>
        public static async Task<ServerDetails> GetServerFullDetailsAsync(string key, string? url = null)
        {
            return await InternalAPIRequest.serverdetails((url ?? default_url) + $"?object=servers&element=detail&key={key}");
        }

        #endregion
    }
}
