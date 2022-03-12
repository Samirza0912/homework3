using System;

namespace task2
{
    class Program
    {
        /* Repeat deyə bir method olsun 
         * və iki parametr qəbul etsin 
         * biri "word" digəri "count" yəni 
         * bu şəkildə "Repeat(string word, int count)" 
         * bu method göndərilən word-ü göndərilən count qədər yan-yana yazdırıb geri qaytarsın.
         * Məsələn:
           Repeat("Ha!") //Ha!
           Repeat("Ha!", 2) //Ha!Ha!
           Repeat("Ha!", 3) //Ha!Ha!Ha!*/
        static void Main(string[] args)
        {
            Console.WriteLine(Repeat("ha", 10000));
        }
        static string Repeat (string word, int count)
        {
            var result = word;
            for (int i = 0; i < count; i++)
            {
                result += word;
            }
            return result;
        }
    }
}
