using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4Series
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            float num;
            float den = 1;
            float res;
            int cont = 1;

            for(int i=0; i < n; i++)
            {
                
                if(cont%2 == 0) num = 2;
                else num = 1;

                res = num / den;
                Console.WriteLine(res);
                den++;
                cont++;
            }

            Console.ReadKey();
        }
    }
}
