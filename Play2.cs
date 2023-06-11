using System;
namespace UTS_Daspro
{
    class Play2
    {
        public static void Start(Player player, string role, string skil) {
            player.Health = 500;
            player.AttackPower = 22;
            Console.WriteLine("Ceste : So, you chose " + role + ", nice choice. Now your weak and pathetic Swing Attack has been replaced by " + skil + " ^^");
            Console.WriteLine("Player : Wow cool. But i still feel guilty after killing that person");
            Console.WriteLine("Ceste : Just relax, player. There's nothing to worry ^^. Let me teleport you to the castle nearby, people said the castle is beautiful");
            Console.WriteLine("Player : Well, sure i guess");
            Console.WriteLine("");
            Console.WriteLine("You have been teleported by Ceste into the castle");
            Console.WriteLine("[Press Enter to continue]");
            Console.ReadLine();
            Console.WriteLine("Ceste : Look player, a royal guard is coming to us ^^");
            Console.WriteLine("Player : NO! Please back off you guard!");  

            Enemy4 RoyalGuard = new Enemy4();
            Encounter encounter4 = new Encounter(player, RoyalGuard);

            Console.WriteLine("LEVEL UP");
            Console.WriteLine("Your stats has been increased");
            player.Health += 200;
            player.AttackPower += 10;
            Console.WriteLine("Player Health : " + player.Health + " | Attack Power : " + player.AttackPower);
            Console.WriteLine("[Press Enter to continue]");
            Console.ReadLine();
            
            Console.WriteLine("Player : Why do i keep killing people?");
            Console.WriteLine("Ceste : Calm down player. Look there's a treasure chest. Let's open it ^^");
            Console.WriteLine("Player : What the, this treasure chest just came out of nowhere");
            Console.WriteLine("[Press enter to open the chest]");
            Console.ReadLine();
            Console.WriteLine("Ceste : To open this chest you need to input 4 correct numbers combination");
            TreasureBox.MiniGame();
            
            Console.WriteLine("LEVEL UP");
            Console.WriteLine("Your stats has been increased");
            player.Health += 200;
            player.AttackPower += 10;
            Console.WriteLine("Player Health : " + player.Health + " | Attack Power : " + player.AttackPower);
            Console.WriteLine("[Press Enter to continue]");
            Console.ReadLine();
            Console.WriteLine("Ceste : Well, turns out the chest is empty :(. But it's okay player, at least you leveled up because of it ^^");
            Console.WriteLine("Player : It's fine i guess");
            Console.WriteLine("Ceste : Look player, there's a big door ahead. Let;s open it ^^");
            Console.WriteLine("[Press Enter to open the door]");
            Console.ReadLine();
            Console.WriteLine("Ceste : Look player, it turns out to be the king's room. There's the king ^^");
            Console.WriteLine("Player : Wait, OH S***");

            Enemy5 TheKing = new Enemy5();
            Encounter encounter5 = new Encounter(player, TheKing);

            Console.WriteLine("Player : What have i done");
            Console.WriteLine("Ceste : Congratulations player, you've killed The King and destroy this kingdom ^^. I hope i'll see you again in the future, bye~");
            Console.WriteLine("Player : What the");
            Console.WriteLine("");
            Console.WriteLine("| Game Completed, thanks for playing ^^ |");
        }
    }
}