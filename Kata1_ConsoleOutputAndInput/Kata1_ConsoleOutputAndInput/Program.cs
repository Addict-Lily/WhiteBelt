namespace Kata1_ConsoleOutputAndInput;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to C# Survival Mode!\nIdentify yourself: ");
        
        string name;
        
        while (true)
        {
            name = Console.ReadLine();            
            if (!string.IsNullOrWhiteSpace(name) && name.All(char.IsLetter))
            {
                name = char.ToUpper(name[0]) + name.Substring(1).ToLower();
                break;
            }
            Console.WriteLine("Invalid input! Please enter a valid name (letters only): ");
        }
        
        Console.WriteLine($"\nWelcome, {name}!\nIn this game, if you want to win, you must not lose!\nYour journey begins now...");
        
        Console.WriteLine($"\n{name}, on a scale of 1 to 10, show me your level of excitement: ");
        
        int level;
        
        while (!int.TryParse(Console.ReadLine(), out level) || level < 1 || level > 10)
        {
            Console.WriteLine("Invalid input! Please enter a number from 1 to 10:");
        }
        if(level <= 5)
        {
            Console.WriteLine($"{name}, that’s very low.\nKeep study! :).\nRome was not built in a day!");
        }
        else
        {
            Console.WriteLine($"Fantastic {name}!\nWelcome on board!");
        }
    }
}