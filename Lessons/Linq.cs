public class Linq
{
    public static void Run()
    {
        var numbers = new List<int> { 2, 3, 4, 5, 6 };
        var even = numbers.Where(item => item % 2 == 0);
        var doubled = numbers.Select(item => item * 2);
        var firstEven = numbers.FirstOrDefault(item => item % 2 == 0);
        Console.WriteLine($"Numbers: [{string.Join(", ", numbers)}]");
        Console.WriteLine($"even: [{string.Join(", ", even)}]");
        Console.WriteLine($"doubled: [{string.Join(", ", doubled)}]");
        Console.WriteLine($"firstEven: {firstEven}");
    }
}