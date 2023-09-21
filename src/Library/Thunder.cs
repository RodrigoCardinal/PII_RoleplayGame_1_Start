namespace RoleplayGame
{
    public class Thunder : IAttackSpells
    {
        public int Attackvalue { get; }

        public Thunder ()
        {
            this.Attackvalue = 5;
        }
    }
}