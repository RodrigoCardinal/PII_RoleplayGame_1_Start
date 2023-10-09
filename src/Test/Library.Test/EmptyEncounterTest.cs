using RoleplayGame;
using System.Collections.Generic;
using NUnit.Framework;

namespace Test.Library
{
    public class EmptyEncounterTest
    {
        [Test]
        public void EmptyEncounter()
        {
            IHero hero1 = new Dwarf("Gimli");
            var heroes = new List<IHero> { hero1 };
            var enemies = new List<IEnemy> { };
            var encounter = new Encounter(heroes, enemies);
            encounter.DoEncounter();

             Assert.AreEqual(0, enemies.Count);

        }
    }
}

