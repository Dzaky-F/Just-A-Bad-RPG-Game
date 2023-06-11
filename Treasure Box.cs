using System;
namespace UTS_Daspro
{
    class TreasureBox
    {
        public static void MiniGame() {
            Random rnd = new Random();
            int a = rnd.Next(0,10);
            int b = rnd.Next(0,10);
            int c = rnd.Next(0,10);
            int d = rnd.Next(0,10);

            string Tebak1, Tebak2, Tebak3, Tebak4;
            int Tebakan1, Tebakan2, Tebakan3, Tebakan4;
            
            int HasilTambah = a+b+c+d;
            int HasilKali = a*b*c*d;
            int Count;
            
            Console.WriteLine("The sum of all 4 numbers is " + HasilTambah);
            Console.WriteLine("And if all 4 numbers are multiplied together, you'll get " + HasilKali);
            Console.WriteLine("Can you guess it?");

            while (true) {
                Count = 0;
                Console.WriteLine("Enter first number : ");
                Tebak1 = Console.ReadLine();
                Tebakan1 = Convert.ToInt32(Tebak1);

                Console.WriteLine("Enter second number : ");
                Tebak2 = Console.ReadLine();
                Tebakan2 = Convert.ToInt32(Tebak2);

                Console.WriteLine("Enter third number : ");
                Tebak3 = Console.ReadLine();
                Tebakan3 = Convert.ToInt32(Tebak3);

                Console.WriteLine("Enter fourth number : ");
                Tebak4 = Console.ReadLine();
                Tebakan4 = Convert.ToInt32(Tebak4);

                if (a == Tebakan1) Count++;
                if (b == Tebakan2) Count++;
                if (c == Tebakan3) Count++;
                if (d == Tebakan4) Count++;

                if (Count == 4) {
                    Console.WriteLine("Ceste : Ah, finally you managed to guess it correctly ^^");
                    break;
                }
                else {
                    Console.WriteLine("Ceste : Ah, you only guessed " + Count + " number(s) correctly, try again ^^");
                    if (a ==  Tebakan1) Console.Write(a);
                    else Console.Write("_");
                    if (b == Tebakan2) Console.Write(" " + b);
                    else Console.Write(" _");
                    if (c == Tebakan3) Console.Write(" " + c);
                    else Console.Write(" _");
                    if (d == Tebakan4) Console.WriteLine(" " + d);
                    else Console.WriteLine(" _");
                    Console.WriteLine("The sum of all 4 numbers is " + HasilTambah);
                    Console.WriteLine("And if all 4 numbers are multiplied together, you'll get " + HasilKali);
                }
            }
        }
    }
}