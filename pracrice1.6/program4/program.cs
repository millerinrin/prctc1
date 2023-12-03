namespace program4;

public class program
{
    static void Main()
    {
        Console.WriteLine("введите положительное число a: ");
        int a = Convert.ToInt32(Console.ReadLine());

        int sum = 0;
        while (true)
        {
            Console.WriteLine("введите положительное число (для завершения введите отрицательное): ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number < 0)
            {
                break;
            }

            if (number % a == 0)
            {
                sum += number;
            }
        }

        Console.WriteLine($"сумма чисел, делящихся на {a} нацело: {sum}");
    }
}