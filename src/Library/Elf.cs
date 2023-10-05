namespace RoleplayGame
{

    public class Elf : CharacterBase, IHero
    {
        public Elf(string name)
        {
            Name = name;
            Health = 100;
            Attack = 10;
        }
        
        public int VictoryPoints { get; private set; }
        public void AccumulateVictoryPoints(int points)
        {
            VictoryPoints += points;
        }
    }
}