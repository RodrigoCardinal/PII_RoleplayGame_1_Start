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
            Sword Espada = new Sword ();
            HeavyArmor ArmaduraPesada = new HeavyArmor();
            LightArmor ArmaduraLigera = new LightArmor();


            elfo.AddAttackItems(Espada);
            elfo.AddDefensiveItems (ArmaduraPesada);
            elfo.GetHealth(elfo);
            elfo.GetAttack (elfo);
            elfo.AttackCharacter(mago);

            mago.Heal(mago);
            mago.CastSpell ("Fireball" , libro);
            mago.GetAttack(mago);
            mago.AttackCharacter (elfo);
            mago.AddDefensiveItems(ArmaduraLigera);
            elfo.GetHealth(elfo);

        }
    }
}
 