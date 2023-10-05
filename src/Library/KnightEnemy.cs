namespace RoleplayGame
{

    public class KnightEnemy : CharacterBase,IEnemy
    {
        public KnightEnemy(string name)
        {
            Attack = 25;
            Health = 120;
            VictoryPoints = 20;
        }

        public int VictoryPoints { get; private set; }

    }

}