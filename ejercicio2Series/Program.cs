using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2Series
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            float num = 1;
            float den = 2;
            float res;

            for(int i=0; i <= n; i++)
            {
                res = num / den;
                Console.WriteLine(res);
                num = num + 2;
                den = den + 2;

            }

            Console.ReadKey();
        }
    }
}
