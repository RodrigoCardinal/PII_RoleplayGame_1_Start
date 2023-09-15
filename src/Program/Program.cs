using System;
using RoleplayGame;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Elf elfo = new Elf ("Elfo de prueba");
            Wizard mago = new Wizard ("Mago de prueba");
            Dwarf enano = new Dwarf ("Enano de prueba");
            SpellBook libro = new SpellBook ();
            Sword espada = new Sword ();
            Axe hacha = new Axe ();
            HeavyArmor armadurapesada = new HeavyArmor ();

            elfo.AddSword (espada);
            elfo.AddHeavyArmor (armadurapesada);
            elfo.GetAttack (elfo);
            elfo.AttackDwarves (enano);
            
            enano.GetHealth (enano);
            enano.Heal (enano);
            enano.GetHealth (enano);
            enano.AddAxe (hacha);
            enano.AttackWizard (mago);

            mago.Heal (mago);
            mago.CastSpell ("Fireball" , libro);
            mago.GetAttack (mago);
            mago.AttackElf (elfo);

            elfo.GetHealth (elfo);
        }
    }
}
 