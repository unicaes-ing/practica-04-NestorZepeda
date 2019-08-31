using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica4
{
    class ejercicio2
    {
        public void ejercicio_2()
        {
            int reprobados = 0, Aprobados = 0;
            Console.WriteLine("Ingrese la cantidad de estudiantes");
            Console.Write("Estudiantes: ");
            int can = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < can;)
            {
                i = i + 1;
                Console.WriteLine("Ingrese la nota y asistencia del estudiante " + i);
                Console.Write("Nota: ");
                decimal nota = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Asistencia: ");
                int asistencia = Convert.ToInt32(Console.ReadLine());
                if (nota < 7 || asistencia < 75)
                {

                    reprobados = reprobados + 1;
                }
                else
                    if (nota > 7)
                {

                    Aprobados = Aprobados + 1;
                }

            }
            Console.WriteLine();
            Console.WriteLine("Alumnos Reprobados: " + reprobados);
            Console.WriteLine();
            Console.WriteLine("Alumnos Aprobados: " + Aprobados);

            Console.ReadKey();

        }
    }
}
