using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio7Series
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            int a = 0;
            int b = 1;
            int c;

            Console.WriteLine("0");

            for(int i=0; i<n; i++)
            {
                Console.WriteLine(b);
                c = a + b;
                a = b;
                b = c;

            }

            Console.ReadKey();

        }
    }
}
