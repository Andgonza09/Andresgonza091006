using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
    internal class Program
    {
        static void Sistema_Tickets(int cantidad_tickets, int min, int max)
        {
            // Almacenamos las variables del main en variables locales para su uso 
            int Número_Tickets = cantidad_tickets;
            int rango_min = min;
            int rango_max = max;

            // Mandamos a llamar a la clase Random para generar los números aleatorios
            var random = new Random();

            // Se crea un array con la cantidad de tickets que se van a generar, luego de eso cada valor obtiene un número aleatorio dentro del rango indicado
            int[] Cantidad = new int[Número_Tickets];
            for (int i = 0; i < Número_Tickets; i++)
            {
                Cantidad[i] = random.Next(rango_min, rango_max);    
            }

            // Creamos un nuevo array para almacenar los números generados
            int[] nuevo_arr = Cantidad.ToArray();

            // Mostramos los números generados en pantalla
            Console.WriteLine("Los tickets disponibles son: [" + String.Join(", ", nuevo_arr) + "]");
        }
        static void Main(string[] args)
        {
            // Ejercicio 8: Sistema de Tickets
            Console.WriteLine("--- Sistema de Tickets---");

            // Solicitar al usuario la cantidad de tickets y el rango de valores
            Console.Write("Escribe la cantidad de tickets disponibles: ");
            int cantidad_tickets = int.Parse(Console.ReadLine());
            Console.WriteLine("Dime el rango mínimo y máximo de los tickets:");
            Console.Write("Mínimo: ");
            int min = int.Parse(Console.ReadLine());
            Console.Write("Máximo: ");
            int max = int.Parse(Console.ReadLine());

            // Llamar a la función para generar y mostrar los tickets y sus rangos
            Sistema_Tickets(cantidad_tickets, min, max);

            Console.ReadLine();

        }
    }
}
