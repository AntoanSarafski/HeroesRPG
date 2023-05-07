using Heroes.Models.Contracts;
using HeroesRPG.Models.Heroes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                            throw new ArgumentException("Invalid player type.");
                        }
                    }
                }
            }
        }
    }
}
