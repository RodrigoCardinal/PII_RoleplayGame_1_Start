using RoleplayGame;
using System.Collections.Generic;
using NUnit.Framework;

namespace Test.Library
{
    public class EliminateHeroTest
    {
        [Test]
        public void EliminateHero()
        {
            IHero hero1 = new Dwarf("Muerto1");
            IEnemy enemy1 = new DarkWizardEnemy("Mago");
            IEnemy enemy2 = new DarkWizardEnemy("Mago2");
            IEnemy enemy3 = new DarkWizardEnemy("Mago3");
            IEnemy enemy4 = new DarkWizardEnemy("Mago4");
            var heroes = new List<IHero> { hero1, };
            var enemies = new List<IEnemy> { enemy1, enemy2, enemy3, enemy4,};
            var encounter = new Encounter(heroes, enemies);
            encounter.DoEncounter();

             Assert.AreEqual(0, heroes.Count);

        }
    }
}