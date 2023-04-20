internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el año");
        int anio = Convert.ToInt32(Console.ReadLine());
        if (anio % 4 == 0)
        {
            if (anio % 100 == 0)
            {
                if (anio % 400 == 0)
                {
                    Console.WriteLine("Es bisiesto");
                }
                else
                {
                    Console.WriteLine("No es bisiesto");
                }
            }
            else
            {
                Console.WriteLine("Es bisiesto");
            }
        }
        else
        {
            Console.WriteLine("No es bisiesto");
        }
        Console.ReadKey();
    }
}