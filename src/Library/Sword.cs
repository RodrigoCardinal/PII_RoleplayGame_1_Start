namespace RoleplayGame
{
    public class Sword : IAttackItems
    {
        public int AttackValue { get; }

        public Sword ()
        {
            this.AttackValue = 10;
        }
    }
}