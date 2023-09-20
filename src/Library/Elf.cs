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
        }
        public void AttackCharacter (ICharacter character)
        {
            character.Health -= Attack;
        }
        public void AttackDwarves (Dwarf Dwarve)
        {
            Dwarve.Health -= Attack;
        }

        public bool AddItems (IItems item)
        {
            if ( HandStatus == false )                      
            {
                Attack += item.attackvalue;
                Health += item.defensevalue;
                HandStatus = true;
                return HandStatus;                
            }
            else
            {
                return false;
            }



        }
        public void Heal (Elf elf)
        {
            Health = InitialHealth;
        }
        public int GetAttack (Elf elf)
        {
            return elf.Attack;
        }
        public int GetHealth (Elf elf)
        {
            return elf.Health;
        }
    }
}