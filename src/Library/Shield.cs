namespace RoleplayGame
{
    public class Shield : IItems
    {
        public int Attackvalue { get; }
        public int Defensevalue { get; }

        public Shield ()
        {
            this.Attackvalue = 0;
            this.Defensevalue = 20;
        }
    }
}