using Heroes.Core.Contracts;
using Heroes.Models.Contracts;
using Heroes.Repositories.Contracts;
using HeroesRPG.Models.Heroes;
using HeroesRPG.Models.Weapons;
using HeroesRPG.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes.Core
{
    public class Controller : IController
    {
        private readonly IRepository<IHero> heroes;
        private readonly IRepository<IWeapon> weapons;

        public Controller()
        {
            heroes = new HeroRepository();
            weapons = new WeaponRepository();
        }

        public string CreateHero(string type, string name, int health, int armour)
        {
            if (heroes.FindByName(name) != null)
            {
                throw new InvalidOperationException($"The hero {name} already exists.");
            }

            IHero hero = type switch
            {
                nameof(Barbarian) => new Barbarian(name, health, armour),
                nameof(Knight) => new Knight(name, health, armour),
                _ => throw new InvalidOperationException("Invalid hero type.")
            };

            heroes.Add(hero);

            var heroAlias = type == nameof(Knight)
                ? $"Sir {hero.Name}"
                : $"{nameof(Barbarian)} {hero.Name}";

            return $"Successfully added {heroAlias} to the collection.";
        }


        public string CreateWeapon(string type, string name, int durability)
        {
            if (weapons.FindByName(name) != null)
            {
                throw new InvalidOperationException($"The weapon {name} already exist.");
            }
            IWeapon weapon = type switch
            {
                nameof(Mace) => new Mace(name, durability),
                nameof(Claymore) => new Claymore(name, durability),
                _ => throw new InvalidOperationException("Invalid weapon type.")
            };
            weapons.Add(weapon);

            return $"A {type.ToLower()} {name} is added to the collection.";
        }


        public string AddWeaponToHero(string weaponName, string heroName)
        {

            if (heroes.FindByName(heroName) == null)
            {
                throw new InvalidOperationException($"Hero {heroName} does not exist.");
            }
            if(weapons.FindByName(weaponName) == null)
            {
                throw new InvalidOperationException($"Weapon {weaponName} does not exist.");
            }
        }

        


        public string HeroReport()
        {
            throw new NotImplementedException();
        }

        public string StartBattle()
        {
            throw new NotImplementedException();
        }
    }
}
