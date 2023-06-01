namespace Clases
{
    public class Jugada
    {
        private bool _adivino = false;
        private int _intentos = 0;
        private int _numero;

        public bool Adivino
        {
            get => default;
            set => _adivino = value;
        }

        public int Intentos
        {
            get => default;
            set => _intentos = value;
        }

        public int Numero
        {
            get => default;
            set => _numero = value;
        }

        public void Comparar()
        {
            do
            {
                ++_intentos;
                Console.WriteLine("Ingrese un numero: ");
                string input = Console.ReadLine();

                int numIngresado;
                int.TryParse(input, out numIngresado);

                if (numIngresado == _numero)
                {
                    Console.WriteLine("Ganaste!");
                    _adivino = true;
                }

            } while (!_adivino);
        }

        public Jugada(int maxNumero)
        {
            Random rnd = new Random();
            Numero = rnd.Next(maxNumero);
        }

    }
}