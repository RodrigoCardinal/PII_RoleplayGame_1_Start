namespace RoleplayGame
{
    public class LightArmor : IDefensiveItems
    {
        public int DefenseValue { get; }

        public LightArmor ()
        {
            this.DefenseValue = 15;
        }
    }
}