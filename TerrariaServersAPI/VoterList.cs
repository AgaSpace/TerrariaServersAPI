#region Using

using Newtonsoft.Json;

#endregion

namespace TerrariaServersAPI
{
    public struct VoterList
    {
        #region Voter

        /// <summary>
        /// One of the list of voters.
        /// </summary>
        public struct Voter
        {
            // May require addition of steamid.

            // "Zoom L1"
            /// <summary>
            /// The username he specified.
            /// </summary>
            [JsonProperty("nickname")]
            public string Nickname;
            // "1"
            /// <summary>
            /// Is a number. How many times the user has voted.
            /// </summary>
            [JsonProperty("votes")]
            public string Votes;
        }

        #endregion

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
        // "7777"
        /// <summary>
        /// Server port.
        /// </summary>
        [JsonProperty("port")]
        public string Port;

        // "202403"
        /// <summary>
        /// The month when this information was received.
        /// </summary>
        [JsonProperty("month")]
        public string Month;

        /// <summary>
        /// List of voters.
        /// </summary>
        [JsonProperty("voters")]
        public List<Voter> Voters;
    }
}
