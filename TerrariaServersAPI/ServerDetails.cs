#region Using

using Newtonsoft.Json;

#endregion

namespace TerrariaServersAPI
{
    /// <summary>
    /// Details of the server you specified.
    /// </summary>
    public struct ServerDetails
    {
        /// <summary>
        /// Server ID.
        /// </summary>
        [JsonProperty("id")]
        public string ID;
        /// <summary>
        /// Server name.
        /// </summary>
        [JsonProperty("name")]
        public string Name;

        /// <summary>
        /// Server address.
        /// </summary>
        [JsonProperty("address")]
        public string Address;
        /// <summary>
        /// Is a number. Server port.
        /// </summary>
        [JsonProperty("port")]
        public string Port;

        // number; 0 - false, 1 - true; "0"
        /// <summary>
        /// Is server private.
        /// Is a number, but is actually a boolean. Returns the value 0 or 1.
        /// </summary>
        [JsonProperty("private")]
        public string Private;
        /// <summary>
        /// Server password. If the server is not private, it returns "0".
        /// </summary>
        [JsonProperty("password")]
        public string Password;

        // "Russia"
        /// <summary>
        /// Server location.
        /// </summary>
        [JsonProperty("location")]
        public string Location;
        // "TerraZ.ru Server"
        /// <summary>
        /// Server hostname.
        /// </summary>
        [JsonProperty("hostname")]
        public string Hostname;
        // "TerraZ World"
        /// <summary>
        /// Game server map.
        /// </summary>
        [JsonProperty("map")]
        public string Map;

        // number; 0 - false, 1 - true; "1"
        /// <summary>
        /// Is server online.
        /// Is a number, but is actually a boolean. Returns the value 0 or 1.
        /// </summary>
        [JsonProperty("is_online")]
        public string IsOnline;
        // number; "102"
        /// <summary>
        /// Is a number. The number of players on the server at the moment.
        /// </summary>
        [JsonProperty("players")]
        public string Players;
        // number; "9999"
        /// <summary>
        /// Is a number. The maximum number of players that can connect to the server.
        /// </summary>
        [JsonProperty("maxplayers")]
        public string MaxPlayers;

        // game version; "1.4.4.9"
        /// <summary>
        /// Server game version.
        /// </summary>
        [JsonProperty("version")]
        public string Version;
        // ??
        [JsonProperty("platform")]
        public string? Platform;
        // number, "100"
        /// <summary>
        /// Server uptime.
        /// </summary>
        [JsonProperty("uptime")]
        public string Uptime;
        // number, "129"
        /// <summary>
        /// Server score.
        /// </summary>
        [JsonProperty("score")]
        public string Score;
        // number, "1"
        /// <summary>
        /// Server rank.
        /// </summary>
        [JsonProperty("rank")]
        public string Rank;
        // number, "75"
        /// <summary>
        /// Number of votes per server.
        /// </summary>
        [JsonProperty("votes")]
        public string Votes;
        // number, "91"
        /// <summary>
        /// The number of people who have added this server to their favorites.
        /// </summary>
        [JsonProperty("favorited")]
        public string Favorited;
        // number, "0"
        /// <summary>
        /// Number of comments.
        /// </summary>
        [JsonProperty("comments")]
        public string Comments;
        // "https://terraria-servers.com/server/178/"
        /// <summary>
        /// Link to the server on the site.
        /// </summary>
        [JsonProperty("url")]
        public string Url;

        // "March 8th, 2024 05:05 AM EST"
        /// <summary>
        /// Last status check.
        /// </summary>
        [JsonProperty("last_check")]
        public string LastCheck;
        // "March 8th, 2024 05:05 AM EST"
        /// <summary>
        /// Last time server was active.
        /// </summary>
        [JsonProperty("last_online")]
        public string LastOnline;
    }
}
