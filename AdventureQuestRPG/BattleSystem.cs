using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureQuestRPG
{
    public class BattleSystem
    {
        public string winner;
        public string turn;
        public BattleSystem()
        {
            winner = "No wwinner yet";
            turn = "player";
        }
        public void BattleSystemManager()
        {
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            Player player = new Player(name, 100, 50, 20);
            Monster monster = new Monster("monster", 100, 40, 20);
            Console.WriteLine($"There is a monster in front of you to battle with!");
            while (monster.health > 0 && player.health > 0)
            {
                if (turn == "player")
                {
                    Console.WriteLine("Its your turn, enter A to attack, or you lose your turn");
                    string playerInput = Console.ReadLine();
                    if (playerInput.ToUpper() == "A")
                    {
                        Console.WriteLine(PlayerAttack(player, monster));
                    }
                    turn = "monster";
                }
                else
                {
                    Console.WriteLine(turn + " turn");
                    Console.WriteLine(MonsterAttack(monster, player));
                    turn = "player";
                }
            }
            if (winner == "player")
            {
                Console.WriteLine("You won the battle");
            }
            else
            {
                Console.WriteLine("You lost the battle");
            }
        }
        public string PlayerAttack(Player attacker, Monster target)
        {
            target.getAttacked(attacker.attackPower);
            if (target.health > 0)
            {
                return $"The monster health is reduced to {target.health} now";
            }
            winner = "player";
            return $"You killed the monster";
        }
        public string MonsterAttack(Monster attacker, Player target)
        {
            target.getAttacked(attacker.attackPower);
            if (target.health > 0)
            {
                return $"The monster reduced your health to {target.health} now";
            }
            winner = "monster";
            return $"The monster killed you";
        }
    }
}
