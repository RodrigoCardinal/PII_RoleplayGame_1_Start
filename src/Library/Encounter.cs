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
            if (heroes.Count == 0 || enemies.Count == 0 )
            {
              Console.WriteLine("No hay enemigos o heroes para combatir");
                return;
            }
            Console.WriteLine("Comienza el encuentro:");

            int TargetIndexHero = 0;
            int TargetIndexEnemy = 0;

            while (heroes.Count > 0 && enemies.Count > 0)
{
    Console.WriteLine("Estado actual del encuentro:");
    Console.WriteLine($"Héroes restantes: {heroes.Count}");
    Console.WriteLine($"Enemigos restantes: {enemies.Count}");

    // Acá es cuando atacan los enemigos
    foreach (var enemy in enemies)
    {
        if (heroes.Count > 0)
        {
            int targetHeroIndex = TargetIndexHero % heroes.Count; // Asegura que el índice esté dentro de los límites
            IHero targetHero = heroes[targetHeroIndex];
            int heroHealth = targetHero.GetHealth(targetHero);
            int enemyAttack = enemy.GetAttack(enemy);
            Console.WriteLine($"Enemigo ataca a héroe. Salud del héroe: {heroHealth}, Ataque del enemigo: {enemyAttack}");
            
            if (heroHealth <= 0)
            {
                heroes.Remove(targetHero);
                Console.WriteLine($"Se ha eliminado un héroe. {heroes.Count} héroes restantes.");
            }

            enemy.AttackCharacter(targetHero);

            TargetIndexHero++; // Incrementa el índice para que se ataque al siguiente héroe
        }
    }

    // Acá es cuando atacan los héroes
    foreach (var hero in heroes)
    {
        if (enemies.Count > 0)
        {
            int targetEnemyIndex = TargetIndexEnemy % enemies.Count; // Asegura que el índice esté dentro de los límites
            IEnemy targetEnemy = enemies[targetEnemyIndex];

            int enemyHealth = targetEnemy.GetHealth(targetEnemy);
            int heroAttack = hero.GetAttack(hero);
            Console.WriteLine($"Héroe ataca a enemigo. Salud del enemigo: {enemyHealth}, Ataque del héroe: {heroAttack}");

            hero.AttackCharacter(targetEnemy);

            if (enemyHealth <= 0)
            {
                hero.AccumulateVictoryPoints(targetEnemy.VictoryPoints);
                enemies.Remove(targetEnemy);
                Console.WriteLine($"Se ha eliminado un enemigo. {enemies.Count} enemigos restantes.");
            }

            TargetIndexEnemy++; // Incrementa el índice para que se ataque al siguiente enemigo
        }
    }
}
        }
    }
}
