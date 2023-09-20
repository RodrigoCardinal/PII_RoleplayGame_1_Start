namespace RoleplayGame
{
    public class Shield : IDefensiveItems
    {
        public int Defensevalue { get; }

        public Shield ()
        {
            this.Defensevalue = 20;
        }
    }
}