namespace TerrariaServersAPI
{
    public enum CheckUserHasVoted
    {
        /// <summary>
        /// Not found.
        /// </summary>
        NotFound = 0,

        /// <summary>
        /// Has voted and not claimed.
        /// </summary>
        HasVoted = 1,
        /// <summary>
        /// Has voted and claimed.
        /// </summary>
        HasVotedAndClaimed = 2
    }
}
