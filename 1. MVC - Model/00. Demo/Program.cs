namespace _00._Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Smetka: ");
            int smetka=int.Parse(Console.ReadLine());

            Console.WriteLine($"Smetka: {smetka}, bakshish: {smetka*0.10}");
            Console.WriteLine($"Total: {smetka*1.1}");
        }
    }
}
