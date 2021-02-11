using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie3
{
    class Program
    {
        static void Main(string[] args)
        {
            //01001000100001....

            int n = Int32.Parse(Console.ReadLine());
            

            for(int i=1; i<=n; i++)
            {
                for(int j=1; j<=i; j++)
                {
                    Console.WriteLine("0");
                    if (j == i) Console.WriteLine("1");
                }   
            }

            Console.ReadKey();
        }
    }
}
