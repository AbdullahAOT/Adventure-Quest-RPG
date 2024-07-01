namespace AdventureQuestRPG
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to RPG Game");
            Console.WriteLine("To enter the battle, press start");
            string userInput = Console.ReadLine();
            while (userInput.ToLower() != "start")
            {
                Console.WriteLine("You should enter start to begin!");
                userInput = Console.ReadLine();
            }
            StartBattle();
        }
        public static void StartBattle()
        {
            BattleSystem battle = new BattleSystem();
            battle.BattleSystemManager();
        }
    }
}
