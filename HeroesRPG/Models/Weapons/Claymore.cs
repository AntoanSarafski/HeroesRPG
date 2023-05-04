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
        private int claymoreDamage = 20;
        public Claymore(string name, int durability) 
            : base(name, durability, 20)
        {
        }
    }
}
