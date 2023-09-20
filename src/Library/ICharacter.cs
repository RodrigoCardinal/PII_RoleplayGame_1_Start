using RoleplayGame;

public interface ICharacter
{

    string Name{get; set;}
    int Health {get; set;}
    int Attack {get; set;}

    void AttackCharacter(ICharacter character){}

    void GetAttack(ICharacter character){}

    void GetHealth(ICharacter character){}

    void RemoveAttackItems(IAttackItems item){}
    void RemoveDefensiveItem(IDefensiveItems item){}

    void AddAttackItems(IAttackItems item){}
    void AddDefenseItems(IDefensiveItems item){}
    
}