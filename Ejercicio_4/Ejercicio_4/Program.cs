using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 4: Análisis de inventario

            // Solicitamos la cantidad de productos del inventario al usuario
            Console.WriteLine("Escribe la cantidad de productos en el inventario:");
            int productos = int.Parse(Console.ReadLine());

            // Creamos un array para almacenar el stock de cada producto brindado por el usuario
            int[] inventario_Stock = new int [productos];


            // Recorremos el array para llenar el stock de cada producto y preguntamos al usuario en cada iteración el stock del producto
            for (int i = 0; i < inventario_Stock.Length; i++)
            {
                Console.WriteLine("Escribe el stock del producto " + (i + 1) + ":");
                inventario_Stock[i] = int.Parse(Console.ReadLine());
            }

            // Declaramos una variable contadora para contar los productos con stock menor a 10
            int contador_Stock = 0;

            // Recorremos el array por medio de un foreach para contar los productos con stock menor a 10 
            // El foreach recorre cada elemento del array y lo almacena en la variable stock

            foreach (int stock in inventario_Stock)
            {
                if (stock < 10)
                {
                    contador_Stock++;
                }
            }

            Console.WriteLine("El número de productos con stock menor a 10 es: " + contador_Stock);

        }
    }
}
