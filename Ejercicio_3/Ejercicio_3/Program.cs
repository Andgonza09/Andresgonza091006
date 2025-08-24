using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    internal class Program
    {
        static double montos(double monto, double total)
        {
            // Almacenamos los valores del main en una variable local (Porcentaje)
            double porcentaje = (monto / total) * 100;

            // Retornamos el valor del porcentaje para usarlo en el main
            return porcentaje;
        }
        static void Main(string[] args)
        {
            // Solicitamos al usuario que ingrese el monto y el total
            Console.WriteLine("Ingrese el monto:");
            double monto = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el total:");
            double total = double.Parse(Console.ReadLine());

            // Llamamos a la funcion montos y almacenamos el valor retornado en una variable
            double porcentaje = montos(monto, total);
            Console.WriteLine($"El porcentaje es: {porcentaje:F2}%");

            Console.ReadLine();
        }
    }
}
