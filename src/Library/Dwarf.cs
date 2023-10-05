using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace RoleplayGame 
{
    public class Dwarf : CharacterBase
    {
        public Dwarf(string name)
        {
            Name = name;
            Health = 175;
            Attack = 25;
        }
    }
}