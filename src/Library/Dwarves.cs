using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace RoleplayGame 
{
    public class Dwarves
    {
        public int Health { get; set; } = 150;
        public int Attack { get; set; } = 25;

        public void AttackWizard(Wizard wizard)
        {
            wizard.Health -= Attack;
        }
        public void AttackElf(Elf elf)
        {
            elf.Health -= Attack;
        }
    }
}