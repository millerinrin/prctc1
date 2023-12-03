namespace Program4;
public class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку: ");
        string inputString = Console.ReadLine();
        
        string[] words = inputString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

       
        int wordCount = words.Length;
        
        string modifiedString = "Start " + inputString + " End";

        Console.WriteLine("Количество слов: " + wordCount);
        Console.WriteLine("Модифицированная строка: " + modifiedString);
    }
}