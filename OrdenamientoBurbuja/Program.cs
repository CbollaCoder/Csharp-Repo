using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenamientoBurbuja
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vect = new int[1000];
            int n = Int32.Parse(Console.ReadLine());
            int k;

            int high = n;
            int low = 0;
            int mid;
            int answer;

            //Llenar el vector
            for(int i=0; i<n; i++)
            {
                vect[i] = Int32.Parse(Console.ReadLine());
            }

            //Ordenar ascendente
            for(int i=0; i<n; i++)
            {
                for(int j=0; j<n-1-i; j++)
                {
                    if (vect[j] > vect[j + 1])
                    {
                        int x = vect[j];
                        vect[j] = vect[j + 1];
                        vect[j + 1] = x;
                    }
                }
            }

            //Imrpimir
            for(int i=0; i<n; i++)
            {
                Console.WriteLine(" " + vect[i]);
            }

            //Busqueda Binaria
            k = Int32.Parse(Console.ReadLine());

            while (true)
            {
                mid = high / 2;

                if(vect[mid] == k)
                {
                    answer = mid;
                    break;
                }
                if(k <= vect[mid])
                {
                    high = mid;
                }
                else
                {
                    low = mid;
                }
            }

            Console.WriteLine("El elemento {0} está en la posición {1}", k, answer);
            Console.ReadKey();
            
        }
    }
}
