using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

namespace RoleplayGame
{   
    public class Wizard
    {
        public string Name { get; set; }
        public int Health { get; set; }=125;
        public int Attack { get; set; }=10;
        public int InitialHealth { get; set; } = 125;

        public Wizard (string name)
        {
            this.Name = name;
        }

        public void AttackElf (Elf elf)
        {
            elf.Health -= Attack;
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
        public void Heal (Wizard wizard)
        {
            Health = InitialHealth;
        }
        public void CastSpell (string spellname, SpellBook spellbook)
        {
            int spellvalue = spellbook.SpellInSpellBook (spellname);
        
            if (spellvalue > 0)
            {
                Attack += spellvalue;
                Console.WriteLine ($"El mago {Name} ha lanzado el hechizo {spellname} y ha aumentado su ataque en {spellvalue} puntos.");
            }
            else
            {
                Console.WriteLine ($"El hechizo {spellname} no existe en el SpellBook.");
            }
        }

        public void GetAttack (Wizard wizard)
        {
            Console.WriteLine ($"El valor de ataque para {wizard.Name} es {wizard.Attack}");
        }
        public void GetHealth (Wizard wizard)
        {
            Console.WriteLine ($"El valor de ataque para {wizard.Name} es {wizard.Health}");
        }
    }
}