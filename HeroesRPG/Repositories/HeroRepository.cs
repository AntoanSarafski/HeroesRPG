using Heroes.Models.Contracts;
using Heroes.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesRPG.Repositories
{
    public class HeroRepository : IRepository<IHero>
    {
        private readonly Dictionary<string, IHero> _heroes;

        public IReadOnlyCollection<IHero> Models => _heroes.Values;

        public void Add(IHero model)
            => _heroes.Add(model.Name, model);

        public bool Remove(IHero model)
        {
            if (!_heroes.ContainsKey(model.Name)) return false;
            else
            {
                _heroes.Remove(model.Name);
                return true;
            }
        }


        public IHero FindByName(string name)
        {
            
        }

   
    }
}
