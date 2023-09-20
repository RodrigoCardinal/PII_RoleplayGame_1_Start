using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace RoleplayGame 
{
    public class Dwarf : ICharacter
    {
        public string Name { get; set; }
        public int Health { get; set; } = 175;
        public int Attack { get; set; } = 25;
        public int InitialHealth { get; set; } = 175;
        public bool HandStatus = false;
        public bool ArmorStatus = false;
        
        public Dwarf (string name)
        {
            this.Name = name;          
        }

        public void AttackCharacter (ICharacter Character)
        {
            ICharacter.Health -= Attack;
        }
        public void AttackElf (Elf elf)
        {
            elf.Health -= Attack;
        }

        public bool AddSword (Sword sword)
        {
            if( HandStatus == false ) 
            {
                Attack += sword.attackvalue;
                Health += sword.defensevalue;
                 HandStatus = true;
                 return HandStatus;

            }
            else
            {
                return false;
            }
        }

        public void RemoveSword (Sword sword)
        {
            Attack -= sword.attackvalue;
            Health -= sword.defensevalue;
        }

        public bool AddAxe (Axe axe)
        {
           if( HandStatus == false ) 
            {
                Attack += axe.attackvalue;
                Health += axe.defensevalue;
                HandStatus = true;
                return HandStatus;
            }
            else
            {
                return false;
            }
        }

        public void RemoveAxe (Axe axe)
        {
            Attack -= axe.attackvalue;
            Health -= axe.defensevalue;
        }

        public bool AddShield (Shield shield)
        {
            if( HandStatus == false ) 
            {
                Attack += shield.attackvalue;
                Health += shield.defensevalue;
                HandStatus = true;
                return HandStatus;
            }
            else
            {
                return false;
            }
        }

        public void RemoveShield (Shield shield)
        {
            Attack -= shield.attackvalue;
            Health -= shield.defensevalue;
        }

        public bool AddLightArmor (LightArmor lightarmor)
        {
            if( ArmorStatus == false ) 
            {
                Attack += lightarmor.attackvalue;
                Health += lightarmor.defensevalue;
                ArmorStatus = true;
                return ArmorStatus;
            }
            else
            {
                return false;
            }
        }

        public void RemoveLightArmor (LightArmor lightArmor)
        {
            Attack -= lightArmor.attackvalue;
            Health -= lightArmor.defensevalue;
        }

        public bool AddHeavyArmor (HeavyArmor heavyarmor)
        {
            if( ArmorStatus == false ) 
            {
                Attack += heavyarmor.attackvalue;
                Health += heavyarmor.defensevalue;
                ArmorStatus = true;
                return ArmorStatus;
            }
            else
            {
                return false;
            }
        }

        public void RemoveHeavyArmor (HeavyArmor heavyarmor)
        {
            Attack -= heavyarmor.attackvalue;
            Health -= heavyarmor.defensevalue;
        }
        public void Heal (Dwarf dwarf)
        {
            Health = InitialHealth;
        }
        public int GetAttack (Dwarf dwarf)
        {
            return dwarf.Attack;
        }
        public int GetHealth (Dwarf dwarf)
        {
            return dwarf.Health;
        }
    }
}