using System;
namespace UTS_Daspro
{
    class Enemy1 : Enemy
    {
        public Enemy1() {
            Health = 25;
            AttackPower = 1;
            Name = "Butterfly";
        }

        public override void Skill(Player player)
        {
            Console.WriteLine(Name + " used Wing Attack");
            base.Skill(player);
        }
    }
}
