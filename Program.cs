using System;
using System.Collections.Generic;

namespace Clase1Practica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cuantos nombres desea ingresar?");
            int cantidad = Int32.Parse(Console.ReadLine());
            List<string> nombres = new List<string>();
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Ingrese un nombre: ");
                string nombre = Console.ReadLine();
                nombres.Add(nombre);
            }
            Console.WriteLine(" ");
            nombres.Sort();
            nombres.ForEach(Console.WriteLine);
        }
    }
}
