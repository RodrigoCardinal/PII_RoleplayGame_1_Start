namespace RoleplayGame
{
    public class Sword : IAttackItems
    {
        public int Attackvalue { get; }

        public Sword ()
        {
            this.Attackvalue = 10;
        }
    }
}