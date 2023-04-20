using System.Xml.Schema;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el rango de numeros (N)");
        int n = Convert.ToInt32(Console.ReadLine());

        int primerNum = 2;
        int segundoNum = 3;
        int cantPrimos = 0;

        while (cantPrimos <= n)
        {
            bool esPrimo = true;
            for (int i = 2; i < segundoNum; i++)
            {
                if (segundoNum % i == 0)
                {
                    esPrimo = false;
                    break;
                }
            }
            if (esPrimo && segundoNum - primerNum == 2) { 
                Console.WriteLine("{0} {1}", primerNum, segundoNum);
                cantPrimos++;
            }
            if (esPrimo)
            {
                primerNum = segundoNum;
            }
            segundoNum += 2;
        }
        Console.ReadKey();
    }
}