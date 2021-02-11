using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieAritmetica1
{
    class Program
    {
        static void Main(string[] args)
        {
            //7,10,13....
            int n = Convert.ToInt32(Console.ReadLine());
            int first = 7;
           // int item = 0;

            for (int i=1; i<=n; i++)
            {
                Console.WriteLine("{0}", first);
                first = first + 3;
                
            }

            Console.ReadKey();
        }
    }
}
