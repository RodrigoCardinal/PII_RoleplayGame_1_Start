using System;
using System.Collections.Generic;

namespace RoleplayGame
{
    public class SpellBook
    {
        Dictionary <ISpells , int> spellbook = new Dictionary <ISpells, int> ();

    public SpellBook ()
    {
        Fireball fireball = new Fireball ();
        Thunder thunder = new Thunder ();
        Earthquake earthquake = new Earthquake ();
        Snowstorm snowstorm = new Snowstorm ();
        HealAlly healally = new HealAlly ();

        spellbook.Add (fireball , fireball.Attackvalue);
        spellbook.Add (thunder , thunder.Attackvalue);
        spellbook.Add (earthquake , earthquake.Attackvalue);
        spellbook.Add (snowstorm , snowstorm.Attackvalue);
        spellbook.Add (healally , healally.Defensevalue);
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