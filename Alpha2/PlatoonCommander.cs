using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha2
{
    public class PlatoonCommander : Biped
    {
        public PlatoonCommander(string name, int attack, int hp, int ammo, int grenades) : base(name, attack, hp, ammo, grenades)
        {

        }
        public PlatoonCommander(string name) : base(name)
        {
            
        }
    }
}
