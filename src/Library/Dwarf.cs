using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace RoleplayGame 
{
    public class Dwarf
    {
        public string Name { get; set; }
        public int Health { get; set; } = 175;
        public int Attack { get; set; } = 25;
        public int InitialHealth { get; set; } = 175;
        public Dwarf (string name)
        {
            this.Name = name;          
        }

        public void AttackWizard (Wizard wizard)
        {
            wizard.Health -= Attack;
        }
        public void AttackElf (Elf elf)
        {
            elf.Health -= Attack;
        }

        public void AddSword (Sword sword)
        {
            Attack += sword.attackvalue;
            Health += sword.defensevalue;
        }

        public void RemoveSword (Sword sword)
        {
            Attack -= sword.attackvalue;
            Health -= sword.defensevalue;
        }

        public void AddAxe (Axe axe)
        {
            Attack += axe.attackvalue;
            Health += axe.defensevalue;
        }

        public void RemoveAxe (Axe axe)
        {
            Attack -= axe.attackvalue;
            Health -= axe.defensevalue;
        }

        public void AddShield (Shield shield)
        {
            Attack += shield.attackvalue;
            Health += shield.defensevalue;
        }

        public void RemoveShield (Shield shield)
        {
            Attack -= shield.attackvalue;
            Health -= shield.defensevalue;
        }

        public void AddLightArmor (LightArmor lightarmor)
        {
            Attack += lightarmor.attackvalue;
            Health += lightarmor.defensevalue;
        }

        public void RemoveLightArmor (LightArmor lightArmor)
        {
            Attack -= lightArmor.attackvalue;
            Health -= lightArmor.defensevalue;
        }

        public void AddHeavyArmor (HeavyArmor heavyarmor)
        {
            Attack += heavyarmor.attackvalue;
            Health += heavyarmor.defensevalue;
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