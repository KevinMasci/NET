internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el primer numero");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo numero");
        int n2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("La suma de {0} y {1} es igual a {2}", n1, n2, (n1+n2));
    }
}