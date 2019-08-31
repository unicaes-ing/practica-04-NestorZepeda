using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica4
{
    class ejercicio6
    {
        public void ejercicio_6()
        {
            int i = 0;
            decimal totalSucursal = 0.00m, totalGlobal = 0.00m;
            string mensaje = "";

            do
            {
                Console.WriteLine("Ingrese el total de ventas de la sucursal {0}", i + 1);
                totalSucursal = Convert.ToDecimal(Console.ReadLine());
                mensaje += "Cantidad sucursal " + i + ":" + totalSucursal + "\n";
                totalGlobal += totalSucursal;
                i++;
            } while (totalSucursal != 0);

            Console.WriteLine(mensaje);
            Console.WriteLine("Cantidad global: {0:N2} Promedio: {1:N2}", totalGlobal, totalGlobal / i);
        }
    }
}
