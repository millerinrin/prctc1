namespace program_4;

public class Program
{
    static void Main()
    {
        int startRange, endRange;
        Console.Write("введите начало диапазона: ");
        startRange = Convert.ToInt32(Console.ReadLine());
        Console.Write("введите конец диапазона: ");
        endRange = Convert.ToInt32(Console.ReadLine());

        int[] randomNumbers = GenerateRandomNumbers(startRange, endRange);

        foreach (int number in randomNumbers)
        {
            Console.Write(number + " ");
        }
    }

    static int[] GenerateRandomNumbers(int start, int end)
    {
        Random random = new Random();
        List<int> numbers = new List<int>();

        for (int i = 0; i < 10; i++) // Генерация 10 случайных чисел
        {
            numbers.Add(random.Next(start, end + 1)); // Добавление случайного числа в диапазоне [start, end] в список
        }

        return numbers.ToArray(); // Преобразование списка в массив и возврат
    }
}