using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace RoleplayGame 
{
    public class Elf
    {
        public int Health { get; set; }
        public int Attack { get; set; }
        
        public void Stats
        {
            this.Health = 70
            this.Attack = 50
        }
    }
}