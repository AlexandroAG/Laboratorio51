using System;
using System.Collections.Generic;
using System.Linq;

namespace Laboratorio51
{
   class PruebaVector1
   {
        private int[] sueldos; //Declaración de un Vector

        public void cargar()
        {
            sueldos = new int[6]; //Inicializamos wl vector en 5
            for (int f = 1; f <= 5; f++)
            {
                Console.Write("Ingrese el sueldo del operario " + f + ": ");
                string linea;

                linea = Console.ReadLine();
                sueldos[f] = int.Parse(linea); //Asignación de los 5 sueldos en el vector

            }

        }

        public void Imprimir()
        {
            Console.Write("Los 5 sueldos de los operarios \n");
            for (int f = 1; f <= 5; f++)
            {
                Console.WriteLine("["+sueldos[f]+"]");
            }
            Console.ReadKey();

        }

        //Menu Principal 

        static void Main(string[] args)
        {
           PruebaVector1 pv = new PruebaVector1 ();
            pv.cargar();
            pv.Imprimir();
        }


    }

}