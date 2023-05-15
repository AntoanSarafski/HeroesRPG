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

        protected Hero(string name, int health, int armour)
        {
            Name = name;
            Health = health;
            Armour = armour;
        }
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

        public int Health
        {
            get => health;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Hero health cannot be below 0.");
                }
                health = value;
            }
        }

        public int Armour
        {
            get => armour;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Hero armour cannot be below 0.");
                }
                armour = value;
            }
        }

        public IWeapon Weapon
        {
            get => weapon;
            private set
            {
                if (value == null)
                {
                    throw new ArgumentException("Weapon cannot be null.");
                }
                weapon = value;
            }
        }

        public bool IsAlive
        {
            get => isAlive;
            private set
            {
                if (Health > 0)
                {
                    isAlive = true;
                }
                else
                {
                    isAlive = false;
                }
            }
        }

        public void AddWeapon(IWeapon weapon)
        {
            Weapon = weapon;
        }

        public void TakeDamage(int points)
        {
            var armourLeft = this.Armour - points;

            if (armourLeft > 0)
            {
                this.Armour = armourLeft;
            }

            else
            {
                this.Armour = 0;

                var damage = -armourLeft;

                var healthLeft = this.Health - damage;

                if (healthLeft < 0)
                {
                    this.Health = 0;
                }
                else
                {
                    this.Health = healthLeft;
                }
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.AppendLine($"{this.GetType().Name}: {this.Name}");
            result.AppendLine($"--Health: {this.Health}");
            result.AppendLine($"--Armour: {this.Armour}");
            result.AppendLine($"--Weapon: {(this.Weapon == null ? "Unarmed" : this.Weapon.Name)}");

            return result.ToString();
        }
    }
}
