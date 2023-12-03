namespace program1;

public class program
{
    static void Main()
    {
        string inputFileName = "input.txt";
        string outputFileName = "output.txt";

        // Считываем данные из файла input.txt
        string[] input = File.ReadAllLines(inputFileName);
        int[] numbers = Array.ConvertAll(input[0].Split(' '), int.Parse);
        int n = int.Parse(input[1]);

        // Создаем массив билетов
        int[][] tickets = new int[n][];
        for (int i = 0; i < n; i++)
        {
            tickets[i] = Array.ConvertAll(input[i + 2].Split(' '), int.Parse);
        }

        // проверяем каждый билет на выигрышность
        bool[] isLucky = new bool[n];
        for (int i = 0; i < n; i++)
        {
            int count = 0;
            for (int j = 0; j < 6; j++)
            {
                if (Array.IndexOf(numbers, tickets[i][j]) != -1)
                {
                    count++;
                }
            }
            if (count >= 3)
            {
                isLucky[i] = true;
            }
        }
        using (StreamWriter writer = new StreamWriter(outputFileName))
        {
            for (int i = 0; i < n; i++)
            {
                if (isLucky[i])
                {
                    writer.WriteLine("Lucky");
                }
                else
                {
                    writer.WriteLine("Unlucky");
                }
            }
        }
    }
}