using System;
namespace UTS_Daspro
{
    class Fighter : Player
    {
        public static int RageDuration = -1;

        public Fighter() {
           
        }

        public override void Skill(Enemy enemy)
        {
            if (Energy >= 5) {
                Console.WriteLine("You used Rage");
                Console.WriteLine("You attack will be 5 times stronger for 3 turns");
                if (RageDuration == -1) {
                    AttackPower *= 5;
                }
                RageDuration = 3;
                enemy.Gethit(AttackPower);
                Energy -= 5;
            } else {
                Console.WriteLine("Energy : " + Energy);
                Console.WriteLine("You don't have enough Energy...");
            }
        }

        public override void Defend()
        {
            base.Defend();
            Console.WriteLine("Generating Mana...");
            Energy += 2;
        }
    }
}