using System;
using System.Collections.Generic;

namespace RoleplayGame
{
    public class SpellBook
    {
        Dictionary <string , int> spellbook = new Dictionary <string, int> ();

    public SpellBook ()
    {
        spellbook.Add ("Fireball" , 10);
        spellbook.Add ("Thunder" , 5);
        spellbook.Add ("Earthquake" , 20);
        spellbook.Add ("Snowstorm" , 15);
    }
    public int GetSpellValue(string spellName)
    {
        if (spellbook.ContainsKey(spellName))
        {
            return spellbook[spellName];
        }
        else
        {
            return 0;

        }
    }
    }
}