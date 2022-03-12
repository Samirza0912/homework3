using System;

namespace task3
{
    class Program
    {
        /*Bir method olsun göndərilən "n" sayda ədədin hamsını toplayıb geri qaytarsın.
         */
        static void Main(string[] args)
        {
            int[] result = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int netice = arr(result);
            Console.WriteLine(netice);
        }
        static int arr (int[] sam)
        {
            int sum = 0;
            foreach (var item in sam)
            {
                sum += item;
            }
            return sum;
        }
    }
}
