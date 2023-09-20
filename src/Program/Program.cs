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
            


            elfo.AddAttackItems(Sword);
            elfo.AddDefenseItems (HeavyArmor);
            elfo.GetHealth(Elf);
            elfo.GetAttack (Elf);
            elfo.AttackCharacter(Wizard);

            mago.Heal(Wizard);
            mago.CastSpell ("Fireball" , libro);
            mago.GetAttack(Wizard);
            mago.AttackElf (Elf);
            mago.AddDefenseItems(LightArmor);
            elfo.GetHealth(Elf);

        }
    }
}
 