using System;
namespace UTS_Daspro
{
    class Enemy3 : Enemy
    {
        public Enemy3() {
            Health = 150;
            AttackPower = 5;
            Name = "Another normal person, but stronger";
        }

        public override void Skill(Player player)
        {
            Console.WriteLine(Name + " used Stronger Punch");
            player.Gethit(3 * AttackPower);
        }
    }
}
