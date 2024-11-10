namespace Kata4_Loops;

class Program
{
    static void Main(string[] args)
    {
        for (int wave = 1; wave <= 5; wave++)
        {
            Console.WriteLine($"Wave {wave} is starting!");

            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine($"Enemy #{i} has spawned!");
            }
            
            Console.WriteLine(@$"Wave {wave} completed.
Preparing for the next wave!");
            
            Thread.Sleep(1000);
            Console.WriteLine();
        }
        
        Console.WriteLine(@"All waves completed!
Victory is yours!");
    }
}