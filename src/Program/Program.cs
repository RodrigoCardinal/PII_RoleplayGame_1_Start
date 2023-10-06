
using System;
using RoleplayGame;
using System.Collections.Generic;


namespace Program
{
    class Program
    {
        static void Main (string [] args)
        {
            IHero hero1 = new Dwarf("Gimli");
            IHero hero2 = new Elf("Legolas");
          
            IEnemy enemy1 = new DarkWizardEnemy("Saruman");
            IEnemy enemy2 = new KnightEnemy("JhonSouls");
    

            List<IHero> heroes = new List<IHero> { hero1, hero2 };

            List<IEnemy> enemies = new List<IEnemy> { enemy1, enemy2 };

    
            Encounter encounter = new Encounter(heroes, enemies);
            encounter.DoEncounter();

            Console.WriteLine("Resultados del encuentro:");

        }
    }
}
