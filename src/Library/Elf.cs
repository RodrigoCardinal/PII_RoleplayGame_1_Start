using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace RoleplayGame 
{
    public class Elf
    {
        public int Health { get; set; } = 100;
        public int Attack { get; set; } = 10;

        public void AttackWizard(Wizard attack)
        {
            attack.Health -= Attack;
        }

    }
}