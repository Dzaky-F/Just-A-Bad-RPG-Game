using System;
namespace UTS_Daspro
{
    class Play1
    {
        public static void Start(Player player) {
            Console.WriteLine("Ceste : Player look, a butterfly. That butterfly will be your first enemy ^^");

            Enemy1 Butterfly = new Enemy1();
            Encounter encounter1 = new Encounter(player,Butterfly);

            Console.WriteLine("Ceste : Well done " + player.Name + ", you're a really great player ^^");
            Console.WriteLine("[Press Enter to continue]");
            Console.ReadLine();
            Console.WriteLine("Ceste : Player look, there's a person");

            Enemy2 JustANormalPerson = new Enemy2();
            Encounter encounter2 = new Encounter(player, JustANormalPerson);

            Console.WriteLine("LEVEL UP");
            Console.WriteLine("Your stats has been increased");
            player.Health += 200;
            player.AttackPower += 10;
            Console.WriteLine("Player Health : " + player.Health + " | Attack Power : " + player.AttackPower);
            Console.WriteLine("[Press Enter to continue]");
            Console.ReadLine();
            
            Console.WriteLine("Player : OH MY GOD. Did i just kill him? I mean why did i fought him in the first place");
            Console.WriteLine("Ceste : Well, in this RPG Game you'll fight whatever you encounter");
            Console.WriteLine("Player : This is ridiculous");
            Console.WriteLine("[Press Enter to continue]");
            Console.ReadLine();
            Console.WriteLine("Ceste : Player look, another person");
            Console.WriteLine("Player : No no no..!!!");

            Enemy3 AnotherNormalPersonButStronger = new Enemy3();
            Encounter encounter3 = new Encounter(player, AnotherNormalPersonButStronger);

            Console.WriteLine("LEVEL UP");
            Console.WriteLine("Your stats has been increased");
            player.Health += 200;
            player.AttackPower += 10;
            Console.WriteLine("Player Health : " + player.Health + " | Attack Power : " + player.AttackPower);
            Console.WriteLine("[Press Enter to continue]");
            Console.ReadLine();

            Console.WriteLine("Ceste : Wow, you leveled up again. Now it's time for you to choose a role ^^");
            Console.WriteLine("Player : Why suddenly i can choose a role?");
            Console.WriteLine("");
            Console.WriteLine("Choose your role : ");
            Console.WriteLine("1. Alchemist | Skill : Poison");
            Console.WriteLine("2. Bandit    | Skill : Lucky Hit");
            Console.WriteLine("3. Fighter   | Skill : Rage");
            Console.WriteLine("4. Ice Mage  | Skill : Freeze");

            string Role;
                Role = Console.ReadLine();
                if (Role == "1") {
                    Alchemist choice = new Alchemist();
                    Play2.Start(choice, "Alchemist", "Poison");
                }
                else if (Role == "2") {
                    Bandit choice = new Bandit();
                    Play2.Start(choice, "Bandit", "Lucky Hit");
                }
                else if (Role == "3") {
                    Fighter choice = new Fighter();
                    Play2.Start(choice, "Fighter", "Rage");
                }
                else if (Role == "4") {
                    IceMage choice = new IceMage();
                    Play2.Start(choice, "Ice Mage", "Freeze");
                }
        }
    }
}