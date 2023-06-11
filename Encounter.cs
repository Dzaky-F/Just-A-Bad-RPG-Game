using System;
namespace UTS_Daspro
{
    class Encounter
    {
        public Encounter(Player player, Enemy enemy) {
            Console.WriteLine("");
            Console.WriteLine("You are encountering " + enemy.Name);
            Console.WriteLine(enemy.Name + " is blocking your way");
            Console.WriteLine("[Press Enter to continue]");
            Console.ReadLine();

            player.Energy = 0;
            player.Mana = 0;
            Fighter.RageDuration = -1;
            IceMage.StunDuration = 0;
            Alchemist.PoisonDuration = 0;


            while(!enemy.IsDead && !player.IsDead && !player.IsRunningAway) {
                if (IceMage.StunDuration == 0) {
                    enemy.IsStunned = false;
                }
                if (Alchemist.PoisonDuration == 0) {
                    enemy.IsPoisoned = false;
                }

                Console.WriteLine("Choose your action :");
                Console.WriteLine("1. Single Attack");
                Console.WriteLine("2. Skill");
                Console.WriteLine("3. Defend");
                Console.WriteLine("4. Run Away");
                string PlayerAction = Console.ReadLine();
                Random rnd = new Random();
                switch(PlayerAction) {
                    case "1" :
                    Console.WriteLine("You used single attack");
                    enemy.Gethit(player.AttackPower);
                    if(!enemy.IsStunned) {
                        player.Gethit(enemy.AttackPower);
                    }
                    player.Energy++;
                    player.Mana++;
                    player.Exp += 0.3f;
                    Console.WriteLine("Player Health : " + player.Health + " | Enemy Health : " + enemy.Health);
                    break;
                    case "2" :
                    player.Skill(enemy);
                    player.Exp += 0.9f;
                    Console.WriteLine("Player Health : " + player.Health + " | Enemy Health : " + enemy.Health);
                    break;
                    case "3" :
                    player.Defend();
                    if (!enemy.IsStunned) {
                        if(rnd.Next(1,4) == 1) {
                            enemy.Skill(player);
                        }
                    }
                    player.Exp += 0.2f;
                    Console.WriteLine("Player Health : " + player.Health + " | Enemy Health : " + enemy.Health);
                    break;
                    case "4" :
                    player.IsRunningAway = true;
                    Console.WriteLine("You attempt to run away, but Ceste is blocking you");
                    Console.WriteLine("Ceste : Huh, you're trying to run away? Pathetic");
                    Console.WriteLine("[Press Enter to continue the fight]");
                    Console.Read();
                    break;
                }
                
                if (Fighter.RageDuration > 0) {
                    Fighter.RageDuration--;
                    if (Fighter.RageDuration == 0) {
                        player.AttackPower /= 5;
                        Fighter.RageDuration = -1;    
                    }
                }

                if (enemy.IsStunned) {
                    IceMage.StunDuration--;
                }
                if (enemy.IsPoisoned) {
                    Console.WriteLine(enemy.Name +  "receives " + enemy.Health / 5 + " damage due to poison");
                    Alchemist.PoisonDuration--;
                }
            }       
            if (enemy.IsDead) {
                if (Fighter.RageDuration > 0) {
                    player.AttackPower /= 5;
                    Fighter.RageDuration = -1;
                }
                Console.WriteLine("You defeated " + enemy.Name + ", now you have " + player.Exp + " experience points");
            
            }else if (player.IsDead) {
                Console.WriteLine("Ceste : Oh no, you died. Well, bye~");
                Console.WriteLine("[Press Enter to quit]");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }
    }
}