using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Rectangulo : Poligono
    {
        public override float CalcularPerimetro()
        {
            return 3;
        }

        public override float CalcularSuperficie()
        {
            return 4;
        }
    }
}
