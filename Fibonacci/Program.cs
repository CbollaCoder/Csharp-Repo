using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            int a=0;
            int b=1;
            int c;

            for(int i=0; i<n; i++)
            {
                Console.WriteLine("{0}", b);
                c = a + b;
                a = b;
                b = c;


            }

            Console.ReadKey();

        }
    }
}
