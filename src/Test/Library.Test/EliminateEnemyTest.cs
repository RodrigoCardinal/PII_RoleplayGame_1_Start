using RoleplayGame;
using System.Collections.Generic;
using NUnit.Framework;

namespace Test.Library
{
    public class EliminateEnemyTest
    {
        [Test]
        public void EliminateEnemy()
        {
            IHero hero1 = new Dwarf("Gimli");
            IHero hero2 = new Elf("Legolas");
            IEnemy enemy1 = new DarkWizardEnemy("Saruman");
            var heroes = new List<IHero> { hero1, hero2 };
            var enemies = new List<IEnemy> { enemy1 };
            var encounter = new Encounter(heroes, enemies);
            encounter.DoEncounter();

             Assert.AreEqual(0, enemies.Count);

        }
    }
}