namespace S25W2IntroToClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product();
            Product p2 = new Product(101, "Laptop", 1200);

            p1.Id = 102;
            Console.WriteLine(p1.Id);
        }
    }
}
