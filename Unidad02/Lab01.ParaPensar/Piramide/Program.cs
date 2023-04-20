internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Ingresa la cantidad de filas: ");
        int filas = int.Parse(Console.ReadLine());

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < filas - i; j++)
            {
                Console.Write(" ");
            }
            for (int k = 0; k <= i * 2; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        Console.ReadKey();
    }
}