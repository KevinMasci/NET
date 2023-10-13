using Lab01;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        using (var context = new UniversidadContext())
        {
            while (true)
            {
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1. Crear Alumno");
                Console.WriteLine("2. Leer Alumno por Legajo");
                Console.WriteLine("3. Actualizar Alumno");
                Console.WriteLine("4. Eliminar Alumno");
                Console.WriteLine("5. Salir");
                Console.Write("Opción: ");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        CrearAlumno(context);
                        break;
                    case 2:
                        LeerAlumno(context);
                        break;
                    case 3:
                        ActualizarAlumno(context);
                        break;
                    case 4:
                        EliminarAlumno(context);
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }
    }

    static void MostrarDatosAlumno(Alumno alumno)
    {
        Console.WriteLine($"Apellido: {alumno.Apellido}");
        Console.WriteLine($"Nombre: {alumno.Nombre}");
        Console.WriteLine($"Legajo: {alumno.Legajo}");
        Console.WriteLine($"Dirección: {alumno.Direccion}");
        Console.WriteLine();
    }

    static void CrearAlumno(UniversidadContext context)
    {
        Alumno alumno = new Alumno();
        Console.Write("Apellido: ");
        alumno.Apellido = Console.ReadLine();
        Console.Write("Nombre: ");
        alumno.Nombre = Console.ReadLine();
        Console.Write("Legajo: ");
        alumno.Legajo = int.Parse(Console.ReadLine());
        Console.Write("Direccion: ");
        alumno.Direccion = Console.ReadLine();

        context.Alumnos.Add(alumno);
        context.SaveChanges();

        Console.WriteLine("Alumno creado con exito");
    }

    static void LeerAlumno(UniversidadContext context)
    {
        Console.Write("Ingrese el legajo del alumno");
        int legajo = int.Parse(Console.ReadLine());

        Alumno alumno = context.Alumnos.FirstOrDefault(alumno => alumno.Legajo == legajo);

        if (alumno != null)
        {
            MostrarDatosAlumno(alumno);
        }
        else
        {
            Console.WriteLine("No se encontró ningún alumno con ese nombre.");
        }
    }

    static void ActualizarAlumno(UniversidadContext context)
    {
        Console.Write("Ingrese el legajo del alumno");
        int legajo = int.Parse(Console.ReadLine());

        Alumno alumno = context.Alumnos.FirstOrDefault(alumno => alumno.Legajo == legajo);

        if (alumno != null)
        {
            Console.WriteLine("Datos actuales del alumno:");
            MostrarDatosAlumno(alumno);

            Console.WriteLine("Ingrese los nuevos datos:");

            Console.Write("Nuevo apellido: ");
            alumno.Apellido = Console.ReadLine();
            Console.Write("Nuevo nombre: ");
            alumno.Nombre = Console.ReadLine();
            Console.Write("Nuevo legajo: ");
            alumno.Legajo = int.Parse(Console.ReadLine());
            Console.Write("Nueva dirección: ");
            alumno.Direccion = Console.ReadLine();

            context.SaveChanges();

            Console.WriteLine("Alumno actualizado con éxito.");
        }
        else
        {
            Console.WriteLine("No se encontró ningún alumno con ese nombre.");
        }
    }

    static void EliminarAlumno(UniversidadContext context)
    {
        Console.Write("Ingrese el legajo del alumno");
        int legajo = int.Parse(Console.ReadLine());

        Alumno alumno = context.Alumnos.FirstOrDefault(alumno => alumno.Legajo == legajo);

        if (alumno != null)
        {
            Console.WriteLine("Datos actuales del alumno:");
            MostrarDatosAlumno(alumno);

            context.Alumnos.Remove(alumno);
            context.SaveChanges();

            Console.WriteLine("Alumno eliminado:");
        }
        else
        {
            Console.WriteLine("No se encontró ningún alumno con ese nombre.");
        }
    }
}