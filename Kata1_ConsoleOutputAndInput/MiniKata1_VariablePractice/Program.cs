namespace MiniKata1_VariablePractice;

class Program
{
    static void Main(string[] args)
    {
        string name = "Arin";
        int playerHealth = 100;
        float attackPower = 15.5f;
        bool isParalyzed = true;
        double currencyAmount = 24.75;

        Console.WriteLine($"Character Name: {name}");
        Console.WriteLine($"Health Point: {playerHealth}");
        Console.WriteLine($"Attack Power: {attackPower}");
        Console.WriteLine($"Is Paralyzed: {isParalyzed}");
        Console.WriteLine($"Gold Coins: {currencyAmount}");
    }
}