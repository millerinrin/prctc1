namespace Program3;

public class Program
{
    static void Main()
    {
        List<string> elements = new List<string>();
        string input;

        do
        {
            Console.WriteLine("введите элемент (чтобы закончить - отправьте пустую строку): ");
            input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                elements.Add(input);
            }
        } while (!string.IsNullOrWhiteSpace(input));

        if (elements.Count > 0)
        {
            string shortest = elements[0];
            string longest = elements[0];

            foreach (string element in elements)
            {
                if (element.Length < shortest.Length)
                {
                    shortest = element;
                }

                if (element.Length > longest.Length)
                {
                    longest = element;
                }
            }

            Console.WriteLine("самый короткий элемент: " + shortest);
            Console.WriteLine("самый длинный элемент: " + longest);
        }
        else
        {
            Console.WriteLine("нет элементов");
        }
    }
}