namespace Clases
{
    public class Juego
    {
        private int _record = 0;

        public Juego() 
        { 
            _record = int.MaxValue;
        }
        public void ComenzarJuego()
        {
            int numeroMaximo = PreguntarMaximo();
            Jugada jugada = new Jugada(numeroMaximo);

            bool adivino = false;
            int intentos = 0;

            do
            {
                int numero = PreguntarNumero();
                intentos++;

                adivino = jugada.Comparar(numero);
            } while (!adivino);

            if (intentos < _record)
            {
                _record = intentos;
                Console.WriteLine("Nuevo record!");
            }

            CompararRecord();
            Continuar();

        }

        public void CompararRecord()
        {
            Console.WriteLine($"El récord actual es: {_record} intentos.");
        }

        public void Continuar()
        {
            Console.WriteLine("Quiere jugar otra partida? (s/n)");
            string input = Console.ReadLine();

            if (input.ToLower() == "s")
            {
                ComenzarJuego();
            }
            else
            {
                Console.WriteLine("¡Gracias por jugar!");
            }
        }

        private int PreguntarMaximo()
        {
            Console.WriteLine("Ingresa el número máximo para adivinar:");
            string input = Console.ReadLine();
            int numeroMaximo;

            while (!int.TryParse(input, out numeroMaximo))
            {
                Console.WriteLine("Entrada inválida. Ingresa un número válido:");
                input = Console.ReadLine();
            }

            return numeroMaximo;
        }

        private int PreguntarNumero()
        {
            Console.WriteLine("Ingresa un número para adivinar:");
            string input = Console.ReadLine();
            int numero;

            while (!int.TryParse(input, out numero))
            {
                Console.WriteLine("Entrada inválida. Ingresa un número válido:");
                input = Console.ReadLine();
            }

            return numero;
        }
    }
}
