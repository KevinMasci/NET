namespace Clases
{
    public class Juego
    {
        private int _record;

        public void ComenzarJuego()
        {
            Console.WriteLine("Bienvenido al juego!");
            bool jugar = true;

            while (jugar)
            {
                Console.Write("Ingrese el máximo número para adivinar: ");
                string input = Console.ReadLine();

                int maxNumero;
                int.TryParse(input, out maxNumero);

                Jugada jugada = new Jugada(maxNumero);

                


            }
            
        }

        private void CompararRecord()
        {
            throw new System.NotImplementedException();
        }

        private void Continuar()
        {
            throw new System.NotImplementedException();
        }

        public Juego()
        {
        
        }

        private void PreguntarMaximo()
        {
            throw new System.NotImplementedException();
        }

        private void PreguntarNumero()
        {
            throw new System.NotImplementedException();
        }
    }
}
