namespace program6;

public class program
{
    static void Main()
    {
        Console.Write("введите координату a(по иксу): ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.Write("введите координату b(по игреку): ");
        double y = Convert.ToDouble(Console.ReadLine());
        if (x >= -2 && x <= 2 && y >= -3 && y <= 2 && x == 0)
        {
            Console.WriteLine($"точка с координатами ({x};{y}) принадлежит треугольнику.");
        }
        else
        {
            Console.WriteLine($"точка с координатами ({x};{y}) не принадлежит треугольнику.");
        }
    }
}
