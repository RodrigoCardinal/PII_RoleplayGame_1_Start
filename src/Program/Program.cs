
using System;
using RoleplayGame;

namespace Program
{
    class Program
    {
        static void Main (string [] args)
        {
            Elf elfo = new Elf ("Elfo de prueba");
            Wizard mago = new Wizard ("Mago de prueba");
            Dwarf enano = new Dwarf ("Enano de prueba");
            
            SpellBook libro = new SpellBook ();
            Fireball fireball = new Fireball ();
            Thunder thunder = new Thunder ();
            Earthquake earthquake = new Earthquake ();
            Snowstorm snowstorm = new Snowstorm ();
            HealAlly healally = new HealAlly ();

            libro.AddSpell (fireball , fireball.Attackvalue);
            libro.AddSpell (thunder , thunder.Attackvalue);
            libro.AddSpell (earthquake , earthquake.Attackvalue);
            libro.AddSpell (snowstorm , snowstorm.Attackvalue);
            libro.AddSpell (healally , healally.Defensevalue);
            
            Sword espada = new Sword ();
            HeavyArmor armadurapesada = new HeavyArmor ();
            LightArmor armaduraligera = new LightArmor ();

            elfo.AddAttackItem (espada);
            elfo.AddDefensiveItem (armadurapesada);
            Console.WriteLine($"Elfo: Salud={elfo.GetHealth(elfo)}, Ataque={elfo.GetAttack(elfo)}");
            elfo.AttackCharacter (mago);

            mago.Heal (mago);
            mago.CastAttackSpell (fireball , libro , elfo);
            Console.WriteLine($"Mago: Salud={mago.GetHealth(mago)}, Ataque={mago.GetAttack(mago)}");
            mago.AttackCharacter (elfo);
            mago.AddDefensiveItem (armaduraligera);
            Console.WriteLine($"Elfo: Salud={elfo.GetHealth(elfo)}");
        }
    }
}
