namespace RoleplayGame
{
    public class ArcherEnemy : CharacterBase, IEnemy
    {
        public ArcherEnemy(string name)
        {
            Name = name;
            Attack = 15;
            Health = 80;
            VictoryPoints = 10;
        }

        public int VictoryPoints { get; private set; }
    }
}
