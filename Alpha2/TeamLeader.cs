using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha2
{
    public class TeamLeader : Biped
    {
        public TeamLeader(string name, int attack, int hp, int ammo, int grenades) : base(name, attack, hp, ammo, grenades)
        {

        }
        public TeamLeader(string name) : base(name)
        {

        }
    }
}
