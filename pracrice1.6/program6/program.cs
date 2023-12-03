namespace program6;

public class program
{
    static void Main()
    {
        double[] nums = { 1.5, -2.3, 3.7, -4.1, 5.2, -6.8, 7.4, -8.9, 9.0 };

        var positiveNumbers = nums.Where(n => n > 0).ToArray();
        var negativeNumbers = nums.Where(n => n < 0).ToArray();

        Console.WriteLine("положительные числа:");
        foreach (var num in positiveNumbers)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine("\nотрицательные числа:");
        foreach (var num in negativeNumbers)
        {
            Console.Write(num + " ");
        }
    }
}