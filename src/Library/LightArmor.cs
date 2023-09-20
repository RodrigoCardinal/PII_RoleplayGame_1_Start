namespace RoleplayGame
{
    public class LightArmor : IItems
    {
        public int Attackvalue { get; }
        public int Defensevalue { get; }

        public LightArmor ()
        {
            this.Attackvalue = 0;
            this.Defensevalue = 15;
        }
    }
}