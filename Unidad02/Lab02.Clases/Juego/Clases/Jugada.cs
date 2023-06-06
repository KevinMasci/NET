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

        public Jugada(int maxNumero)
        {
            Random rnd = new Random();
            _numero = rnd.Next(maxNumero);
            _adivino = false;
            _intentos = 0;
        }

        public virtual bool Comparar(int numero)
        {
            _intentos++;

            if (numero == _numero)
            {
                Console.WriteLine($"¡Adivinaste el número en {_intentos} intentos!");
                _adivino = true;
            }

            return _adivino;
        }
    }
}