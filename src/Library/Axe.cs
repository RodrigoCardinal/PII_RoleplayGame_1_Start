namespace RoleplayGame
{
    public class Axe : IAttackItems
    {
        public int AttackValue { get; }

        public Axe ()
        {
            this.AttackValue = 15;
        }
    }
}