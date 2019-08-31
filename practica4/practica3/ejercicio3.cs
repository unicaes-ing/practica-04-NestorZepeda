using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica4
{
    class ejercicio3
    {
        public void ejercicio_3()
        {


            string nombre;
            int vocales = 0;
            Console.WriteLine("ingrese su nombre");
            nombre = Console.ReadLine();
            for (int i = 0; i < nombre.Length; i++)
            {
                if ((Convert.ToChar(nombre[i])) == 'a' || (Convert.ToChar(nombre[i])) == 'A' || (Convert.ToChar(nombre[i])) == 'á' || (Convert.ToChar(nombre[i])) == 'Á')
                {
                    vocales = vocales + 1;
                }
                if ((Convert.ToChar(nombre[i])) == 'e' || (Convert.ToChar(nombre[i])) == 'E' || (Convert.ToChar(nombre[i])) == 'é' || (Convert.ToChar(nombre[i])) == 'É')
                {
                    vocales = vocales + 1;
                }
                if ((Convert.ToChar(nombre[i])) == 'i' || (Convert.ToChar(nombre[i])) == 'I' || (Convert.ToChar(nombre[i])) == 'í' || (Convert.ToChar(nombre[i])) == 'Í')
                {
                    vocales = vocales + 1;
                }
                if ((Convert.ToChar(nombre[i])) == 'o' || (Convert.ToChar(nombre[i])) == 'O' || (Convert.ToChar(nombre[i])) == 'ó' || (Convert.ToChar(nombre[i])) == 'Ó')
                {
                    vocales = vocales + 1;
                }
                if ((Convert.ToChar(nombre[i])) == 'u' || (Convert.ToChar(nombre[i])) == 'U' || (Convert.ToChar(nombre[i])) == 'ú' || (Convert.ToChar(nombre[i])) == 'Ú')
                {
                    vocales = vocales + 1;
                }

            }
            Console.WriteLine("Cantidad de vocales: "+vocales);
            Console.ReadLine();
        }
    }
}
