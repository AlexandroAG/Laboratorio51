using System;

namespace Laboratorio54
{
    class Calificacion
    {

        public void MostrarCalificacion()
        {
            List<int> Calificaciones = new List<int> { 85, 90, 78, 92, 88 };

            int suma = 0;

            foreach (int calificacion in Calificaciones)
            {

                suma += calificacion;

            }

            double promedio = suma / (double)Calificaciones.Count;
            Console.WriteLine($"El promedio de las califaciones es : {promedio}");
        }
      
    }

    class Program
    {
        static void Main(string[] args)
        {
          Calificacion calificacion = new Calificacion();
          calificacion.MostrarCalificacion();
        }


    }


}