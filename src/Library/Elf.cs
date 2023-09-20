using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace RoleplayGame 
{
    public class Elf : ICharacter
    {   
        public string Name {get;set;}
        public int Health { get; set; }
        public int Attack { get; set; }
        public Elf (string name)
        {
            this.Name = name;
            this.Health = 100;
            this.Attack = 10;      
        }
        public void AttackCharacter (ICharacter character)
        {
            character.Health -= Attack;
        }

public int GetAttack (ICharacter character)
        {
            return character.Attack;
        }

        public int GetHealth (ICharacter character)
        {
            return character.Health;
        }
      
        public void AddItems (IItems item)
        {
                Attack += item.Attackvalue;
                Health += item.Defensevalue;
        }

        public void RemoveItems (IItems item)
        {
                Attack -= item.Attackvalue;
                Health -= item.Defensevalue;
        }

        public void Heal (Elf elf)
        {
            Health = Health + 10;
        }
    }
}