using System;

namespace UTS_Daspro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("|Just a Bad RPG Game|");
            Console.WriteLine("[Press Enter to start]");
            Console.ReadLine();
            Console.WriteLine("Ceste : Hi, i'm Ceste, and I will be guiding you throughout your journey in this Game ^^");
            Console.WriteLine("[Press Enter to continue]");
            Console.ReadLine();
            Console.WriteLine("Insert your name : ");

            Novice player = new Novice();
            
            Console.WriteLine("Ceste : Hi " + player.Name + ", ready to play this game?[y/n]");
            string bready = Console.ReadLine();


            while (bready != "y") {
                Console.WriteLine("Ceste : Wait, did you press the wrong button. It's okay, you can try again ^^");
                Console.WriteLine("Ready to play this game?[y/n]");
                bready = Console.ReadLine();
            }

            if (bready == "y") {
                Console.WriteLine("Ceste : Alright, lets go!");
                Console.WriteLine("[Press Enter to continue]");
                Console.ReadLine();

                Play1.Start(player);
            
                
            }
        }
    }
}
