using System;
namespace UTS_Daspro
{
    class Enemy2 : Enemy
    {
        public Enemy2() {
            Health = 50;
            AttackPower = 1;
            Name = "Just a normal person";
        }

        public override void Skill(Player player)
        {
            Console.WriteLine(Name + " used Normal Punch");
            base.Skill(player);
        }
    }
}
