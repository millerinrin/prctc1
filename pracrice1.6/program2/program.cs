namespace program2;

public class program
{
    static void Main()
    {
        string[] words = File.ReadAllLines("numsTask2.txt");
        string result = string.Join(" ", words);

        Console.WriteLine(result);
    }
}