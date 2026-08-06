public class Properties
{

    public class User(string name, int id)
    {
        public string Name = name;
        public int Id { get; set; } = id;
    }


    public static void Run()
    {
        User user = new("John", 2);
        Console.WriteLine($"{user.Name} {user.Id} x");
    }
}