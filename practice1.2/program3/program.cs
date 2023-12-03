namespace program3;

public class program
{
    static void Main()
    {
      Console.Write("введите размерность матрицы: ");        
      int n = Convert.ToInt32(Console.ReadLine());
      int[,] myArr = new int[n, n];        
      
      for (int i = 0; i < n; ++i)
      {            
        myArr[0, i] = 1;
        myArr[i, 0] = 1;         
      }
            for (int i = 1; i < n; ++i)        
            {
                for (int j = 1; j < n; ++j)            
                {
                    myArr[i, j] = myArr[i - 1, j] + myArr[i, j - 1];            
                }
            }
                for (int i = 0; i < n; ++i)        
                {
                for (int j = 0; j < n; ++j)            
                    {
                        Console.Write($"{myArr[i,j]} ");            
                    }
                     Console.WriteLine();        
            
                }
    }
}