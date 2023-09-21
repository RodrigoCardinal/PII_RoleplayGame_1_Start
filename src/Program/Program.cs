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
            HealAlly healally = new HealAlly ();
            
            Sword espada = new Sword ();
            HeavyArmor armadurapesada = new HeavyArmor ();
            LightArmor armaduraligera = new LightArmor ();

            elfo.AddAttackItems (espada);
            elfo.AddDefensiveItems (armadurapesada);
            elfo.GetHealth (elfo);
            Console.WriteLine (mago.GetHealth (mago));
            elfo.GetAttack (elfo);
            elfo.AttackCharacter (mago);

            mago.Heal (mago);
            mago.CastAttackSpell (fireball , libro , elfo);
            Console.WriteLine (mago.GetHealth (mago));
            mago.GetAttack (mago);
            mago.AttackCharacter (elfo);
            mago.AddDefensiveItems (armaduraligera);
            elfo.GetHealth (elfo);

        }
    }
}
 