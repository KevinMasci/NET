internal class Program
{
    private static void Main(string[] args)
    {
        var mesNumero = new Dictionary<string, int>()
        {
            {"enero", 1 },
            {"febrero", 2 },
            {"marzo", 3 },
            {"abril", 4 },
            {"mayo", 5 },
            {"junio", 6 },
            {"julio", 7 },
            {"agosto", 8 },
            {"septiembre", 9 },
            {"octubre", 10 },
            {"noviembre", 11 },
            {"diciembre", 12 },
        };
        Console.WriteLine("Ingrese el nombre de un mes");
        string mes = Console.ReadLine().ToLower();

        int numero = mesNumero[mes];
        Console.WriteLine("{0} {1}", mes, numero);
        Console.ReadKey();
    }
}