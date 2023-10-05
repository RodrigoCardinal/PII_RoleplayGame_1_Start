namespace RoleplayGame
{

    public class DarkWizardEnemy : CharacterBase,IEnemy
    {
        public DarkWizardEnemy(string name)
        {
            Attack = 20;
            Health = 100;
            VictoryPoints = 15;
        }

        public int VictoryPoints { get; private set; }

    }

}