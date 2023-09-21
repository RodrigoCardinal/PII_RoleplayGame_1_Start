namespace RoleplayGame
{
    public class HealAlly : IDefensiveSpells
    {
        public int Defensevalue { get; }

        public HealAlly ()
        {
            this.Defensevalue = 20;
        }
    }
}