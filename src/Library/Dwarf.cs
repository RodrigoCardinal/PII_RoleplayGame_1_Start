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
        public bool HandStatus = false;
        public bool ArmorStatus = false;
        
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
      
        public bool AddItems (IItems item)
        {
            if ( HandStatus == false ) 
            {
                Attack += item.Attackvalue;
                Health += item.Defensevalue;
                HandStatus = true;
                return HandStatus;
            }
            else
            {
                return false;
            }
        }

        public bool RemoveItems (IItems item)
        {
            if ( HandStatus == true )                      
            {
                Attack -= item.Attackvalue;
                Health -= item.Defensevalue;
                HandStatus = false;
                return HandStatus;                
            }
            else
            {
                return true;
            }
        }

        public void Heal (Dwarf dwarf)
        {
            Health = Health + 10;
        }
    }
}