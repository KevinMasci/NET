using Clases;
internal class Program
{
    private static void Main(string[] args)
    {
        A instanciaA = new A("Clase A");
        B instanciaB = new B();

        instanciaA.MostrarNombre();
        instanciaA.M1();
        instanciaA.M2();
        instanciaA.M3();

        instanciaB.MostrarNombre();
        instanciaB.M1();
        instanciaB.M2();
        instanciaB.M3();
        instanciaB.M4();
    }
}