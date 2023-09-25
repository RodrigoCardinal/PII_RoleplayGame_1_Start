using System;
using System.Collections.Generic;

namespace RoleplayGame
{
    public class SpellBook
    {
        Dictionary <ISpells , int> spellbook = new Dictionary <ISpells, int> ();

        public void AddSpell (ISpells spell , int value)
        {
            spellbook.Add (spell , value);
        }

        public void RemoveSpell (ISpells spell)
        {
            spellbook.Remove (spell);
        }

    public int SpellInSpellBook (ISpells spellname)
    {
        if (spellbook.ContainsKey (spellname))
        {
            return spellbook [spellname];
        }
        else
        {
            return 0;
        }
    }
    }
}