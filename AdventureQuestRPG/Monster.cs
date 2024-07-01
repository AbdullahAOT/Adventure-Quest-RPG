using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureQuestRPG
{
    public class Monster : Character
    {
        public Monster(string name, int health, int attackPower, int defense) : base(name, health, attackPower, defense)
        {
            base.name = name;
            base.health = health;
            base.attackPower = attackPower;
            base.defense = defense;
        }
        public override int attack()
        {
            return attackPower;
        }
        public override int getAttacked(int attackPower)
        {
            if (attackPower - defense <= 0)
            {
                return 0;
            }
            health -= attackPower - defense;
            return health;
        }
    }
}
