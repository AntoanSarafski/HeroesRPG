using Heroes.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesRPG.Models.Heroes
{
    public abstract class Hero : IHero
    {
        private string name;
        private int health;
        private int armour;
        private IWeapon weapon;
        private bool isAlive;

        public string Name 
        { 
            get => name;
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Hero name cannot be null or empty.");
                }
                name = value; 
            }
        }

        public int Health { get => health; private set => health = value; }

        public int Armour { get => armour; private set => armour = value; }

        public IWeapon Weapon { get => weapon; private set => weapon = value; }

        public bool IsAlive { get => isAlive; private set => isAlive = value; }


        public void AddWeapon(IWeapon weapon)
        {
            throw new NotImplementedException();
        }

        public void TakeDamage(int points)
        {
            throw new NotImplementedException();
        }
    }
}
