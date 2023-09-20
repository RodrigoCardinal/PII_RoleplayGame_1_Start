using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace RoleplayGame 
{
    public class Elf : ICharacter
    {   
        public string Name {get;set;}
        public int Health { get; set; } = 100;
        public int Attack { get; set; } = 10;
        public int InitialHealth { get; set; } = 100;
        public bool HandStatus = false;
        public bool ArmorStatus = false;
        public Elf (string name)
        {
            this.Name = name;
        }
        public void AttackWizard (Wizard attack)
        {
            attack.Health -= Attack;
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