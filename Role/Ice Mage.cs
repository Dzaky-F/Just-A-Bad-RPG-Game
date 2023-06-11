using System;
namespace UTS_Daspro
{
    class IceMage : Player
    {
        public static int StunDuration = 0;

        public IceMage() {
           
        }
        
        public override void Skill(Enemy enemy) 
        {
            if (Mana >= 3) {
                Console.WriteLine("You used Freeze");
                StunDuration = 3;
                Console.WriteLine(enemy.Name + " is being frozen for " + StunDuration + " turns");
                enemy.IsStunned = true;
                Mana -= 3;
            } else {
                Console.WriteLine("Mana : " + Mana);
                Console.WriteLine("You don't have enough Mana...");
            }
        }

        public override void Defend()
        {
            base.Defend();
            Console.WriteLine("Generating Mana...");
            Mana++;
        }
    }
}