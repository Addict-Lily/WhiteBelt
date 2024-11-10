namespace MiniKata4_BasicLoops;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Spawning enemies using a for loop: ");
        
        for (int i = 1; i < 5; i++)
        {
            Console.WriteLine($"Enemy #{i} spawned!");
        }
        
        Console.WriteLine();
        Console.WriteLine("Spawning enemies using a while loop: ");

        int enemy1 = 0;
        while (enemy1 < 3)
        {
            Console.WriteLine($"Enemy #{enemy1 += 1} spawned!");
            
        }
        Console.WriteLine("Game over!");
    }
}