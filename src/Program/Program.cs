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
            Shield escudo = new Shield();
            HeavyArmor armadurapesada = new HeavyArmor ();
            LightArmor armaduraliviana = new LightArmor ();


            elfo.AddSword (espada);
            elfo.AddHeavyArmor (armadurapesada);
            elfo.GetHealth(elfo);
            elfo.RemoveHeavyArmor(armadurapesada);
            elfo.GetAttack (elfo);
            elfo.AttackDwarves (enano);
            
            enano.GetHealth (enano);
            enano.Heal (enano);
            enano.GetHealth (enano);
            enano.AddAxe (hacha);
            enano.AttackWizard (mago);
            enano.RemoveAxe(hacha);
            enano.GetAttack(enano);
            enano.AddShield(escudo);
            enano.AddLightArmor(armaduraliviana);


            mago.Heal (mago);
            mago.CastSpell ("Fireball" , libro);
            mago.GetAttack (mago);
            mago.AttackElf (elfo);
            mago.AddLightArmor(armaduraliviana);

            elfo.GetHealth (elfo);

        }
    }
}
 