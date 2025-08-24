using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    internal class Program
    {
        static int Nivel_Satisfacción(int calificación)
        {
            // Pedimos al usuario que ingrese una calificación de satisfacción del cliente

            Console.WriteLine("Ingrese una calificación de satisfacción del cliente (1-100):");
            Console.WriteLine("--- Escalas de satisfacción ---");
            Console.WriteLine("Alta: 80-100");
            Console.WriteLine("Media: 50-79");
            Console.WriteLine("Baja: 0-49");
            Console.WriteLine("\n");

            calificación = int.Parse(Console.ReadLine());

            // Evaluamos la calificación y mostramos el nivel de satisfacción correspondiente
            if (calificación >= 80 && calificación <= 100)
            {
                Console.WriteLine("Nivel de satisfacción: Alta");
            }
            else if (calificación >= 50 && calificación < 80)
            {
                Console.WriteLine("Nivel de satisfacción: Media");
            }
            else if (calificación >= 0 && calificación < 50)
            {
                Console.WriteLine("Nivel de satisfacción: Baja");
            }
            else
            {
                Console.WriteLine("Calificación inválida. Por favor, ingrese un valor entre 1 y 100.");
            }
            // Retornamos la calificación y se la pasamos al método Main
            return calificación;
        }
        static void Main(string[] args)
        {
            // Inicializamos la variable calificación en 0 para evitar errores y poder pasarla al método
            int calificación = 0;

            // Mandamos a llamar al método Nivel_Satisfacción y le pasamos la variable calificación
            Nivel_Satisfacción(calificación);
        }
    }
}
