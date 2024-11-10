namespace ExamKata_SimpleConsoleRPG;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Your battle will start now!");
        Console.WriteLine();

        int playerHealth = 100;
        Console.WriteLine($"Player current health: {playerHealth}");

        int goblinHealth = 100;
        Console.WriteLine($"Goblin current health: {goblinHealth}");

        int playerAttack = 30;
        int playerHealAmount = 20;
        
        Random random = new Random();
        
        while (playerHealth > 0 && goblinHealth > 0)
        {
            Console.WriteLine();
            Console.WriteLine(@"Warrior choose an action:
1. Attack
2. Heal");
            
            string playerChoice = Console.ReadLine().ToLower();
            
            if (playerChoice == "attack" || playerChoice == "1")
            {
                Console.WriteLine("\nWarrior attacks the Goblin!");
                goblinHealth -= playerAttack;
                Console.WriteLine($"Goblin takes {playerAttack} damage.\nGoblin's current health: {goblinHealth}");
            }
            else if (playerChoice == "heal" || playerChoice == "2")
            {
                Console.WriteLine("\nWarrior heals!");
                playerHealth += playerHealAmount;
                Console.WriteLine($"The Warrior restores {playerHealAmount} health.");
            }
            else
            {
                Console.WriteLine("\nInvalid choice! You miss your turn.");
            }

            if (goblinHealth <= 0)
            {
                Console.WriteLine($"\nCongratulations! The Warrior has defeated the Goblin!");
                break;
            }
            
            int goblinAttack = random.Next(1, 30);
            Console.WriteLine("\nGoblin attacks the Warrior!");
            playerHealth -= goblinAttack;
            Console.WriteLine($"The Warrior takes {goblinAttack} damage.\nWarrior's current health: {playerHealth}");
            
            if (playerHealth <= 0)
            {
                Console.WriteLine($"\nThe Warrior has been defeated by the Goblin!");
                break;
            }
        }
    }
}
