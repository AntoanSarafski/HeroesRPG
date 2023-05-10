using Heroes.Models.Contracts;
using Heroes.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesRPG.Repositories
{
    public class WeaponRepository : IRepository<IWeapon>
    {
        private readonly Dictionary<string, IWeapon> _weapons;
        public IReadOnlyCollection<IWeapon> Models => _weapons.Values;

        public void Add(IWeapon model)
        {
            _weapons.Add(model.Name, model);
        }


        public bool Remove(IWeapon model)
        {
            if (_weapons.ContainsKey(model.Name))
            {
                _weapons.Remove(model.Name);
                return true;
            }
            return false;
        }


        public IWeapon FindByName(string name)
        {
            if (_weapons.ContainsKey(name))
            {
                return _weapons[name];
            }
            return null;
        }

    }
}
