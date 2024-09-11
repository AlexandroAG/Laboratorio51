using System;
using System.Collections.Generic;

namespace Laboratorio56
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Dictionary<string, string> paisesyCapitales = new Dictionary<string, string>()
            {
                { "Francia", "Paris" },
                { "España", "Madrid" },
                { "Italia", "Roma" }
            };

            foreach (KeyValuePair<string, string> par in paisesyCapitales)
            {
                Console.WriteLine("La capital de " + par.Key + " es " + par.Value);
            }
        }
    }
}
