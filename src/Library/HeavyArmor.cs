namespace RoleplayGame
{
    public class HeavyArmor : IDefensiveItems
    {
        public int DefenseValue { get; }

        public HeavyArmor ()
        {
            this.DefenseValue = 30;
        }
    }


}