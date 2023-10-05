
namespace RoleplayGame
{
    
    public abstract class CharacterBase : ICharacter
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Attack { get; set; }

        public void AttackCharacter(ICharacter character)
        {
            character.Health -= Attack;
        }

        public int GetAttack(ICharacter character)
        {
            return character.Attack;
        }

        public int GetHealth(ICharacter character)
        {
            return character.Health;
        }

        public void AddAttackItem(IAttackItems item)
        {
            Attack += item.AttackValue;
        }

        public void RemoveAttackItem(IAttackItems item)
        {
            Attack -= item.AttackValue;
        }

        public void AddDefensiveItem(IDefensiveItems item)
        {
            Health += item.DefenseValue;
        }

        public void RemoveDefensiveItem(IDefensiveItems item)
        {
            Health -= item.DefenseValue;
        }

        public void Heal(ICharacter character)
        {
            Health += 10;
        }
    }
}