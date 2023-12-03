using System;
using System.IO;

namespace program2;

public class program
{
    static void Main()
    {
        string[] nums = File.ReadAllText("numsTask2.txt").Split(';'); //разделяем числа по ;
        double sum = 0;
        foreach (string num in nums) //перебираем все числа в массиве nums
        { 
            double n = Convert.ToDouble(num); 

            if (n > 0 || n == 0)  //если число больше или меньше 0 добавляем к сумме
            { 
                sum += n; 
            }
        } 

        Console.WriteLine($"сумма чиселпо иксупо  до 0: {sum}"); 
    }
}