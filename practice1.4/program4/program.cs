namespace program4;

public class program
{
    static void Main()
    {
        // Читаем все числа из файла
        string[] numbers = File.ReadAllText("numsTask4.txt").Split(' ');

        int count = 1; // Начальное количество одинаковых рядом стоящих чисел
        for (int i = 1; i < numbers.Length; ++i)
        {
            if (numbers[i] == numbers[i - 1]) // Если текущее число равно предыдущему
            {
                ++count; // Увеличиваем счетчик
            }
        }
        Console.WriteLine($"количество одинаковых рядом стоящих чисел: {count + 1}"); // Выводим количество для последней последовательности 
    }
}
