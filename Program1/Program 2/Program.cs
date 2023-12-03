namespace Program5;

public class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        int input;

        do
        {
            Console.Write("введите число (для завершения введите 0): ");
            input = Convert.ToInt32(Console.ReadLine());
            if (input != 0)
            {
                numbers.Add(input);
            }
        } while (input != 0);

        int sum = 0;
        int product = 1;

        foreach (int number in numbers)
        {
            sum += number;
            product *= number;
        }

        double average = (double)sum / numbers.Count;

        Console.WriteLine($"Сумма: {sum}");
        Console.WriteLine($"Произведение: {product}");
        Console.WriteLine($"Среднее: {average}");
    }
}