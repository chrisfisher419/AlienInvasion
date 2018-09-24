using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha2
{
    public class Vehicles
    {

        public string Name { get; set; }
        public int Hull { get; set; }
        public int Attack { get; set; }
        public int Ammo { get; set; }
        public int Grenades { get; set; }



        public Vehicles(string name, int attack, int hull, int ammo, int grenades)
        {
            Name = name;
            Attack = attack;
            Hull = hull;
            Ammo = ammo;
            Grenades = grenades;
        }

        public virtual void PrintStats()
        {
            Console.WriteLine($"{Name} stats: ");
            Console.WriteLine($"Current HP is {Hull}, current Attack is {Attack}, current round count is {Ammo}, current grenade count is {Grenades}");
        }
        public virtual void Drive(string name)
        {
            Name = name;
            Console.WriteLine($"The {name} is driving");
        }
    }
}
