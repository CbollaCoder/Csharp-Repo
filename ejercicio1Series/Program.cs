using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1Series
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            int copy = n;
            int cont = 0;
            int[] v = new int[1000];
            int aux;

            while (copy != 0)
            {
                aux = copy % 10;
                v[cont] = aux;
                cont++;
                copy = copy / 10;
            }

            int copy_cont = v[cont - 1];

              while( copy_cont != 0)
            {
                int aux1 = n % 10;
                n = (int)(Math.Pow(10, cont - 1)*aux1) + (n/10);
                Console.WriteLine(n);
                copy_cont --;
            }

            

            Console.ReadKey();
            
        }
    }
}
