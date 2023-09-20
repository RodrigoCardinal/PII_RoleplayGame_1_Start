namespace RoleplayGame
{
    public class HeavyArmor : IItems
    {
        public int Attackvalue { get; }
        public int Defensevalue { get; }

        public HeavyArmor ()
        {
            this.Attackvalue = 0;
            this.Defensevalue = 30;
        }
    }


}