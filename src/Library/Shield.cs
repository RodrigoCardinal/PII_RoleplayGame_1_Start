namespace RoleplayGame
{
    public class Shield : IDefensiveItems
    {
        public int DefenseValue { get; }

        public Shield ()
        {
            this.DefenseValue = 20;
        }
    }
}