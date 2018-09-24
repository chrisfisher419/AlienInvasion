using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha2
{
    public class AutomaticRifleman : Biped
    {
        public AutomaticRifleman(string name, int attack, int hp, int ammo, int grenades) : base(name, attack, hp, ammo, grenades)
        {

        }
        public AutomaticRifleman(string name) : base(name)
        {

        }
        public virtual void SlayBodies(string name)
        {
            Console.WriteLine($"{name}: Alright, I'm dumping everything into them! Die!!");
        }
        
    }
}
