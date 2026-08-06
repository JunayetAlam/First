public class Properties
{

    public class User
    {
        public string Name;
        public int Id { get; set; }
        public User(string name, int id)
        {
            Name = name;
            Id = id;
        }
    }


    public static void Run()
    {
        User user = new("John", 2);
        Console.WriteLine($"{user.Name} {user.Id} x");
    }
}