namespace program3;

public class program
{
    static void Main()
    {
        string[] lines = File.ReadAllText("numsTask3.txt").Split(' ');
        int[] numbers = Array.ConvertAll(lines, int.Parse);

        int minIndex = Array.IndexOf(numbers, numbers.Min());
        double average = 0;

        if (minIndex > 0)
        {
            average = numbers.Take(minIndex).Average();
        }

        Console.WriteLine(average);
    }
}