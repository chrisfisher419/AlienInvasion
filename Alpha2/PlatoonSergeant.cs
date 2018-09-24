using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha2
{
    public class PlatoonSergeant : Biped
    {
        public PlatoonSergeant(string name, int attack, int hp, int ammo, int grenades) : base(name, attack, hp, ammo, grenades)
        {

        }
        public PlatoonSergeant(string name) : base(name)
        {

        }
    }
}
