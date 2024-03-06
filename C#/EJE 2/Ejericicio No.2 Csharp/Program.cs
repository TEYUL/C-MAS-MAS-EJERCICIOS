using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejericicio_No._2_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Ingrese el sueldo base del empleado:");
            double sueldoBase = Convert.ToDouble(Console.ReadLine());

       
            double sueldoNeto = CalcularSueldoNeto(sueldoBase);

           
            Console.WriteLine($"Sueldo base: {sueldoBase:C}");
            Console.WriteLine($"Descuentos aplicados: {sueldoBase - sueldoNeto:C}");
            Console.WriteLine($"Sueldo neto a pagar: {sueldoNeto:C}");

            Console.ReadLine(); 
        }

        static double CalcularSueldoNeto(double sueldoBase)
        {
            const double sueldoMinimo = 3300;
            double descuento = 0;

            if (sueldoBase >= sueldoMinimo)
            {
                // Aplicar descuento del 10% para sueldos iguales o superiores a 3300
                descuento = sueldoBase * 0.10;
            }

            
            double sueldoNeto = sueldoBase - descuento;

            return sueldoNeto;
        }
    }
}

