namespace program3;

public class program
{
    static void Main()
    {
        string[] Arr = File.ReadAllText("numsTask3.txt").Split(',');
        int[] numbers = Array.ConvertAll(Arr, Convert.ToInt32); //преобразуем строки в массив целых чисел

        int min = numbers[0];
        int max = numbers[0];
        foreach (int num in numbers)
        {
            if (num == 0)
            {
                break;
            }
            if (num < min)
            {
                min = num;
            }
            if (num > max)
            {
                max = num;
            }
        }

        if (min != 0 && max != 0) 
        {
            double ratio = (double)min / max;
            Console.WriteLine($"Отношение минимального к максимальному: {ratio}");
        }
        
    }
}
