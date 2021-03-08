using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio5Series
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 1;

            for(int i=9; i > 0; i--)
            {
                for(int j=1; j<= cont; j++)
                {
                    Console.Write(i);
                }
                cont++;
                Console.Write("\n");
            }

            Console.ReadKey();
        }
    }
}
