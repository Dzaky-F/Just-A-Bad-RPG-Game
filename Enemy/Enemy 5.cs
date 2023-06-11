using System;
namespace UTS_Daspro
{
    class Enemy5 : Enemy
    {
        public Enemy5() {
            Health = 500;
            AttackPower = 30;
            Name = "The King";
        }

        public override void Skill(Player player)
        {
            Console.WriteLine(Name + " used King's Wrath");
            player.Gethit((int)0.33 * player.Health);
        }
    }
}
