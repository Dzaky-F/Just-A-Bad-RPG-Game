using System;
namespace UTS_Daspro
{
    class Alchemist : Player
    {
        public static int PoisonDuration = 0;
        
        public Alchemist() {
 
        }

        public override void Skill(Enemy enemy)
        {
            if (Mana >= 5) {
                Console.WriteLine("You used Poison");
                PoisonDuration = 3;
                Console.WriteLine(enemy.Name + " is being poisoned for 3 turns");
                enemy.IsPoisoned = true;
                Mana -= 5;
            } else {
                Console.WriteLine("Mana : " + Mana);
                Console.WriteLine("You don't have enough Mana...");
            }
        }

        public override void Defend()
        {
            base.Defend();
            Console.WriteLine("Generating Mana...");
            Mana += 2;
        }
    }
}