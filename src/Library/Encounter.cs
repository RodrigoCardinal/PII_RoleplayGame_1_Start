using System;
using System.Collections.Generic;

namespace RoleplayGame
{
    public class Encounter
    {
        private List<IHero> heroes;
        private List<IEnemy> enemies;

        public Encounter(List<IHero> heroes, List<IEnemy> enemies)
        {
            this.heroes = heroes;
            this.enemies = enemies;
        }

        public void DoEncounter()
        {
            Console.WriteLine("Comienza el encuentro:");

            while (heroes.Count > 0 && enemies.Count > 0)
            {
                int TargetIndexHero = 0;
            
                //Acá es cuando atacan los enemigos
                foreach (var enemy in enemies)
                {
                    if (heroes.Count > 0)
                    {
                        // targetHero es el heroe que se va a atacar
                        IHero targetHero = heroes[TargetIndexHero];

                        int heroHealth = targetHero.GetHealth(targetHero);
                        int enemyAttack = enemy.GetAttack(enemy);

                        heroHealth -= enemyAttack;

                        if (TargetIndexHero < heroes.Count)
                        {
                        // aumento el indice para que se ataque al siguiente heroe
                        TargetIndexHero++;
                        }
                        else 
                        {
                            TargetIndexHero = 0;
                        }
                        
                    }
                }

                //Acá es cuando atacan los heroes
                foreach (var hero in heroes)
                {
                    int TargetIndexEnemy = 0;

                    if (enemies.Count > 0)
                    {
                        // targetEnemy es el heroe que se va a atacar
                        IEnemy targetEnemy = enemies[TargetIndexEnemy];

                        int enemyHealth = targetEnemy.GetHealth(targetEnemy);
                        int heroAttack = hero.GetAttack(hero);

                        enemyHealth -= heroAttack;

                        if (enemyHealth < 0)
                        {
                            hero.AccumulateVictoryPoints(targetEnemy.VictoryPoints);
                        }

                        if (TargetIndexEnemy < enemies.Count)
                        {
                        // aumento el indice para que se ataque al siguiente heroe
                        TargetIndexEnemy++;
                        }
                        else 
                        {
                            TargetIndexEnemy = 0;
                        }
                        
                    }
                }
            }

            Console.WriteLine("Fin del encuentro.");
        }
    }
}
