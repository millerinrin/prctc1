namespace program1;

public class program
{
    static void Main()
    {
        Console.WriteLine("введите целое положительное число n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int result = 1;

        for (int i = 3; i <= n; i += 3)
        {
            result *= i;
        }

        Console.WriteLine("результат: " + result);
    }
}