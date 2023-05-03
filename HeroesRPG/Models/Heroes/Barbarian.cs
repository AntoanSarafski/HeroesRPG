using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesRPG.Models.Heroes
{
    public class Barbarian : Hero
    {
        public Barbarian(string name, int health, int armour) 
            : base(name, health, armour)
        {
        }
    }
}
