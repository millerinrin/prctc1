namespace program1;

public class program
{
    static void Main()
    {
        int[,] myArr = new int[10, 10]; 
        int nums = 100;

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                myArr[i, j] = nums;
                nums -= 3; 
            }
        }
        
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write(myArr[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
