namespace program3;

public class program
{
    public static void Main()
    {
        Console.Write("введите длину массива: ");
        int length = Convert.ToInt32(Console.ReadLine());

        int[] height = new int[length];
        Console.Write($"введите элементы: ");
        for (int i = 0; i < length; i++)
        {
            height[i] = Convert.ToInt32(Console.ReadLine());
        }

        int maxArea = 0; //переменная для хранения макс площади
        int left = 0; // левая граница 
        int right = height.Length - 1; // правая граница (-1 так как отсчет начинается с нуля)

        while (left < right)
        {
            int currentArea = (right - left) * Math.Min(height[left], height[right]); //вычисляем текущую площадь основываясь на мин высоте между 2 границами 
            maxArea = Math.Max(maxArea, currentArea); //обновляем макс площадб если текущая больше 

            if (height[left] < height[right]) //сдвигаем границу с меньше высотой внутрь
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        Console.WriteLine("максимальная площадь, которую можно заполнить водой: " + maxArea);
    }
}