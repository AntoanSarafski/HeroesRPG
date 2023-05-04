using System;
using static System.Net.Mime.MediaTypeNames;

namespace HeroesRPG.Models.Weapons
{
    public class Mace : Weapon
    {
        private const int DAMAGE = 25;
        public Mace(string name, int durability) 
            : base(name, durability, DAMAGE)
        {
        }
    }
}
