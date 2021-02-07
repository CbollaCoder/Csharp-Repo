using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 123;
            string cadena = "Luna";
            char letraB = 'b';
            float flotanteF = 12.35f;

            Console.WriteLine("El entero es: {0}. La cadena es: {1}. La letra es: {2}. El flotante es: {3}.", numero,cadena,letraB,flotanteF);

            Console.WriteLine("El numero es: "+numero);
            Console.WriteLine("La cadena es: " +cadena);
            Console.WriteLine("La letra es: " + letraB);
            Console.WriteLine("El flotante es: " + flotanteF);
            Console.ReadKey();
        }
    }
}
