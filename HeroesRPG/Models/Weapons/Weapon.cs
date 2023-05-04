using Heroes.Models.Contracts;
namespace HeroesRPG.Models.Weapons
{
    public abstract class Weapon : IWeapon
    {
        private string name;
        private int durability;
        private int damage;

        public Weapon(string name, int durability, int damage)
        {
            Name = name;
            Durability = durability;
            Damage = damage; 
        }


        public string Name
        {
            get => name;
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Weapon type cannot be null or empty.");
                }
                name = value;
            }
        }

        public int Durability
        {
            get => durability;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Durability cannot be below 0.");
                }


                durability = value;
            }
        }

        private int Damage
        {
            get => this.damage;
            set
            {
                if(value < 0) 
                {
                    throw new ArgumentException("Damage cannot be below 0.");
                }
                this.damage = value;
            }
        }

        public int DoDamage()
        {
            this.Durability--;

            if(this.Durability == 0)
            {
                return 0;
            }
            return this.Damage;
        }
    }
}
