using System;
namespace UTS_Daspro
{
    class Enemy
    {
        public int Health { get; set; } 
        public string Name { get; set; }
        public int AttackPower { get; set; }
        public bool IsDead { get; set; }
        public bool IsStunned { get; set; }
        public bool IsPoisoned { get; set; }
    
        Random rnd = new Random();

        public void Gethit(int HitValue) {
            Console.WriteLine(Name + " get hit by " + HitValue);
            Health -= HitValue;

            if (Health <= 0) {
                Health = 0;
                Die();
            }
        }

        public void Die() {
            IsDead = true;
        }

        public virtual void Skill(Player player)
        {
            player.Gethit(2*AttackPower);
        }

        public virtual void BossSkill(Player player)
        {
            player.Gethit(3 * AttackPower);
        }
    }
}
