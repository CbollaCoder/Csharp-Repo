using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio9Series
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1,2,2,3,3,3,4,4,4,4

            int n = Int32.Parse(Console.ReadLine());
            int aux = 1;

            for(int i=1; i <= n; i++)
            {
                for(int j=1; j <= aux; j++)
                {
                    Console.Write(i + " ");
                }
                aux++;
            }

            Console.ReadKey();
        }
    }
}
