using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica4
{
    class ejercicio1
    {
        public void ejercicio_1()
        {
            decimal totalsueldo = 0, promediosueldo = 0;

            for (int i = 1; i < 21;)
            {
                Console.WriteLine("Ingrese el sueldo del empleado " + i);
                i = i + 1;
                Console.Write("Sueldo:  $");
                decimal sueldo = Convert.ToDecimal(Console.ReadLine());
                totalsueldo = totalsueldo + sueldo;
                promediosueldo = totalsueldo / i;

            }

            Console.WriteLine("Total de sueldos: " + totalsueldo.ToString("C2"));
            Console.WriteLine();
            Console.WriteLine("Promedio de sueldo:  " + promediosueldo.ToString("C2"));
            Console.ReadKey();
        }
    }
}
