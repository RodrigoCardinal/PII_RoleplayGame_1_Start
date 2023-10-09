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
            var heroes = new List<IHero> { };
            var enemies = new List<IEnemy> { };
            var encounter = new Encounter(heroes, enemies);
            encounter.DoEncounter();

             Assert.AreEqual(0, enemies.Count);
             Assert.AreEqual(0, heroes.Count);

        }
    }
}

