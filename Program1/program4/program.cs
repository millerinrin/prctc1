namespace ConsoleApp2;

public class program
{ 
    static void Main() 
    { 
        Console.Write("Введите начало диапазона: "); 
        int start = int.Parse(Console.ReadLine()); 
        Console.Write("Введите конец диапазона: "); 
        int end = int.Parse(Console.ReadLine()); 
        Console.Write("Введите размер массива: "); 
        int Size = Convert.ToInt32(Console.ReadLine()); // Пользователь вводит размер массива 
 
        int[] randomNumbers = GenerateRandomNumbers(start, end, Size); // Генерируем массив случайных чисел 
        PrintArray(randomNumbers); // Выводим элементы массива в одну строку через пробел 
    } 
 
    static int[] GenerateRandomNumbers(int start, int end, int size) 
    { 
        int[] numbers = new int[size]; 
        Random randome = new Random(); 
        for (int i = 0; i < size; i++) 
        { 
            int randomNumber = randome.Next(start, end + 1); 
            numbers[i] = randomNumber; 
        } 
        return numbers; 
    } 
 
    static void PrintArray(int[] array) 
    { 
        foreach (int number in array) 
        { 
            Console.Write(number + " "); 
        } 
    } 
}