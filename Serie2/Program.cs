using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1,2,5,7,10 .....

            int n = Int32.Parse(Console.ReadLine());
            int a = 1;
            int add = 1;

            for(int i=0; i < n; i++)
            {
                Console.WriteLine("{0}",a);
                a = a + add; 
                add = add + 2; 
            }

            Console.ReadKey();
        }
    }
}
