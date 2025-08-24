using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePráctica
{
    internal class Program
    {
        // El método TotalVentas recibe un arreglo de ventas y retorna el total de ventas
        static double TotalVentas(double[] ventas)
        {
            // Incializamos la variable total en 0 para acumular el total de ventas
            double total = 0;
            foreach (int valor in ventas)
            {
                // Sumamos cada valor del arreglo a la variable total, el foreach recorre todo el arreglo y permite sumar cada valor
                total += valor;
            }

            // Retornamos el total de ventas para usarlo en otras funciones
            return total;
        }
        // El método promedioVentas recibe un arreglo de ventas y retorna el promedio de ventas
        static double promedioVentas(double[] ventas)
        {
            double total = TotalVentas(ventas);
            double promedio = total / ventas.Length;
            return promedio;
        }
        static double maximo_ventas(double[] ventas)
        {
            // Inicializamos la variable máximo con el primer valor del arreglo
            double maximo = ventas[0];

            foreach (double max in ventas)
            {
                // Comparamos cada valor del arreglo con el valor actual de máximo, y cuando el valor del arreglo sea mayor, actualizamos el valor de máximo
                if (max > maximo)
                {       
                    maximo = max;
                }
            }
            return maximo;
        }

        static double minimo_ventas(double[] ventas)
        {
            // Inicializamos la variable mínimo con el primer valor del arreglo 
            double mínimo = ventas[0];

            foreach (int min in ventas)
            {
                // Comparamos cada valor del arreglo con el valor actual de mínimo, y cuando el valor del arreglo sea menor, actualizamos el valor de mínimo
                if (min < mínimo)
                {
                    mínimo = min;
                }
            }
            return mínimo;
        }
        static void Main(string[] args)
        {
            // Ejercicio 1: Reporte de ventas

            // Solicitamos al usuario la cantidad de ventas que desea ingresar
            Console.WriteLine("Ingresa la cantidad de ventas:");    
            int cantidadVentas = int.Parse(Console.ReadLine());

            // Creamos un arreglo para almacenar las ventas con la cantidad especificada por el usuario
            double[] ventas = new double[cantidadVentas];

            // Recorremos la cantidad ingresada por el usuario para llenar el arreglo de ventas
            for (int i = 0; i < cantidadVentas; i++)
            {
                Console.WriteLine("Ingresa el valor de la venta " + (i + 1) + ":");

                // Almacenamos cada venta en el arreglo en cada iteración
                ventas[i] = double.Parse(Console.ReadLine());
            }

            // Mostramos el reporte de ventas utilizando las funciones creadas anteriormente
            Console.WriteLine("Reporte de ventas:");
            TotalVentas(ventas);
            Console.WriteLine("Total de ventas: " + TotalVentas(ventas));

            promedioVentas(ventas);
            Console.WriteLine("Promedio de ventas: " + promedioVentas(ventas));

            maximo_ventas(ventas);
            Console.WriteLine("Máximo de ventas: " + maximo_ventas(ventas));

            minimo_ventas(ventas);
            Console.WriteLine("Mínimo de ventas: " + minimo_ventas(ventas));
        }
    }
}
