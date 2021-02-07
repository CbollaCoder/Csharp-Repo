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

            Boolean res, res1, res2, res3, res4;

            Console.WriteLine("El entero es: {0}. La cadena es: {1}. La letra es: {2}. El flotante es: {3}.", numero,cadena,letraB,flotanteF);

            Console.WriteLine("El numero es: "+numero);
            Console.WriteLine("La cadena es: " +cadena);
            Console.WriteLine("La letra es: " + letraB);
            Console.WriteLine("El flotante es: " + flotanteF);

            res = 5 > 4;
            res1 = 8 < 1;
            res2 = 8 <= 9;
            res3 = 7 >= 7;
            res4 = 3 == 3;

            Console.WriteLine(res);
            Console.WriteLine(res1);
            Console.WriteLine(res2);
            Console.WriteLine(res3);
            Console.WriteLine(res4);

            //CALCULADORA
            float a, b;
            float div;

            Console.WriteLine("CALCULADORA");

            Console.WriteLine("Introducir a:");
            a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introducir b");
            b = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Suma:" + (a + b));
            Console.WriteLine("Resta: " + (a - b));
            Console.WriteLine("Multiplicacion: " + (a * b));
            div = (a / b);
            Console.WriteLine("Division: " + div);
            Console.WriteLine("Modulo: " + (a % b));


            //ARRAY
            int[] numeros = new int[4];

            for (int i = 0; i <= 3; i++)
            {
                numeros[i] = Int32.Parse(Console.ReadLine());
            }

            for (int j = 0; j <= 3; j++)
            {
                Console.WriteLine(" " + numeros[j]);
            }

            Console.ReadKey();
        


        Console.ReadKey();


        }
    }
}
