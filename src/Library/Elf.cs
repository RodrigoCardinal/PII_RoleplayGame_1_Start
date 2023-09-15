using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace RoleplayGame 
{
    public class Elf
    {   
        public string Name {get;set;}
        public int Health { get; set; } = 100;
        public int Attack { get; set; } = 10;
        public int InitialHealth { get; set; } = 100;

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
        public void Heal (Elf elf)
        {
            Health = InitialHealth;
        }
        public void GetAttack (Elf elf)
        {
            Console.WriteLine ($"El valor de ataque para {elf.Name} es {elf.Attack}");
        }
        public void GetHealth (Elf elf)
        {
            Console.WriteLine ($"El valor de salud para {elf.Name} es {elf.Health}");
        }
    }
}