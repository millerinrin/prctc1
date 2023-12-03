namespace program5;

public class program
{
  static void Main()
  {
    Console.Write("введите координату x: ");
    double x = Convert.ToDouble(Console.ReadLine());
    Console.Write("введите координату y: ");
    double y = Convert.ToDouble(Console.ReadLine());
   if (x >= -1 && x <= 3 && y >= -2 && y <= 4.0)
    {
      Console.WriteLine($"точка с координатами ({x};{y}) принадлежит квадрату.");
    }
    else
    {
      Console.WriteLine($"точка с координатами ({x};{y}) не принадлежит квадрату.");
    }
  }
}
