internal class Program
{
    private static void Main(string[] args)
    {
        string[] provincias = {
        "Buenos Aires",
        "Catamarca",
        "Chaco",
        "Chubut",
        "Córdoba",
        "Corrientes",
        "Entre Ríos",
        "Formosa",
        "Jujuy",
        "La Pampa",
        "La Rioja",
        "Mendoza",
        "Misiones",
        "Neuquén",
        "Río Negro",
        "Salta",
        "San Juan",
        "San Luis",
        "Santa Cruz",
        "Santa Fe",
        "Santiago del Estero",
        "Tierra del Fuego",
        "Tucumán"
        };

        var privinciasFiltradas = provincias.Where(p => p.StartsWith('S') || p.StartsWith('T'));

        foreach (var provincia in privinciasFiltradas)
        {
            Console.WriteLine(provincia);
        }
    }
}