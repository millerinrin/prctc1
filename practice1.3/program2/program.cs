ввм,namespace program2;

public class program
{
    static void Main()
    {
        string filePath = "nums.txt";
        string[] numbers = File.ReadAllText(filePath).Split(' ');
        
        var oddNumbers = numbers.Where(num => int.Parse(num) % 2 != 0).ToArray();
        
        Console.WriteLine("Результат:");
        foreach (var oddNumber in oddNumbers)
        {
            Console.Write(oddNumber + " ");
        }
    }
}
