namespace Kata3_Conditionals;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(@"You find a mysterious treasure chest!
What will you do?
1. Open the chest?
2. Ignore the chest?
3. Leave the area?");
        
        string userInput = Console.ReadLine().ToLower();
        
        if (userInput == "open")
        {
            Random random = new Random();
            int playerLuck = random.Next(1, 10);
            
            if (playerLuck > 7)
            {
                Console.WriteLine("The chest contains a rare gem!");
            }
            else if (playerLuck >= 5)
            {
                Console.WriteLine("You found a gold!");
            }
            else
            {
                Console.WriteLine("The chest is trapped!");
            }
        }

        if (userInput == "ignore")
        {
            Console.WriteLine(@"You have to continue your journey!");
        }

        if (userInput == "leave")
        {
            Console.WriteLine(@"The mystery left unsolved!");
        }
        
    }
}