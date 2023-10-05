namespace RoleplayGame
{

    public class DarkVaderEnemy : CharacterBase,IEnemy
    {
        public DarkVaderEnemy(string name)
        {
            Attack = 30;
            Health = 150;
            VictoryPoints = 30;
        }

        public int VictoryPoints { get; private set; }

    }

}