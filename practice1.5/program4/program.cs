namespace program4;

public class program
{
    static void Main()
    {
        string[] lines = File.ReadAllText("numsTask4.txt").Split(' ');
        int[] numbers = Array.ConvertAll(lines, int.Parse);

        int maxNumber = numbers.Max();
        int sum = numbers.Where(n => n == maxNumber - 1 || n == maxNumber + 1).Sum();

        Console.WriteLine(sum);
    }
}