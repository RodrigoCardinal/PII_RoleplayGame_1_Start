using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

namespace RoleplayGame
{   
    public class Wizard
    {
        public string Name { get; set; }
        public int Health { get; set; } 
        public int Attack { get; set; } 
    
        public Wizard (string name)
        {
            this.Name = name;
            this.Health = Health;
            this.Attack = Attack;
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
            if( HandStatus == false ) 
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
        public void RemoveItems (IItems item)
        {
            Attack -= item.attackvalue;
            Health -= item.defensevalue;
        }
        public void Heal (ICharacter character)
        {
            Health = Health + 20;
        }
        public int GetAttack (ICharacter character)
        {
            return character.Attack;
        }
        public int GetHealth (ICharacter character)
        {
            return character.Health;
        }
        public void CastSpell (string spellname, SpellBook spellbook)
        {
            int spellvalue = spellbook.SpellInSpellBook (spellname);
        
            if (spellvalue > 0)
            {
                Attack += spellvalue;
            }
        }
    }
}