using System;
namespace UTS_Daspro
{
    class Bandit : Player
    {
        Random rnd = new Random();

        public Bandit() {
        
        }

        public override void Skill(Enemy enemy)
        {
            if (Energy >= 3) {
                Console.WriteLine("You used Lucky Hit");
                enemy.Gethit(rnd.Next(AttackPower, 15*AttackPower));
                Energy -= 3;
            } else {
                Console.WriteLine("Energy : " + Energy);
                Console.WriteLine("You don't have enough Energy...");
            }
        }

        public override void Defend()
        {
            base.Defend();
            Console.WriteLine("Generating Energy...");
            Energy++;
        }
    }
}