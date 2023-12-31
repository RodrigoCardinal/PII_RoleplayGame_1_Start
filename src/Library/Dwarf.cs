using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace RoleplayGame 
{
    public class Dwarf : CharacterBase, IHero
    {
        public Dwarf(string name)
        {
            Name = name;
            Health = 175;
            Attack = 25;
        }

        public int VictoryPoints { get; private set; }

        public void AccumulateVictoryPoints(int points)
        {
            VictoryPoints += points;
        }
    }
}