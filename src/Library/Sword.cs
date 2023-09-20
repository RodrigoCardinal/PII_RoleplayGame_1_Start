namespace RoleplayGame
{
    public class Sword : IItems
    {
        public int Attackvalue { get; }
        public int Defensevalue { get; }

        public Sword ()
        {
            this.Attackvalue = 10;
            this.Defensevalue = 0;
        }
    }
}