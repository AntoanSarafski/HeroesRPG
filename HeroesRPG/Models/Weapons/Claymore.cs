using Heroes.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesRPG.Models.Weapons
{
    public class Claymore : Weapon
    {
        private const int DAMAGE = 20;
        public Claymore(string name, int durability) 
            : base(name, durability, DAMAGE)
        {
        }
    }
}
