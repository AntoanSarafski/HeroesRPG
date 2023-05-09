using Heroes.Models.Contracts;
using HeroesRPG.Models.Heroes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace HeroesRPG.Models.Map
{
    public class Map : IMap
    {
        public string Fight(ICollection<IHero> players)
        {
            //var knights = players
            //    .OfType<Knight>()
            //    .Where(kn => kn.IsAlive)
            //    .ToList();

            //var barbarians = players
            //    .OfType<Barbarian>()
            //    .Where(b => b.IsAlive)
            //    .ToList();

            // This is more optimal, cuz we will foreach our players list only once.

            var knights = new List<Knight>();
            var barbarians = new List<Barbarian>();

            foreach (var player in players) 
            {
                if(player.IsAlive)
                {
                    if (player.IsAlive)
                    {
                        if (player is Knight knight)
                        {
                            knights.Add(knight);
                        }
                        else if (player is Barbarian barbarian)
                        {
                            barbarians.Add(barbarian);
                        }
                        else
                        {
                            throw new ArgumentException("Invalid hero type.");
                        }
                    }
                }
            }

            var continueBattle = true;

            while (continueBattle)
            {
                var allKnightsAreDead = true;
                var allBarbariansAreDead = true;
                foreach (var knight in knights)
                {
                    if (knight.IsAlive)
                    {
                        allKnightsAreDead = false;

                        foreach(var barbarian in barbarians)
                        {
                            var weaponDamage = knight.Weapon.DoDamage();
                            barbarian.TakeDamage(weaponDamage);
                        }
                    }
                }

                foreach (var barbarian in barbarians)
                {
                    if (barbarian.IsAlive)
                    {
                        allBarbariansAreDead = false;

                        foreach (var knight in knights)
                        {
                            var weaponDamage = barbarian.Weapon.DoDamage();

                            knight.TakeDamage(weaponDamage);
                        }
                    }
                }
            }
        }
    }
}
