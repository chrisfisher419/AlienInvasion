using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha2
{
    public class Alien : Biped
    {
        public int numOfAttack { get; set; }
        public Alien(string name, int attack, int hp, int ammo, int grenades) : base (name, attack, hp, ammo, grenades)
        {

        }

        public int EChoice()
        {
            int eChoice;
            Random ran = new Random();
            eChoice = ran.Next(1, numOfAttack + 1);
            return eChoice;
        }
    }
    public class Xenomorph : Alien
    {
        public Xenomorph(string name, int attack, int hp, int ammo, int grenades) : base ( name, attack, hp, ammo, grenades)
        {
            numOfAttack = 3;
        }
        public virtual void Shoot(Protagonist target)
        {
            target.HP -= Attack - 2;
        }
        public virtual void AcidSpray(Protagonist target)
        {
            target.HP -= Attack + 2;
        }
        public virtual void Bite(Protagonist target)
        {
            target.HP -= (Attack * 2) - 3;
        }
        public void XenomorphTurn(int choice, Protagonist target)
        {
            if (choice == 1)
            {
                Shoot(target);
                Console.WriteLine("You've been shot! It burns!");
            }
            if (choice == 2)
            {
                AcidSpray(target);
                Console.WriteLine("It spat acid at you, ouch!");
            }
            if (choice == 3)
            {
                Bite(target);
                Console.WriteLine("It took a big chomp out of you, but it's just a flesh wound!");
            }
            Console.ReadLine();
            Console.Clear();
        }
    }
    public class Queen : Alien
    {
        public Queen(string name, int attack, int hp, int ammo, int grenades) : base(name, attack, hp, ammo, grenades)
        {
            numOfAttack = 3;
        }
        public virtual void Shoot(Protagonist target)
        {
            target.HP -= Attack;
        }
        public virtual void AcidSpray(Protagonist target)
        {
            target.HP -= Attack + 5;
        }
        public virtual void Bite(Protagonist target)
        {
            target.HP -= (Attack * 2);
        }
        public void QueenTurn(int choice, Protagonist target)
        {
            if (choice == 1)
            {
                Shoot(target);
                Console.WriteLine("You've been shot! It burns!");
            }
            if (choice == 2)
            {
                AcidSpray(target);
                Console.WriteLine("It spat acid at you, ouch!");
            }
            if (choice == 3)
            {
                Bite(target);
                Console.WriteLine("It took a big chomp out of you, but it's just a flesh wound!");
            }
            Console.ReadLine();
            Console.Clear();
        }
    }
    public class Banshee : Alien
    {
        public Banshee(string name, int attack, int hp, int ammo, int grenades) : base(name, attack, hp, ammo, grenades)
        {
            numOfAttack = 3;
        }
        public virtual void Shoot(Humvee target)
        {
            target.Hull -= Attack;
        }
        public virtual void Ram(Humvee target)
        {
            target.Hull -= Attack + 5;
        }
        public virtual void Missile(Humvee target)
        {
            target.Hull -= (Attack * 2);
        }
        public void BansheeTurn(int choice, Humvee target)
        {
            if (choice == 1)
            {
                Shoot(target);
                Console.WriteLine("You've been shot!");
            }
            if (choice == 2)
            {
                Ram(target);
                Console.WriteLine("It rammed into you!");
            }
            if (choice == 3)
            {
                Missile(target);
                Console.WriteLine("It fired a missile, that will do a lot of damage!");
            }
            Console.ReadLine();
            Console.Clear();
        }
    }
}
