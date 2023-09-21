using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

namespace RoleplayGame
{   
    public class Wizard: ICharacter
    {
        public string Name { get; set; }
        public int Health { get; set; } 
        public int Attack { get; set; } 
    
        public Wizard (string name)
        {
            this.Name = name;
            this.Health = 125;
            this.Attack = 15;
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
      
        public void AddAttackItems (IAttackItems item)
        {
                Attack += item.Attackvalue;
        }
        public void RemoveAttackItems (IAttackItems item)
        {
            Attack -= item.Attackvalue;
        }

        public void AddDefensiveItems (IDefensiveItems item)
        {
                Health += item.Defensevalue;
        }

        public void RemoveDefensiveItems (IDefensiveItems item)
        {
                Health -= item.Defensevalue;
        }

        public void Heal (ICharacter character)
        {
            Health = Health + 20;
        }

        public void CastAttackSpell (IAttackSpells spellname, SpellBook spellbook , ICharacter character)
        {
            int spellvalue = spellbook.SpellInSpellBook (spellname);
            character.Health -= spellvalue;
        }

        public void CastDefensiveSpell (IDefensiveSpells spellname, SpellBook spellbook , ICharacter character)
        {
            int spellvalue = spellbook.SpellInSpellBook (spellname);
            character.Health += spellvalue;
        }
    }
}