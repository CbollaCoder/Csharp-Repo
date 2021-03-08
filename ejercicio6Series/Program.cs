using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio6Series
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            int cont = 1;
            int x = -1;


            for(int i=0; i<=n; i++)
            {
                if(cont%2 != 0)
                {
                    Console.WriteLine(x);
                    x = x + cont;
                    
                }
                cont++;
            }

            Console.ReadKey();

        }
    }
}
