namespace MiniKata3_ConditionalsChallenge;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("You encounter an enemy!\nDo you want to attempt an attack? (yes/no)");
        string playerInput = Console.ReadLine().ToLower();
        
        Random random = new Random();
        int playerLuck = random.Next(1, 11);
        
        Console.WriteLine($"Player Luck: {playerLuck}");

        if (playerInput == "yes")
        {
            if (playerLuck > 7)
            {
                Console.WriteLine("The attack was successful!");
            }
            else if (playerLuck == 6)
            {
                Console.WriteLine("The attack barely succeeded");
            }
            else
            {
                Console.WriteLine("The attack missed.");
            }
        }
        else if (playerInput == "no")
        {
            Console.WriteLine("The player retreated");
            
        }
        else
        {
            Console.WriteLine("Do not give up! Enter yes!");
        }
    }
    
}