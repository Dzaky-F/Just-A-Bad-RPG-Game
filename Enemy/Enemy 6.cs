using System;
namespace UTS_Daspro
{
    class Enemy6 : Enemy
    {
        //unused :(
        public Enemy6() {
            Health = 1000;
            AttackPower = 100;
            Name = "Hero";
        }

        public override void Skill(Player player)
        {
            Console.WriteLine("METEOR STORM!!!");
            player.Gethit((int)0.33 * player.Health);
        }

        public override void BossSkill(Player player)
        {
            player.Gethit(player.Health);
        }
    }
}
