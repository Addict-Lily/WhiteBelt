namespace MiniKata2_VariablePracticeWithTypeConversion;


class Program
{
    static void Main(string[] args)
    {
        //Is this correct way to use ?? if user does not want to type his name?
        Console.WriteLine("Write your name: ");
        string inputUser = Console.ReadLine() ?? "Anonymous";
        string name = string.IsNullOrWhiteSpace(inputUser) ? "Anonymous" : inputUser;
        Console.WriteLine($"Hello, {name}!");

        int healthPoints = 100;
        double convertedHealthPoints = Convert.ToDouble(healthPoints);
        Console.WriteLine($"Health as double (implicit conversion: {convertedHealthPoints}");
        
        float attackPower = (int)30.0f;
        Console.WriteLine($"Attack Power as int (explicit conversion): {attackPower}");
        
        double experiencePoints = 250;
        int convertedExperiencePoints = Convert.ToInt32(experiencePoints);
        Console.WriteLine($"Experience as int (using Convert): {convertedExperiencePoints}");

        string goldCoins = "150,333333";
        double convertedGoldCoins = double.Parse(goldCoins);
        Console.WriteLine($"Gold Coins (parsed from string): {convertedGoldCoins}");
        
        bool isParalyzed = true;
        Console.WriteLine(isParalyzed);
        
        //Is this correct way according to the assignment?
        
        string invalidString = "invalid";
        
        if (int.TryParse(invalidString, out int number))
        {
            Console.WriteLine($"Parsing successful: {number}");
        }
        else
        {
            Console.WriteLine($"Parsing failed: '{invalidString}' is not a number.");
        }
    }

}