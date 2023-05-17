using Clases;
internal class Program
{
    B b = new B();
    A a = b;
    a.F();
    b.F();
    a.G();
    b.G();

    Console.ReadKey();

}