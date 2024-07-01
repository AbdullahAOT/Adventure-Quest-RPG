using Xunit;
using System.Runtime.CompilerServices;
using AdventureQuestRPG;
namespace AdventureQuestRPG_Test
{
    public class UnitTest1
    {
        [Fact]
        public void PlayerAttackMethodTest()
        {
            Player player = new Player("Ahmad", 100, 50, 20);
            Monster monster = new Monster("monster", 100, 40, 20);
            BattleSystem battle = new BattleSystem();

            battle.PlayerAttack(player, monster);

            Assert.Equal(70, monster.health);
        }
        [Fact]
        public void MonsterAttackMethodTest()
        {
            Player player = new Player("Ahmad", 100, 50, 20);
            Monster monster = new Monster("monster", 100, 40, 20);
            BattleSystem battle = new BattleSystem();

            battle.MonsterAttack(monster, player);

            Assert.Equal(80, player.health);
        }
        [Fact]
        public void WinnerHealthTest()
        {
            Player player = new Player("Ahmad", 100, 50, 20);
            Monster monster = new Monster("monster", 100, 40, 20);
            BattleSystem battle = new BattleSystem();

            battle.PlayerAttack(player, monster);
            battle.PlayerAttack(player, monster);
            battle.PlayerAttack(player, monster);
            battle.PlayerAttack(player, monster);

            Assert.Equal("player", battle.winner);
        }
    }
}