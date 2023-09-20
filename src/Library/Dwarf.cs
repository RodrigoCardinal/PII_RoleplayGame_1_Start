using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace RoleplayGame 
{
    public class Dwarf : ICharacter
    {
        public string Name { get; set; }
        public int Health { get; set; } 
        public int Attack { get; set; } 
        
        public Dwarf (string name)
        {
            this.Name = name;    
            this.Health = 175;
            this.Attack = 25;      
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

        public void Heal (Dwarf dwarf)
        {
            Health = Health + 10;
        }
    }
}