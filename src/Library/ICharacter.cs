using RoleplayGame;

public interface ICharacter
{

    string Name{get; set;}
    int Health {get; set;}
    int Attack {get; set;}

    void AttackCharacter(ICharacter character){}

    void GetAttack(ICharacter character){}

    void GetHealth(ICharacter character){}

    void RemoveItems(IItems item){}

    void AddItems(){}
    
}