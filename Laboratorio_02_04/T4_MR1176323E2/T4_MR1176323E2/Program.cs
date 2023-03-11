using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4_MR1176323E2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ricardo Guevara - 176323");
            Console.Write("Ingrese un número: ");
            double monto = double.Parse(Console.ReadLine());

            int billete100 = 0;
            int billete50 = 0;
            int billete20 = 0;
            int billete10 = 0;
            int billete5 = 0;
            int moneda1 = 0;
            int moneda25 = 0;
            int moneda1c = 0;


            int centavos = (int)(monto * 100);
            billete100 = centavos / 10000;
            centavos = centavos % 10000;
            billete50 = centavos / 5000;
            centavos = centavos % 5000;
            billete20 = centavos / 2000;
            centavos = centavos % 2000;
            billete10 = centavos / 1000;
            centavos = centavos % 1000;
            billete5 = centavos / 500;
            centavos = centavos % 500;
            moneda1 = centavos / 100;
            centavos = centavos % 100;
            moneda25 = centavos / 25;
            centavos = centavos % 25;
            moneda1c = centavos;

            Console.WriteLine(billete100 + " de Q 100");
            Console.WriteLine(billete50 + " de Q 50");
            Console.WriteLine(billete20 + " de Q 20");
            Console.WriteLine(billete10 + " de Q 10");
            Console.WriteLine(billete5 + " de Q 5");
            Console.WriteLine(moneda1 + " de Q 1");
            Console.WriteLine(moneda25 + " de 25 centavos");
            Console.WriteLine(moneda1c + " de 1 centavo");
            Console.ReadLine();
        }
    }
}

            
     