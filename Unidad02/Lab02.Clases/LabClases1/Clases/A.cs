namespace Clases
{
    using System;
    public class A
    {
        public string NombreInstancia { get; set; }

        // Constructor por defecto
        public A() 
        {
            NombreInstancia = "Instancia sin nombre";
        }

        // Constructor por parametro para asignar el nombre
        public A(string nombreInstancia)
        {
            NombreInstancia = nombreInstancia;
        }

        // Metodo para mostrar nombre por consola
        public void MostrarNombre ()
        {
            Console.WriteLine(NombreInstancia);
        }

        public void M1() { Console.WriteLine("Metodo M1 invocado"); }
        public void M2() { Console.WriteLine("Metodo M2 invocado"); }
        public void M3() { Console.WriteLine("Metodo M3 invocado"); }
    }
}