using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha2
{
    public class Biped
    {
        public string Name { get; set; }
        public int HP { get; set; }
        public int Attack { get; set; }
        public int Ammo { get; set; }
        public int Grenades { get; set; }



        public Biped(string name, int attack, int hp, int ammo, int grenades)
        {
            Name = name;
            Attack = attack;
            HP = hp;
            Ammo = ammo;
            Grenades = grenades;
        }
        public Biped(string name)
        {

        }

        public virtual void PrintStats()
        {
            Console.WriteLine($"{Name} stats: ");
            Console.WriteLine($"Current HP is {HP}, current Attack is {Attack}, current round count is {Ammo}, current grenade count is {Grenades}");
        }
        public virtual void Introduce(string name)
        {
            Console.WriteLine($"I am {name}");
            Console.ReadLine();
        }
        public virtual void Shoot(string name)
        {
            Ammo -= 5;
            Console.WriteLine($"{name}: I am engaging with suprressive fire! My current round count is {Ammo}");
            Console.ReadLine();
            
        }
        public virtual void StandFast(string name)
        {
            Console.WriteLine($"{name}: Hold fast, I will lay down heavy suprresing fire!");
            Ammo -= 10;
        }
        public virtual void CoverAndMove(string name)
        {
            Console.WriteLine($"{name}: Cover and move!");
            Console.ReadLine();
            Ammo -= 5;
        }
        public virtual void Grenade(string name)
        {
            Grenades -= 1;
            Console.WriteLine($"{name}: Frag out! I have {Grenades} grenades left!");
        }

    }
}
