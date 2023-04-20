internal class Program
{
    private static void Main(string[] args)
    {
        int intentos = 4;
        string clave = "1234";

        while (intentos > 0) {

            Console.WriteLine("Ingrese la clave");
            string pass = Console.ReadLine();
            if (pass == clave)
            {
                Console.WriteLine("Clave correcta!");
                break;
            }
            else
            {
                intentos--;
                Console.WriteLine("Clave incorrecta, quedan {0} intentos", intentos);
            }
        }
        if (intentos == 0) { 
            Console.WriteLine("Excediste el numero de intentos");
        }
        Console.ReadKey();
    }
}