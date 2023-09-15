using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

namespace RoleplayGame
{   
    public class Wizard
    {
        public string Name {get;set;}
        public int Health {get;set;}
        public int Attack=10;

        public void AttackElf(Elf elf)
        {
            elf.Health-=Attack;
        }

        public void AttackDwarves(Dwarves Dwarve)
        {
            Dwarve.Health-=Attack;
        }
    }
}