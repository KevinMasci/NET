using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        Hashtable ciudades = new Hashtable()
        {
            { "Buenos Aires", "C1010" },
            { "Córdoba", "X5000" },
            { "Rosario", "S2000" },
            { "Mendoza", "M5500" },
            { "La Plata", "B1900" },
            { "Mar del Plata", "B7600" },
            { "San Miguel de Tucumán", "T4000" },
            { "Salta", "A4400" },
            { "Santa Fe", "S3000" },
            { "San Juan", "J5400" }
        };

        Console.WriteLine("Ingrese una expresión de búsqueda de tres caracteres:");
        string expresion = Console.ReadLine().ToLower();

        var resultados = ciudades.Keys.Cast<string>()
                                 .Where(c => c.ToLower().Contains(expresion))
                                 .Select(c => ciudades[c]);

        Console.WriteLine("Resultados de búsqueda:");
        foreach (var codigoPostal in resultados)
        {
            Console.WriteLine(codigoPostal);
        }
    }
}