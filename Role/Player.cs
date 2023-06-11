using System;
namespace UTS_Daspro
{
    class Player
    {
        public int Health { get; set; } 
        public string Name { get; set; }
        public int AttackPower { get; set; }
        public float Exp { get; set; }
        public bool IsDead { get; set; }
        public bool IsRunningAway { get; set; }
        public int Energy { get; set; }
        public int Mana { get; set; }

        public Player() {
            Health = 100;
            AttackPower = 2;
            Exp = 0.0f;
            Name = Console.ReadLine();

        }

        public virtual void Skill(Enemy enemy) 
        {
            Console.WriteLine("You used Swing Attack");
            enemy.Gethit(AttackPower * 2);
        }

        public virtual void Defend() 
        {
            Console.WriteLine("You Defend");
        }

        public void Gethit(int HitValue) {
            Console.WriteLine("You get hit by " + HitValue);
            Health -= HitValue;

            if (Health <= 0) {
                Health = 0;
                Die();
            }
        }

        public void Die() {
            Console.WriteLine("You Died, Game Over");
            IsDead = true;
        }

    }
}
