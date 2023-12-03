namespace program4;

public class program
{
    static void Main()
    {
        int[,] temperature = new int[12, 30];
        Random random = new Random();

        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 30; j++)
            {
                temperature[i, j] = random.Next(-30, 31); // Генерация случайной температуры в диапазоне [-30, 30]
            }
        }

        int[] averageTemperatures = CalculateAverageTemperatures(temperature);

        Array.Sort(averageTemperatures);

        Console.WriteLine("Средняя температура для каждого месяца:");
        for (int i = 0; i < 12; i++)
        {
            Console.WriteLine($"Месяц {i + 1}: {averageTemperatures[i]}");
        }
    }

    static int[] CalculateAverageTemperatures(int[,] temperature)
    {
        int[] averageTemperatures = new int[12];

        for (int i = 0; i < 12; i++)
        {
            int sum = 0;
            for (int j = 0; j < 30; j++)
            {
                sum += temperature[i, j];
            }
            averageTemperatures[i] = sum / 30;
        }

        return averageTemperatures;
    }
}