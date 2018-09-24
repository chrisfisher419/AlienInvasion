using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Alpha2
{
    
    public class Missions
    {
        

        string user;
        PlatoonCommander captmartin = new PlatoonCommander("Captain Martin", 100, 50, 50, 3);
        PlatoonSergeant ssgtwiggins = new PlatoonSergeant("Staff Sergeant Wiggins", 60, 50, 50, 3);
        SectionLeader ssgtsuarez = new SectionLeader("Staff Sergeant Suarez",50, 50, 50, 3);
        SquadLeader sgtfisher = new SquadLeader("Sergeant Fisher", 40, 40, 40, 3);
        TeamLeader cplblack = new TeamLeader("Corporal Black", 20, 30, 30, 3);
        Rifleman lcplbennett = new Rifleman("Lance Corporal Bennett", 10, 20, 20, 3);
        Grenadier lcplbaros = new Grenadier("Lance Corporal Baros", 10, 20, 20, 3);
        AutomaticRifleman cplinda = new AutomaticRifleman("Corporal Inda", 20, 20, 20, 3);
        Protagonist sgtkirby = new Protagonist("Sergeant Kirby", 20, 40, 40, 5);

        M16 m16 = new M16("M16", "5.56", "Semi-Automatic", "12 - 15RPM", 800, 3600);
        M4 m4 = new M4("M4", "5.56", "Semi-Automatic or Full-Automatic", "12 - 15RPM", 600, 3600);
        M27 m27 = new M27("M27", "5.56", "Semi-Automatic or Full-Automatic", "36RPM", 800, 3600);
        M69 m69 = new M69("M69", "60MM", "Grenade", "N/A", 35, 50);
        M203 m203 = new M203("M203", "40MM", "Grenade Launcher", "5 - 7RPM", 350, 400);

        Protagonist you = new Protagonist("Private Fowler", 10, 20, 20, 3);
        Humvee humvee = new Humvee("Warthog", 50, 100, 100, 10);

        Xenomorph xeno1 = new Xenomorph("Xenomorph", 5, 10, 20, 5);
        Xenomorph xeno2 = new Xenomorph("Xenomorph", 5, 10, 20, 5);
        Xenomorph xeno3 = new Xenomorph("Xenomorph", 5, 10, 20, 5);
        Xenomorph xeno4 = new Xenomorph("Xenomorph", 5, 10, 20, 5);
        Xenomorph xeno5 = new Xenomorph("Xenomorph", 5, 10, 20, 5);
        Xenomorph xeno6 = new Xenomorph("Xenomorph", 5, 10, 20, 5);
        Xenomorph xeno7 = new Xenomorph("Xenomorph", 5, 10, 20, 5);
        Xenomorph xeno8 = new Xenomorph("Xenomorph", 5, 10, 20, 5);
        Xenomorph xeno9 = new Xenomorph("Xenomorph", 5, 10, 20, 5);
        Xenomorph xeno10 = new Xenomorph("Xenomorph", 5, 10, 20, 5);

        Queen queen = new Queen("Queen", 50, 500, 500, 500);

        Banshee banshee1 = new Banshee("Banshee", 10, 30, 30, 5);
        Banshee banshee2 = new Banshee("Banshee", 10, 30, 30, 5);
        Banshee banshee3 = new Banshee("Banshee", 10, 30, 30, 5);
        Banshee banshee4 = new Banshee("Banshee", 10, 30, 30, 5);
        Banshee banshee5 = new Banshee("Banshee", 10, 30, 30, 5);
        Banshee banshee6 = new Banshee("Banshee", 10, 30, 30, 5);
        Banshee banshee7 = new Banshee("Banshee", 10, 30, 30, 5);
        Banshee banshee8 = new Banshee("Banshee", 10, 30, 30, 5);
        Banshee banshee9 = new Banshee("Banshee", 10, 30, 30, 5);
        Banshee banshee10 = new Banshee("Banshee", 10, 30, 30, 5);

        public Missions()
        {

        }

        public void Opening()
        {
                Countdown();
                WriteLine($"Hello, welcome to the training simulation, {user}! If you aren't a new comer, feel free to resume your missions by picking one of the options, however if you wish to start from the beginning, pick option 1, and you can walk through the whole training from there!");
                ReadLine();
                WriteLine("Chapter 1. Beginning");
                WriteLine("Chapter 2. Armory Visit");
                WriteLine("Chapter 3. Arrival!");
                WriteLine("Chapter 4. Retaliation");
                WriteLine("Chapter 5. Escape!");
                WriteLine("Chapter 6. A Mysterious Land");
                string input = ReadLine();

                switch (input)
                {
                    case "1":
                        GarrisonIntro();
                        break;
                    case "2":
                        Armory();
                        break;
                    case "3":
                        Defense();
                        break;
                    case "4":
                        Offense();
                        break;
                    case "5":
                        Escape();
                        break;
                    case "6":
                        AlienPlanet();
                        break;
                    default:
                        WriteLine("Invalid input, logging out");
                        ReadLine();
                        Environment.Exit(0);
                        break;

                }

        }
        public void GarrisonIntro()
        {

            WriteLine("The year is 2018, you are a young Marine stationed in Camp Lejeune");
            WriteLine("War seems far away, and you spend most of your time sitting around");
            WriteLine($"Your platoon commander is decorated war vet Captain Martin, your platoon sergeant is Staff Sergeant Wiggins, your section leader is Staff Sergeant Suarez, your squad leader is Sergeant Fisher, and your team leader is Corporal Black");
            ReadLine();
            GarrisonSceneOne();
        }
        public void GarrisonSceneOne()
        {
            WriteLine("The day finally comes... you are standing in formation when you hear your Battalion Commander announce important news");
            WriteLine("Major Jones: Gents, you may have not heard the word yet, but the folks in the Pentagon announced that there is a mysterious object heading toward the Earth....");
            WriteLine("....the estimated arrival is tomorrow afternoon, so far they haven't made any contact, but it is presumed dangerous. Tonight we are going to get everything prepped in case we get called in for anything....");
            WriteLine("....I know this seems strange, but we need to be prepared, if whatever is coming here is living, and a threat, we are the first response. Go grab some chow, all hands at the armory 1800");
            ReadLine();
            WriteLine("Wow, you never thought something like this could happen, an alien invasion? That always sounded so cool to you.");
            WriteLine($"You eat with your team at chow. Corporal Black, your team leader, is looking very anxious, he hasn't been through too much before assuming the team leader position, this kind of makes you nervous");
            WriteLine($"The rest of your team, the other rifleman Lance Corporal Bennett, the grenadier Lance Corporal Baros and the automatic rifleman Corporal Inda looks as nervous as you, you're not sure what to think..");
            ReadLine();
            WriteLine("It's 1730, time to make way over to the armory...");
            Armory();
        }
        public void Armory()
        {
            WriteLine("The good ol' armory, you've spent countless hours here doing something, now it might actually mean something");
            WriteLine("Your team stages their equipment, still being new, you look to inspect everything");
            WriteLine("What would you like to look at?");
            View();
        }
        public void View()
        {
            WriteLine("1. The M16, your weapon");
            WriteLine("2. The M4");
            WriteLine("3. The M27 IAR");
            WriteLine("4. The M203 Grenade Launcher");
            WriteLine("5. The M69 Frag Grenade");
            WriteLine("Enter anything else to continue");
            string input1 = ReadLine();

            switch (input1)
            {
                case "1":
                    m16.PrintStats();
                    ReadLine();
                    View();
                    break;
                case "2":
                    m4.PrintStats();
                    ReadLine();
                    View();
                    break;
                case "3":
                    m27.PrintStats();
                    ReadLine();
                    View();
                    break;
                case "4":
                    m203.PrintStats();
                    ReadLine();
                    View();
                    break;
                case "5":
                    m69.PrintStats();
                    ReadLine();
                    View();
                    break;
                default:
                    ArmoryTwo();
                    break;
            }


        }
        public void ArmoryTwo()
        {
            WriteLine($"It's now 0400, your platoon has been standing by at the armory, you are taking turns with Lance Corporal Baros guarding the weapons while the rest nap");
            WriteLine("Major Jones: Alright gents, everyone be alert, arrival is coming early, and it's heading straight for us! Seems they must have heard how elite we are and want to test out our fighting skills....");
            WriteLine("...well whatever the case may be, be prepared for war, arrival is in less than 30 minutes");
            WriteLine("Sergeant Fisher: Corporal Black, Get your team ready, our platoon is the main effort and our squad is combining with Yeatman's to be the assault element, conduct your PCCs and PCIs, and be prepared for anything");
            ReadLine();
            Defense();
        }
        public  void Defense()
        {
            WriteLine("The time has come, the extra terrestrial object has arrived on the base...");
            WriteLine("Ssgt Wiggins: Nothing appears to be happening yet, but hold fast gents...");
            WriteLine("Corporal Black: That thing is massive!");
            WriteLine("It seems like forever passes when you hear a very loud shriek coming from this alien object...a door appears to be opening");
            WriteLine("Suddenly a smoke covers the area, you can't see anything, and it's getting really hard to breathe...");
            WriteLine("Sergeant Fisher: Gas masks on! Quickly!");
            WriteLine("You just barely get your mask in time..you wish you rehearsed that more...");
            WriteLine("The shrieks get louder, you can now see, just a little bit, and you barely make out an image of a massive, vile looking creature, with sharp teeth, and long claws");
            WriteLine("Staff Sergeant Messick, leader of the other section tells his men to engage");
            WriteLine("Captain Martin: WAIT!");
            WriteLine("But it's too late, they've engaged fire, and the aliens start charging after them...one by one your brethren are slaughtered until there is nothing left of them.");
            WriteLine("With the entire other section gone, the aliens lay their sights on you;");
            lcplbaros.Shoot("Lance Corporal Baros");
            WriteLine("As your team lays down fire, several aliens make it through and go straight for you..");
            ReadLine();

            Battle.WithXenomorph(you, xeno1);
            Battle.WithXenomorph(you, xeno2);
            you.LevelUp();

            WriteLine("Corporal Black: They're too much, pull back!");
            WriteLine("Sergeant Fisher: Corporal Black, get your team together, there is nowhere else to go, enga--");
            WriteLine("You look toward your Team Leader and Squad Leader, in the blink of an eye both are reduced to ash");
            WriteLine("Lance Corporal Bennett: You killed my team leader! You bastards!");
            WriteLine("In a fit of rage, Bennett charges towards the enemy");
            cplinda.StandFast("Corporal Inda");
            ReadLine();

            WriteLine("One by one your platoon is eliminated");
            WriteLine("Corporal Inda: You guys need to return to the FOB and update the others, I'll hold them off. GO!");
            ReadLine();

            WriteLine("You and Baros sprint back, it feels so far away, but you finally make it");
            WriteLine("Baros: We've got two on our tail, we need t--");
            WriteLine("He takes acid to the face, killing him instantly, now it's only you...");
            ReadLine();
            Battle.WithXenomorph(you, xeno3);
            Battle.WithXenomorph(you, xeno4);
            you.LevelUp();
            WriteLine("Found a grenade!");
            you.Grenades += 1;

            WriteLine("It doesn't look like there's any more nearby, you make your way back to the FOB safely..");
            ReadLine();
            Offense();
        }
        public void Offense()
        {
            WriteLine("Major Jones: What is going on Private, where is your platoon?!");
            WriteLine("You explain to the Major what happened...");
            ReadLine();
            WriteLine("Major Jones: Alright Son, you're going to attach to Golf Company, recent reports from our recon team show that this craft contains at most 50 of those things, with a full frontal assault from the rest of the Battalion, we should outnumber them 5 to 1");
            WriteLine("You nod");
            WriteLine("Major Jones: Gents, move out!");
            WriteLine("Sergeant Kirby: Hey there boot, you're gonna drive this Humvee for us, alright? Don't screw it up. Your gunner will be some other boot we picked up from your leftovers, you'll tell him what to do.");
            WriteLine("You recognize the gunner, it's Private Hurst from the other section");
            WriteLine("Sergeant Kirby: Alright we are moving!");
            ReadLine();

            WriteLine("You make your way toward the landing site, sudenly you hear a roaring noise, like a very large truck");
            WriteLine("Sergeant Kirby: Woah dude, they've got vehicles too! get ready for a fight!");
            ReadLine();

            Battle.WithBanshee(humvee, banshee1);
            Battle.WithBanshee(humvee, banshee2);
            you.LevelUp();

            WriteLine("Sergeant Kirby: Keep it going man, you're doing great!");
            ReadLine();

            Battle.WithBanshee(humvee, banshee3);
            Battle.WithBanshee(humvee, banshee4);
            you.LevelUp();

            WriteLine("Sergeant Kirby: Alright kid, slow down, we are here...there's no way we are getting the Humvee in that thing, Hurst, stay in the turret and provide us cover fire, everyone else, dismount! We're gonna clear this ship out!");
            WriteLine("You get out of the vehicle");
            ReadLine();

            WriteLine("Sergeant Kirby: Alright, I'll take point, kid, you watch the rear");
            WriteLine("You all slowly flow into the ship's entrance, it reeks in here...");
            WriteLine("Sergeant Kirby: The rest of them should be distracted outside...there shouldn't be too many in here...wait, what's that?!");
            ReadLine();

            WriteLine("Taking control of Kirby....");
            Battle.WithXenomorph(sgtkirby, xeno5);
            Battle.WithXenomorph(sgtkirby, xeno6);

            WriteLine("Sergeant Kirby: Don't worry, I've got it! Alright let's keep moving");
            WriteLine("Sergeant Kirby: Alright, this looks like the command deck...but none of those creatures are here...");
            WriteLine("Major Jones (over the radio): Sergeant Kirby, get out of there, they all suddenly turned around and are heading back into the ship, you need to leave now! We will regroup and come up with a follow on plan.");
            WriteLine("Sergeant Kirby: Alright, you heard the man, let's go!");
            ReadLine();
            Escape();

        }
        public void Escape()
        {
            WriteLine("Sergeant Kirby: Alright kid, take point, you're gonna guide us out of here!");
            WriteLine("You get to the front");
            WriteLine("Which direction would you like to go?");
            WriteLine("1. Left");
            WriteLine("2. Right");
            string direction = ReadLine();
            switch (direction)
            {
                case "1":
                    WriteLine("You meet a horde of enemies, prepare to fight!");
                    Battle.WithXenomorph(you, xeno7);
                    Battle.WithXenomorph(you, xeno8);
                    Battle.WithXenomorph(you, xeno9);
                    Battle.WithXenomorph(you, xeno10);
                    you.LevelUp();
                    WriteLine("Found a grenade!");
                    you.Grenades += 1;
                    Escape2();
                    break;
                    
                case "2":
                    WriteLine("You reach a dead end, you need to turn around...");
                    ReadLine();
                    WriteLine("As you advance into the other direction, you feel a rumble...the ship is taking off! You need to leave now!");
                    WriteLine("1. Left");
                    WriteLine("2. Right");
                    string direction2 = ReadLine();
                    switch (direction2)
                    {
                        case "1":
                            WriteLine("Very bad choice! You come face to face with at least a dozen aliens...");
                            WriteLine("...They eat you");
                            WriteLine("Reloading last checkpoint...");
                            ReadLine();
                            Escape();
                            break;
                        case "2":
                            WriteLine("You continue down this corridor which seems like it's endless...");
                            WriteLine("Sergeant Kirby: Look, we need to find away out before it's too late...wait...do you feel that?! No, No No! It's too late! Hang on kid, This thing is taking off");
                            ReadLine();
                            AlienPlanet();
                            break;
                        default:
                            WriteLine("Suddenly acid falls onto your face, you scream in pain, dying slowly in agony");
                            WriteLine("Reloading last checkpoint...");
                            ReadLine();
                            Escape();
                            break;

                    }
                    break;
                default:
                    WriteLine("Wildcard!");
                    ReadLine();
                    WriteLine("You're a risk taker, aren't you?! You stay in the same spot, waiting for the alien horde to come...");
                    WriteLine("Sergeant Kirby: What the hell are you doing? Alright I'm getting out of here, save yourself kid");
                    WriteLine("But before he can leave, the ship starts to take off, you're on your way into outer space...");
                    ReadLine();
                    AlienPlanet();
                    break;

            }
        }
        public void Escape2()
        {
            WriteLine("Good choice, but now there's more decisions to make!");
            WriteLine("1. Straight");
            WriteLine("2. Right");
            string decision3 = Console.ReadLine();

            switch(decision3)
            {
                case "1":
                    WriteLine("You can see the exit up ahead, you have to hurry!");
                    WriteLine("Sergeant Kirby: Alright kid, sprint!");
                    ReadLine();
                    WriteLine("Before you can make it, something pierces your skull, you see the grimace from the alien's face as everything fades away..");
                    WriteLine("Reloading last checkpoint");
                    ReadLine();
                    Escape2();
                    break;
                case "2":
                    WriteLine("You somehow find your way into a maze, there's no way your getting out now");
                    WriteLine("Sergeant Kirby: We are screwed man, guess we haven't much of a choice but to wait it out and see what happens...");
                    WriteLine("And so you do...");
                    ReadLine();
                    AlienPlanet();
                    break;
                default:
                    WriteLine("Another wildcard, free levelups!");
                    you.LevelUp();
                    you.LevelUp();
                    you.LevelUp();
                    you.LevelUp();
                    you.LevelUp();
                    sgtkirby.LevelUp();
                    sgtkirby.LevelUp();
                    sgtkirby.LevelUp();
                    sgtkirby.LevelUp();
                    sgtkirby.LevelUp();
                    ReadLine();
                    WriteLine("The ship starts to take off, looks like you're in for the ride...");
                    ReadLine();
                    AlienPlanet();
                    break;
            }
        }
        public void AlienPlanet()
        {
            WriteLine("SYSTEM NOTE: Not installed yet. Check back again soon. Keep training hard!");
            ReadLine();
            WriteLine("Returning to Main Menu...");
            ReadLine();
            Opening();
        }

        public void Login()
        {
            Console.WriteLine("Enter your username:");
            user = Console.ReadLine();
            Console.WriteLine("....account found, password provided is: <username>");
            Console.ReadLine();
            Console.WriteLine("Enter your password");
            string pass = Console.ReadLine();
            if (user != pass)
            {
                Console.WriteLine("Invalid, try again");
                Login();
            }
            else if (user == pass)
            {
                Opening();

            }
        }
        public void Countdown()
        {
            DateTime endTime = new DateTime(2019, 01, 01, 0, 0, 0);
            TimeSpan ts = endTime - DateTime.Now;
            WriteLine($"Countdown to alien invasion: {ts}");

        }


    }
}
