using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

namespace RoleplayGame
{
    public class Wizard : CharacterBase
    {
        public Wizard(string name)
        {
            Name = name;
            Health = 125;
            Attack = 15;
        }

        public void CastAttackSpell(IAttackSpells spell, SpellBook spellbook, ICharacter character)
        {
            int spellValue = spellbook.SpellInSpellBook(spell);
            character.Health -= spellValue;
        }

        public void CastDefenseSpell(IDefensiveSpells spell, SpellBook spellbook, ICharacter character)
        {
            int spellValue = spellbook.SpellInSpellBook(spell);
            character.Health += spellValue;
        }
    }
}