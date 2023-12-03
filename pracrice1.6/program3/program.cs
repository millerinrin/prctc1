namespace program3;

public class program
{
    static void Main()
    {
        Console.WriteLine("введите число:");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number % 2 == 0)
        {
            if (number % 10 == 0)
            {
                Console.WriteLine("число чётне и кратно 10");
            }
            else
            {
                Console.WriteLine("число чётное, но не кратно 10");
            }
        }
        else
        {
            Console.WriteLine("нечётное");
        }
    }
}