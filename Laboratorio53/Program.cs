using System;

namespace Laboratorio53
{
    class Fruta
    {
        public void MostrarFrutas()
        {
            string[] frutas = { "Manzana", "Platano", "Naranja" };

            foreach (string fruta in frutas)
            {
                Console.WriteLine(fruta);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Fruta fruta = new Fruta();
            fruta.MostrarFrutas();
        }
    }
}
