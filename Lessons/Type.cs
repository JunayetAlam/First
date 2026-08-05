public class TypeTest
{
    public static void Run()
    {
        int a = 2;
        int b = a;
        b = 20;

        Point p1 = new() { X = a, Y = b };
        Point p2 = p1;
        p2.X = 10;

        Console.WriteLine(p2.X);
    }
}
class Point { public int X; public int Y; }
