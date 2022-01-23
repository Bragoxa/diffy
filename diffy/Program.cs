using System;
using System.Numerics;
namespace diffy
{
    class Program
    {

        static void Main(string[] args)
        {
            BigInteger g, p, A, B, KA, KB;
            int a, b;
            Console.Write("Введите g: ");
            g = Int32.Parse(Console.ReadLine());
            Console.Write("Введите p: ");
            p = Int32.Parse(Console.ReadLine());
            Console.Write("Введите a: ");
            a = Int32.Parse(Console.ReadLine());
            Console.Write("Введите b: ");
            b = Int32.Parse(Console.ReadLine());
            A = BigInteger.Pow(g, a) % p;
            B = BigInteger.Pow(g, b) % p;
            KA = BigInteger.Pow(B, a) % p;
            KB = BigInteger.Pow(A, b) % p;
            Console.WriteLine("KA = " + KA);
            Console.WriteLine("KB = " + KB);
        }
    }
}
