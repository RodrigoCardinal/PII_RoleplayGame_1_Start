namespace RoleplayGame
{
    public class LightArmor : IDefensiveItems
    {
        public int Defensevalue { get; }

        public LightArmor ()
        {
            this.Defensevalue = 15;
        }
    }
}