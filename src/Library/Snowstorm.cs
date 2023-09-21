namespace RoleplayGame
{
    public class Snowstorm : IAttackSpells
    {
        public int Attackvalue { get; }

        public Snowstorm ()
        {
            this.Attackvalue = 15;
        }
    }
}