namespace practice1._5;

public class program
{
    static void Main()
    {
        string[] lines = File.ReadAllText("numsTask1.txt").Split(' ');
        int[] nums = Array.ConvertAll(lines, int.Parse);

        int minIndex = Array.IndexOf(nums, nums.Min());
        long product = 1;

        for (int i = minIndex + 1; i < nums.Length; i++)
        {
            product *= nums[i];
        }

        Console.WriteLine(product);
    }
}