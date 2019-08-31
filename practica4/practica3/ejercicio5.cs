using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica4
{
    class ejercicio5
    {
        public void ejercicio_5()
        {
            int contrasenia = 1234, contra, intentos = 0;

            do
            {
                for (int i = 1; i < 4; i++)
                {
                    intentos = intentos + 1;
                    Console.WriteLine("intento " + intentos + " ingrese la contraseña");
                    contra = Convert.ToInt32(Console.ReadLine());
                    if (contra == contrasenia)
                    {

                        Console.WriteLine("Hola Bienvenido!!!");
                        break;
                    }
                    else
                    {
                        if (contra != contrasenia && intentos == 1)
                        {
                            Console.WriteLine("El primer caracter de la contraseña es: 1 ");
                        }
                        else
                        {
                            if (contra != contrasenia && intentos == 2)
                            {
                                Console.WriteLine("El segundo caracter de la contraseña es: 2 ");
                            }
                            else
                            {
                                if (contra != contrasenia && intentos == 3)
                                {
                                    Console.WriteLine("El tercer caracter de la contraseña es: 3");

                                }
                            }

                        }
                    }
                }
                Console.WriteLine(" ha terminado la cantidad de intentos admitidos y No pudo acceder :(");

            } while (intentos < 4);

            Console.ReadKey();

        }
    }
}
