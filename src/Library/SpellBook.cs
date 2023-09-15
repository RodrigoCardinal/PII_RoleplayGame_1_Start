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
    public int SpellInSpellBook (string spellname)
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