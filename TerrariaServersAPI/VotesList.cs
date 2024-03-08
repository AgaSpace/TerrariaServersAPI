#region Using

using Newtonsoft.Json;

#endregion

namespace TerrariaServersAPI
{
    /// <summary>
    /// List of voters.
    /// </summary>
    public struct VotesList
    {
        /// <summary>
        /// Vote information.
        /// </summary>
        public struct Vote
        {
            // "March 8th, 2024 05:20 AM EST"
            /// <summary>
            /// The date the user voted.
            /// </summary>
            [JsonProperty("date")]
            public string Date;
            // "March 8th, 2024 11:20 AM CET"
            /// <summary>
            /// The date (cest) the user voted.
            /// </summary>
            [JsonProperty("date cest")]
            public string DateCest;
            // 1709871630
            /// <summary>
            /// Time when the user voted.
            /// </summary>
            [JsonProperty("timestamp")]
            public int Timestamp;
            // "1709893230"
            /// <summary>
            /// Is a number. Time (utc) when the user voted.
            /// </summary>
            [JsonProperty("utc timestamp")]
            public string UtcTimestamp;

            /// <summary>
            /// User name.
            /// </summary>
            [JsonProperty("nickname")]
            public string Nickname;
            // Is a number. 
            /// <summary>
            /// Is a number. User steam id.
            /// </summary>
            [JsonProperty("steamid")]
            public string SteamID;

            // number; 0 - false, 1 - true; "0"
            /// <summary>
            /// Is a number, but is actually a boolean. Is user claimed his reward.
            /// </summary>
            [JsonProperty("claimed")]
            public string Claimed;
        }

        // "TerraZ"
        /// <summary>
        /// Server name.
        /// </summary>
        [JsonProperty("name")]
        public string Name;
        // "s.terraz.ru"
        /// <summary>
        /// Server address.
        /// </summary>
        [JsonProperty("address")]
        public string Address;
        // number, "7777"
        /// <summary>
        /// Server port.
        /// </summary>
        [JsonProperty("port")]
        public string Port;
        // "202403"
        /// <summary>
        /// The month to which this information corresponds.
        /// </summary>
        [JsonProperty("month")]
        public string Month;

        // "Zoom L1"
        /// <summary>
        /// User name if it selected. 
        /// </summary>
        [JsonProperty("nickname")]
        public string? Nickname;
        /// <summary>
        /// User steam id if it selected.
        /// </summary>
        [JsonProperty("steamid")]
        public int? SteamID;

        // "06:00 AM CET"
        /// <summary>
        /// Time at which information is updated
        /// </summary>
        [JsonProperty("daily reset time")]
        public string DailyResetTime;

        /// <summary>
        /// List of votes.
        /// </summary>
        [JsonProperty("votes")]
        public List<Vote> Votes;
    }
}
