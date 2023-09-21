namespace RoleplayGame
{
    public class Fireball : IAttackSpells
    {
        public int Attackvalue { get; }

        public Fireball ()
        {
            this.Attackvalue = 10;
        }
    }
}