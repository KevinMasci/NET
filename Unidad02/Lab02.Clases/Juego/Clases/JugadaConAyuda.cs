using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class JugadaConAyuda : Jugada
    {
        public JugadaConAyuda(int numeroMaximo) : base(numeroMaximo)
        { 

        }

        public override bool Comparar(int numero)
        {
            int diferencia = Math.Abs(numero - Numero);
            base.Comparar(numero);

            if (diferencia >= 100)
            {
                Console.WriteLine("Estás muy lejos del número esperado.");
            }
            else if (diferencia <= 5)
            {
                Console.WriteLine("Estás muy cerca del número esperado.");
            }

            return Adivino;
        }
    }
}
