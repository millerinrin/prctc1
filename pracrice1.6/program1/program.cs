namespace program1;

public class program
{
    static void Main()
    {
        string[] words = File.ReadAllText("numsTask1.txt").Split(' ');
        var oddLengthWords = words.Where(word => word.Length % 2 != 0);

        foreach (var word in oddLengthWords)
        {
            Console.WriteLine(word);
        }
    }
}