using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha2
{
    public class Humvee : Vehicles
    {
        public Humvee(string name, int attack, int hull, int ammo, int grenades) : base(name, attack, hull, ammo, grenades)
        {

        }
        public void LevelUp()
        {
            Console.WriteLine("Level up! +10 Hull, +5 Attack! ");
            Attack += 5;
            Hull += 10;

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
        public virtual void Ram(Alien target)
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
            this.Ammo += 50;
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
                Console.WriteLine("3. Ram");
                Console.WriteLine("4. Frag out!");
                Console.WriteLine("5. Reload");

                bool test = int.TryParse(Console.ReadLine(), out choice);
                if (!test || choice > 5 || choice <= 0)
                {
                    Console.WriteLine("Not an option, try again!");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }
                if (choice == 1 || choice == 2 || choice == 3 || choice == 4 || choice == 5)
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
                    Console.WriteLine("You: Conserve your ammo, lower the rate of fire!");
                    Console.WriteLine("Gunner: Picking them off slowly!");
                    SemiAuto(target);
                }
                else
                {
                    Console.WriteLine("Gunner: Empty canister, grab me another!");
                    Reload();
                }
            }
            if (decision == 2)
            {
                if (this.Ammo > 0)
                {
                    Console.WriteLine("You: Pick up the rate of fire!");
                    Console.WriteLine("Your gunner unloads into the enemy");
                    FullAuto(target);
                }
                else
                {
                    Console.WriteLine("Gunner: Empty canister, grab me another!");
                    Reload();
                }
            }
            if (decision == 3)
            {
                Console.WriteLine("You: I'm gonna ram them!");
                Ram(target);
            }
            if (decision == 4)
            {
                if (this.Grenades > 0)
                {
                    Console.WriteLine("You: Throw a grenade!");
                    Console.WriteLine("Guner: Got it!");
                    Grenade(target);
                }
                else
                {
                    Console.WriteLine("No grenades to throw! Ramming instead!");
                    Ram(target);
                }

            }
            if (decision == 5)
            {
                Console.WriteLine("Gunner: I need a new canister!");
                Reload();
            }
        }
    }
}

