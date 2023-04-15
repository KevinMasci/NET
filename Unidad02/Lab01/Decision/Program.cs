using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese texto");
        string imputTexto = Console.ReadLine();
        if (!(imputTexto.Any(char.IsLetter)))
        {
            Console.WriteLine("El texto ingresado contiene numeros");
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("1. Mayuscula");
            Console.WriteLine("2. Minuscula");
            Console.WriteLine("3. Cantidad de caracteres");
            Console.WriteLine("Elija una opcion");
            ConsoleKeyInfo opcion = Console.ReadKey();

            if (opcion.Key == ConsoleKey.D1)
            {
                Console.WriteLine(imputTexto.ToUpper());
            }
            else if (opcion.Key == ConsoleKey.D2)
            {
                Console.WriteLine(imputTexto.ToLower());
            }
            else if (opcion.Key == ConsoleKey.D2)
            {
                Console.WriteLine(imputTexto.Length);
            }
            else
            {
                Console.WriteLine("No se eligio ninguna opcion");
            }

            /*bool salir = false;
            while (!salir)
            {
                Console.WriteLine("1. Mayuscula");
                Console.WriteLine("2. Minuscula");
                Console.WriteLine("3. Cantidad de caracteres");
                Console.WriteLine("Elija una opcion");
                ConsoleKeyInfo opcion = Console.ReadKey();

                switch (opcion.Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine(imputTexto.ToUpper());
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine(imputTexto.ToLower());
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine(imputTexto.Length);
                        break;
                    default:
                        salir = true;
                        break;
                }
            }*/
        }
    }
}