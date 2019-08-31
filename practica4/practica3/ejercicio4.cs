using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica4
{
    class ejercicio4
    {
        public void ejercicio_4()
        {
            decimal total = 0, venta = 0.00m;
            int i = 1;

            do
            {
                Console.WriteLine("venta " + i);
                Console.Write("$ ");
                venta = Convert.ToDecimal(Console.ReadLine());
                total = total + venta;
                i++;

            } while (venta != -1);
            total = total + 1;
            decimal bonificacion = (total * 0.05m);
           decimal nTotal = total + bonificacion;
            Console.WriteLine("El total en ventas es: " + total + "\n" + "Total con bonificacion: " + nTotal.ToString("N2"));

            Console.ReadKey();


        }

    }
}
