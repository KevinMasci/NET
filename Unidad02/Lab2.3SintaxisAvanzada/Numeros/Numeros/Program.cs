internal class Program
{
    private static void Main(string[] args)
    {
        List<int> numeros = new List<int>();

        Console.WriteLine("Ingrese una lista de números separados por coma (,):");
        string entrada = Console.ReadLine();

        string[] numerosStr = entrada.Split(',');

        foreach (string numeroStr in numerosStr)
        {
            if (int.TryParse(numeroStr, out int numero))
            {
                numeros.Add(numero);
            }
        }

        var numerosMayoresA20 = numeros.Where(n => n > 20);

        Console.WriteLine("Números mayores a 20:");
        foreach (var numero in numerosMayoresA20)
        {
            Console.WriteLine(numero);
        }

    }
}