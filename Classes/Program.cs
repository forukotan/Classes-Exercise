namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var lambo = new Car();
            lambo.Make = "nissan";
            lambo.Year = 1995;
            lambo.Model = "lambo";
            Console.WriteLine($"{lambo.Model} {lambo.Make} {lambo.Year}");
        }
        
    }
}
