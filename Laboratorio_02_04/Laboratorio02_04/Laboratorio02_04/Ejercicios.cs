using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio02_04
{
    class Ejercicios
    {
        public void ejercicio1()
        {
            Console.WriteLine("Ejercicio 1");

            Console.Write("Número ENTERO: ");
            string num_str = Console.ReadLine();

            int num;
            if (!int.TryParse(num_str, out num))
            {
                Console.WriteLine("Error: Debe ingresar un número entero.");
                return;
            }

            string resultado;
            if (num > 0)
            {
                resultado = "positivo";
            }
            else if (num < 0)
            {
                resultado = "negativo";
            }
            else
            {
                resultado = "cero";
            }

            Console.WriteLine($"RESULTADO: El número ingresado es {resultado}");            
            Console.WriteLine("Presiona Enter para continuar");
            Console.ReadKey();
            Console.Clear();

        }
        public void ejercicio2()
        {
            Console.WriteLine("Ejercicio 2");

            Console.Write("Ingrese el número de día: ");
            string num_str = Console.ReadLine();

            int num;
            if (!int.TryParse(num_str, out num))
            {
                Console.WriteLine("Error: Debe ingresar un número entero.");
                return;
            }

            if (num < 1 || num > 7)
            {
                Console.WriteLine("Error: El número debe estar contenido entre 1 y 7.");
                return;
            }

            string dia;
            if (num == 1)
            {
                dia = "lunes";
            }
            else if (num == 2)
            {
                dia = "martes";
            }
            else if (num == 3)
            {
                dia = "miércoles";
            }
            else if (num == 4)
            {
                dia = "jueves";
            }
            else if (num == 5)
            {
                dia = "viernes";
            }
            else if (num == 6)
            {
                dia = "sábado";
            }
            else
            {
                dia = "domingo";
            }

            Console.WriteLine("DIA: " + dia);
        }
    }
}
