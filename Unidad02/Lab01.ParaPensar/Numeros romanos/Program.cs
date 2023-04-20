internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un numero entre 1 y 3999");
        int n = Convert.ToInt32(Console.ReadLine());

        string[] miles = {"", "M", "MM", "MMM"};
        string[] centenas = {"", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM"};
        string[] decenas = {"", "X", "XX", "XXX", "XL", "L", "LC", "LXX", "LXXX", "XC"};
        string[] unidades = {"", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX"};

        string numeroRomano = miles[n/1000];
        numeroRomano += centenas[(n % 1000) / 100];
        numeroRomano += decenas[(n % 100) / 10];
        numeroRomano += unidades[n % 10];

        Console.WriteLine(numeroRomano);
        Console.ReadKey();
    }
}