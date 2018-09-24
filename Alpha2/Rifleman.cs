using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha2
{
    public class Rifleman : Biped
    {
        public Rifleman(string name, int attack, int hp, int ammo, int grenades) : base(name, attack, hp, ammo, grenades)
        {

        }
        public Rifleman(string name) : base(name)
        {

        }
    }
}
