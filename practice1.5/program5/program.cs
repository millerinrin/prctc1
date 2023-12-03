namespace program5;

public class program
{
    static void Main()
    {
        string[] lines = File.ReadAllText("numsTask5.txt").Split(' ');
        int[] numbers = Array.ConvertAll(lines, int.Parse);

        int minIndex = Array.IndexOf(numbers, numbers.Min());
        int maxIndex = Array.IndexOf(numbers, numbers.Max());

        int start = Math.Min(minIndex, maxIndex) + 1;
        int end = Math.Max(minIndex, maxIndex);

        if (start < end)
        {
            double average = numbers.Skip(start).Take(end - start - 1).Average();
            Console.WriteLine(average);
        }
    }
}