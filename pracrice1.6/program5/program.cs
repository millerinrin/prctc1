namespace program5;

public class program
{
    static void Main()
    {
        Console.Write("Введите количество строк матрицы: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите количество столбцов матрицы: ");
        int m  = Convert.ToInt32(Console.ReadLine()); 
        int[,] a = new int[n, m]; // Исходная матрица
        int[,] result = new int[n, m + 1]; // Матрица с дополнительным столбцом
        Random random = new Random();
        for (int i = 0; i < n; i++) // Заполнение матрицы
        {
            for (int j = 0; j < m; j++)
            {
                a[i, j] = random.Next(0, 2);
            }
        }
        for (int i = 0; i < n; i++) // Копирование исходной матрицы в новую
        {
            for (int j = 0; j < m; j++)
            {
                result[i, j] = a[i, j];
            }
        }
        
        for (int i = 0; i < n; i++)  // Добавление нового столбца
        {
            int count = 0; // Подсчет количества единиц в строке
            for (int j = 0; j < m; j++)
            {
                if (a[i, j] == 1)
                {
                    count++;
                }
            }
            result[i, m] = count % 2 == 0 ? 0 : 1;// Делаем количество единиц в каждой строке четным
        }
        Console.WriteLine("Исходная матрица:"); // Вывод исходной матрицы
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write($"{a[i, j]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("Mатрица с дополнительным столбцом:");// Вывод новой матрицы
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m + 1; j++)
            {
                Console.Write($"{result[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}