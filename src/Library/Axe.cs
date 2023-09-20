namespace RoleplayGame
{
    public class Axe : IItems
    {
        public int Attackvalue { get; }
        public int Defensevalue { get; }

        public Axe ()
        {
            this.Attackvalue = 15;
            this.Defensevalue = 0;
        }
    }
}