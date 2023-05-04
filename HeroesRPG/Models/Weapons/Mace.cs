using System;
using static System.Net.Mime.MediaTypeNames;

namespace HeroesRPG.Models.Weapons
{
    public class Mace : Weapon
    {
        private int maceDamage = 25;
        public Mace(string name, int durability, int damage) 
            : base(name, durability, 25)
        {
        }
    }
}
