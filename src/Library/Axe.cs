namespace RoleplayGame
{
    public class Axe : IAttackItems
    {
        public int Attackvalue { get; }

        public Axe ()
        {
            this.Attackvalue = 15;
        }
    }
}