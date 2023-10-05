using RoleplayGame;

namespace RoleplayGame
{
public interface ICharacter
{
    string Name { get; set; }
    int Health { get; set; }
    int Attack { get; set; }

    void AttackCharacter(ICharacter character);
    int GetAttack(ICharacter character);
    int GetHealth(ICharacter character);
    void AddAttackItem(IAttackItems item);
    void RemoveAttackItem(IAttackItems item);
    void AddDefensiveItem(IDefensiveItems item);
    void RemoveDefensiveItem(IDefensiveItems item);
    void Heal(ICharacter character);
}
}