internal class Program
{
    private static void Main(string[] args)
    {
        int cantIteraciones = 5;
        string[] arreglo = new string[cantIteraciones];

        for (int i = 0; i < cantIteraciones; i++)
        {
            Console.WriteLine("Ingrese el valor de la posicion {0}", i);
            arreglo[i] = Console.ReadLine();
        }
        for (int i = arreglo.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(arreglo[i]);
        }
        Console.ReadKey();
    }
}