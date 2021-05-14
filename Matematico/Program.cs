using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematico
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num1, Num2, Suma, Resta;
            Console.Write("Introduzca primer numero: ") ;
            Num1 = int.Parse(Console.ReadLine());
            Console.Write("Introduzca segundo numero: ");
            Num2 = int.Parse(Console.ReadLine());

            Suma = Num1 + Num2;
            Resta = Num1 + Num2;

            Console.WriteLine("La suma total es {0}", Suma);
            Console.WriteLine("el total de la resta es {0}", Resta);

            Console.Write("Se agrego una 1ra linea");
            

            Console.ReadKey();
        }
    }
}
