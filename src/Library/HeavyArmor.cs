namespace RoleplayGame
{
    public class HeavyArmor : IDefensiveItems
    {
        public int Defensevalue { get; }

        public HeavyArmor ()
        {
            this.Defensevalue = 30;
        }
    }


}