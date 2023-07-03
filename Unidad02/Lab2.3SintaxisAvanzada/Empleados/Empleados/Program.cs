internal class Program
{
    static void Main(string[] args)
    {
        List<Empleado> empleados = new List<Empleado>();

        while (true)
        {
            Console.WriteLine("Ingrese el ID del empleado (0 para finalizar):");
            int id = Convert.ToInt32(Console.ReadLine());

            if (id == 0)
                break;

            Console.WriteLine("Ingrese el nombre del empleado:");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el sueldo del empleado:");
            decimal sueldo = Convert.ToDecimal(Console.ReadLine());

            Empleado empleado = new Empleado(id, nombre, sueldo);
            empleados.Add(empleado);
        }

        Console.WriteLine("\nEmpleados ordenados por sueldo (ascendente):");
        var empleadosAscendente = empleados.OrderBy(e => e.Sueldo);
        foreach (var empleado in empleadosAscendente)
        {
            Console.WriteLine(empleado);
        }

        Console.WriteLine("\nEmpleados ordenados por sueldo (descendente):");
        var empleadosDescendente = empleados.OrderByDescending(e => e.Sueldo);
        foreach (var empleado in empleadosDescendente)
        {
            Console.WriteLine(empleado);
        }
    }
}

class Empleado
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public decimal Sueldo { get; set; }

    public Empleado(int id, string nombre, decimal sueldo)
    {
        Id = id;
        Nombre = nombre;
        Sueldo = sueldo;
    }

    public override string ToString()
    {
        return $"ID: {Id}, Nombre: {Nombre}, Sueldo: {Sueldo:C}";
    }
}