using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha2
{
    public class Protagonist : Biped
    {
        public int Bandage = 5, MaxHP = 20, MaxAmmo = 20;
        public Protagonist(string name, int attack, int hp, int ammo, int grenades) : base(name, attack, hp, ammo, grenades)
        {

        }
        public void LevelUp()
        {
            Console.WriteLine("Level up! +5 HP, +2 Attack! Improved bandage healing by 3!");
            Attack += 2;
            HP += 10;
            Bandage += 3;
            MaxHP += 5;
        }
        public virtual void SemiAuto(Alien target)
        {
            target.HP -= Attack;
            this.Ammo -= 1;
        }
        public virtual void FullAuto(Alien target)
        {
            target.HP -= (Attack * 2);
            this.Ammo -= 5;
        }
        public virtual void Buttstroke(Alien target)
        {
            target.HP -= (Attack / 2);
        }
        public virtual void Grenade(Alien target)
        {
            target.HP -= (Attack * 5);
            this.Grenades -= 1;
        }
        public virtual void Reload()
        {
            this.Ammo += 10;
        }
        public virtual void Bandaging()
        {
            HP += Bandage;
            if (HP > MaxHP)
            {
                HP = MaxHP;
            }
        }
        public int Choice()
        {
            bool correctInput = true;
            int choice = 0;
            while (correctInput)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Engage in Semi Auto");
                Console.WriteLine("2. Engage in Full Auto");
                Console.WriteLine("3. Buttstroke");
                Console.WriteLine("4. Frag Out!");
                Console.WriteLine("5. Reload");
                Console.WriteLine("6. Bandage Your Wounds");

                bool test = int.TryParse(Console.ReadLine(), out choice);
                if (!test || choice > 6 || choice <= 0)
                {
                    Console.WriteLine("Not an option, try again!");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }
                if (choice == 1 || choice == 2 || choice == 3 || choice == 4 || choice == 5 || choice == 6)
                {
                    break;
                }
            }
            return choice;
        }
        public void YourTurn(int decision, Alien target)
        {
            if (decision == 1)
            {
                if (this.Ammo > 0)
                {
                    Console.WriteLine("Pew!");
                    SemiAuto(target);
                }
                else
                {
                    Console.WriteLine("Empty mag, reloading!");
                    Reload();
                }
            }
            if (decision == 2)
            {
                if (this.Ammo > 0)
                {
                    Console.WriteLine("Pew Pew Pew!");
                    FullAuto(target);
                }
                else
                {
                    Console.WriteLine("Empty mag, reloading!");
                    Reload();
                }
            }
            if (decision == 3)
            {
                Console.WriteLine("Buttstroke!");
                Buttstroke(target);
            }
            if (decision == 4)
            {
                if (this.Grenades > 0)
                {
                    Console.WriteLine("Frag out!");
                    Grenade(target);
                }
                else
                {
                    Console.WriteLine("No grenades to throw! Buttstroking instead!");
                    Buttstroke(target);
                }

            }
            if (decision == 5)
            {
                Console.WriteLine("Cover me, I'm reloding!");
                Reload();
            }
            if (decision == 6)
            {
                Console.WriteLine("I need to wrap these wounds...");
                Bandaging();
            }
        }
    }
}
