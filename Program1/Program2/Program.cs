﻿namespace Program2;

public class Program
{
    public static void Main()
    {
        int n = 5; // Задаем размерность матрицы (можно изменить на нужное значение)

        int[,] matrix = new int[n, n];

        // Заполняем первую строку и первый столбец матрицы значениями 1
        for (int i = 0; i < n; i++)
        {
            matrix[0, i] = 1; // первая строка
            matrix[i, 0] = 1; // первый столбец
        }

        // Заполняем остальные элементы матрицы
        for (int i = 1; i < n; i++)
        {
            for (int j = 1; j < n; j++)
            {
                matrix[i, j] = matrix[i - 1, j] + matrix[i, j - 1];
            }
        }

        // Выводим получившуюся матрицу
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}