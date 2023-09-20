using RoleplayGame;

public interface ICharacter
{

    string Name{get; set;}
    int Health {get; set;}
    int Attack {get; set;}

    void GetAttack(ICharacter enemy){}

    void RemoveItems(IItems item){}

    void AddItems(){}
    
}