namespace ConsoleApp1;

public class program
{
    static void Main()
    {
        string fileName = "example.txt";
        string text = "Hello, world!";

        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.Write(text);
        }
    }
}