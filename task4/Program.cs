using System;

namespace task4
{
    class Program
    {
        /*Sahe deyə Method(lar) yaradılır.
          Çevrənin sahəsi - S = p* r² (p=3)
          Düzbucaqlının sahəsi - S = a* b
          Üçbucaqlının daxilinə çəkilmiş çevrənin sahəsi - S=p* r;
          p=(a+b+c)/2*/
        static void Main(string[] args)
        {
            int p = 3;
            int r;
            Console.WriteLine("enter radius : ");
            r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Cevreninsahe(p, r));

            int a;
            int b;
            Console.WriteLine("first side : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("second side : ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Duzbsahe(a,b));

            Console.WriteLine("enter radius : ");
            r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Ucbsahe(p,r));

            double x;
            double y;
            double z;

            Console.WriteLine("first side : ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("second side : ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("second side : ");
            z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(perimetr(x,y,z));


        }
        static int Cevreninsahe (int p, int r)
        {
            return p * r * r;
        }
        static int Duzbsahe (int a, int b)
        {
            return a * b;
        }
        static int Ucbsahe (int p, int r)
        {
            return p * r;
        }
        static double perimetr(double x, double y, double z)
        {
            return (x + y + z) / 2;
        }
    }
}
