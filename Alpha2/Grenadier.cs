using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha2
{
    public class Grenadier : Biped
    {
        public Grenadier(string name, int attack, int hp, int ammo, int grenades) : base(name, attack, hp, ammo, grenades)
        {

        }
        public Grenadier(string name) : base(name)
        {

        }
    }
}
