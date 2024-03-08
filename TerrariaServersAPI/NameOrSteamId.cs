namespace TerrariaServersAPI
{
    #region NameOrSteamId

    /// <summary>
    /// Is either a number or a string, depending on what you specify. 
    /// </summary>
    // May be named "NumberOrString"
    public class NameOrSteamId
    {
        public virtual object Value { get; set; } = new object();
        protected NameOrSteamId() { }

        public static implicit operator NameOrSteamId(string name)
        {
            return new Name(name);
        }
        public static implicit operator NameOrSteamId(int id)
        {
            return new ID(id);
        }

        public override string ToString()
        {
            return $"{(this is ID steamid ? $"steamid={steamid.id}" : $"username={Value}")}";
        }
    }

    #endregion
    #region Name

    class Name : NameOrSteamId
    {
        public string name;
        public override object Value { get => name; set => name = (string)value; }

        public Name(string name)
        {
            this.name = name;
        }
    }

    #endregion
    #region ID

    class ID : NameOrSteamId
    {
        public int id;
        public override object Value { get => id; set => id = (int)value; }

        public ID(int id)
        {
            this.id = id;
        }
    }

    #endregion
}
