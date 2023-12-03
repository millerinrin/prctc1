namespace program2;

public class program
{
    static void Main()
    {
        string[] lines = File.ReadAllText("numsTask2.txt").Split(';');
        double[] numbers = Array.ConvertAll(lines, double.Parse);

        Array.Sort(numbers);

        File.WriteAllText("numsTask2.txt", string.Join(";", numbers));
        Console.WriteLine("Sorted numbers have been written to file.");
    }
}