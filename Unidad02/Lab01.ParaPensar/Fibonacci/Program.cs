internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese cuantos terminos quiere sumar");
        int n = Convert.ToInt32(Console.ReadLine());

        int a = 0;
        int b = 1;
        int suma = 0;

        for (int i = 0; i < n; i++)
        {
            int c = a + b;
            suma += b;
            a = b;
            b = c;
        }
        Console.WriteLine("La suma de los primeros {0} terminos de la serie de Fibonacci es: {1}", n, suma);
        Console.ReadKey();
    }
}