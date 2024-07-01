using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureQuestRPG
{
    public abstract class Character
    {
        public string name;
        public int health { get; set; }
        public int attackPower { get; set; }
        public int defense { get; set; }
        public Character(string name, int health, int attackPower, int defense)
        {
            this.name = name;
            this.health = health;
            this.attackPower = attackPower;
            this.defense = defense;
        }
        public abstract int attack();
        public abstract int getAttacked(int attackPower);
    }
}
