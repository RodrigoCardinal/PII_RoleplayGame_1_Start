namespace RoleplayGame
{
    public class Earthquake : IAttackSpells
    {
        public int Attackvalue { get; }

        public Earthquake ()
        {
            this.Attackvalue = 20;
        }
    }
}