using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//SEE README.CS TO READ ALL COMMENTS/NOTES

namespace Alpha2 //THIS PROGRAM IS A MILITARY TRAINING SIMULATION
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the military's alien invasion simulator! Impending doom is soon if we aren't prepared. This unit was designed by the DoD to simulate what they believe our future alien invasion scenario to be!");
            Console.ReadLine();
            Missions login = new Missions();
            login.Login();
        }

    }
}
