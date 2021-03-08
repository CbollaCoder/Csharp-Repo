using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio10Series
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            int odd = 1;
            int even = 0;

            for(int i=1; i<=n; i++)
            {
                if(i%2 != 0)
                {
                    Console.WriteLine(odd);
                    odd = odd + 2;
                }

                if (i % 2 == 0)
                {
                    Console.WriteLine(even);
                    even = even + 2;
                }
            }

            Console.ReadKey();

        }
    }
}
