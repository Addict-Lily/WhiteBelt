namespace Kata2_VariablesAndDataTypes;

class Program
{
    static void Main(string[] args)
    {
        string name = "Lira";
        Console.WriteLine($"Character Name: {name}");

        int level = 5;
        Console.WriteLine($"Level: {level}");
        
        float healthPoints = 75.5f;
        Console.WriteLine($"Health Points: {healthPoints}");
        
        double experiencePoints = 1025.75;
        Console.WriteLine($"Experience Points: {experiencePoints}");

        bool hasMagicAbility = true;
        Console.WriteLine($"Magic Ability: {hasMagicAbility}");

        char rank = 'A';
        Console.WriteLine($"Rank: {rank}");

        float pointsForNextLevel = 100f;
        Console.WriteLine($"Points needed to reach next level: {healthPoints += pointsForNextLevel}");
        
    }
}