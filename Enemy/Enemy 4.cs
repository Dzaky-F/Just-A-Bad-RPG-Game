using System;
namespace UTS_Daspro
{
    class Enemy4 : Enemy
    {
        public Enemy4() {
            Health = 250;
            AttackPower = 17;
            Name = "Royal Guard";
        }

        public override void Skill(Player player)
        {
            Console.WriteLine(Name + " used Royal Slash");
            player.Gethit(4 * AttackPower);
        }
    }
}
