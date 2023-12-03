namespace Program1;

public class Program
{
    static void Main()
    {
        int[] nums = new int[10];
        Random random = new Random();

        for (int i = 0; i < 10; ++i)
        {
            nums[i] = random.Next(1, 100);
        }

        int minIndex = 0;
        for (int i = 0; i < 10; ++i)
        {
            if (nums[i] < nums[minIndex])
            {
                minIndex = i;
            }
        }
        Console.WriteLine("массив слуйных чисел: ");
        for (int i = 0; i < 10; ++i)
        {
            Console.Write(nums[i] + " ");
        }
        Console.WriteLine("\nиндекс минимального элемента: " + minIndex);
    }
}