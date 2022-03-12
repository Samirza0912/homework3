using System;

namespace tasks
{
    class Program
    {/*Bir method olsun iki parametr qəbul etsin 
      * və bu parametrlərdən birincini ikinciyə bölüb 
      * nəticəni geri qaytarsın.
      */

        static void Main(string[] args)
        {
            Console.WriteLine(Divide(12, 5));            
        }

        static double Divide (double num, double num2)
        {
            return num / num2;
        }
    }
}
