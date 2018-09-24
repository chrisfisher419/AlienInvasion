using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha2
{
    class Battle
    {
        public static void AreYouDead(Protagonist protagonist)
        {
            if (protagonist.HP <= 0)
            {
                Console.WriteLine("You died....and they're eating your body...and your friends....and all is doomed, good try though");
                Console.WriteLine("Closing session");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }
        public static void IsVehicleDestroyed(Humvee humvee)
        {
            if (humvee.Hull <= 0)
            {
                Console.WriteLine("Your vehicle has been destroyed...you die in the fiery explosion...");
                Console.WriteLine("Closing session...");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }
        public static void Stats(Biped biped1, Biped biped2)
        {
            biped1.PrintStats();
            Console.WriteLine("");
            biped2.PrintStats();
            Console.WriteLine("");
        }
        public static void WithXenomorph(Protagonist protagonist, Xenomorph xenomorph)
        {
            while (xenomorph.HP > 0 && protagonist.HP > 0)
            {
                Stats(xenomorph, protagonist);
                protagonist.YourTurn(protagonist.Choice(), xenomorph);

                if (xenomorph.HP > 0)
                {
                    xenomorph.XenomorphTurn(xenomorph.EChoice(), protagonist);
                    AreYouDead(protagonist);
                }
            }
            Console.WriteLine("{0} was killed!", xenomorph.Name);
            Console.ReadLine();
            Console.Clear();
        }

        public static void WithQueen(Protagonist protagonist, Queen queen)
        {
            while (queen.HP > 0 && protagonist.HP > 0)
            {
                Stats(queen, protagonist);
                protagonist.YourTurn(protagonist.Choice(), queen);

                if (queen.HP > 0)
                {
                    queen.QueenTurn(queen.EChoice(), protagonist);
                    AreYouDead(protagonist);
                }
            }
            Console.WriteLine("{0} was killed!", queen.Name);
            Console.ReadLine();
            Console.Clear();
        }

        public static void WithBanshee(Humvee humvee, Banshee banshee)
        {
            while (banshee.HP > 0 && humvee.Hull > 0)
            {
                humvee.YourTurn(humvee.Choice(), banshee);

                if (banshee.HP > 0)
                {
                    banshee.BansheeTurn(banshee.EChoice(), humvee);
                    IsVehicleDestroyed(humvee);
                }
            }
            Console.WriteLine("{0} was destroyed!", banshee.Name);
            Console.ReadLine();
            Console.Clear();
        }

    }
}
