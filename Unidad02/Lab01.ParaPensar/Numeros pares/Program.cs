internal class Program
{
    private static void Main(string[] args)
    {
        for (int i = 1; i*2 < 101; i++)
        {
            Console.WriteLine((i*2).ToString());
        }
        Console.ReadKey();
    }
}