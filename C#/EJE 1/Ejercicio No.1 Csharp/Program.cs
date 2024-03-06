using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_No._1_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Ingrese el nombre del vendedor:");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el apellido del vendedor:");
            string apellido = Console.ReadLine();

            
            double[] ventasPorMes = new double[12];

            
            for (int i = 0; i < 12; ++i)
            {
                Console.WriteLine($"Ingrese las ventas alcanzadas en el mes {i + 1}:");
                ventasPorMes[i] = Convert.ToDouble(Console.ReadLine());
            }

            
            double totalVentas = 0;
            foreach (double ventas in ventasPorMes)
            {
                totalVentas += ventas;
            }

            double promedioVentas = totalVentas / 12;

            
            Console.WriteLine($"Nombre del vendedor: {nombre} {apellido}");
            Console.WriteLine($"Promedio de ventas por mes: {promedioVentas:C}");

            Console.ReadLine(); 
        }
    }
}
