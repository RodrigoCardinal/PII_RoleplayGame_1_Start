using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

namespace RoleplayGame
{   
    public class Wizard
    {
        public string Name {get;set;}
        public int Health {get;set;}
        public int Attack=10;

        public Wizard(string name)
        {
            this.Name=name;
        }

        public void AttackElf(Elf elf)
        {
            elf.Health-=Attack;
        }

        public void AttackDwarves(Dwarves Dwarve)
        {
            Dwarve.Health-=Attack;
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
        public void GetAttack(Wizard wizard)
        {
            Console.WriteLine($"El valor de ataque para {wizard.Name} es {wizard.Attack}");
        }
        public void GetHealth(Wizard wizard)
        {
            Console.WriteLine($"El valor de ataque para {wizard.Name} es {wizard.Health}");
        }
    }
}