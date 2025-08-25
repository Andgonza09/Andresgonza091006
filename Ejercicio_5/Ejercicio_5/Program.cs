using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    internal class Program
    {
        static void preciosDólares(double[] preciosCórdobas)
        {
            double tasaCambio = 36.5;
            // Inicializamos un arreglo vacío para almacenar los elementos en Dólares
            double[] precioUSD = { };

            // PreciosCórdobas es el array que contiene los precios en córdobas en el main
            // Con el for pedimos los precios en córdobas la cantidad de veces que el usuario indicó o bien por el tamaño del array
            for (int i = 0; i < preciosCórdobas.Length; i++)
            {
                Console.WriteLine($"Ingrese el precio en córdobas del artículo {i + 1}:");
                preciosCórdobas[i] = double.Parse(Console.ReadLine());
                Console.WriteLine($"El precio en córdobas es: {preciosCórdobas[i]}");

                // Creamos un array para almacenar los precios en dólares del tamaño de del arreglo de córdobas
                 precioUSD = new double[preciosCórdobas.Length];
                // Convertimos el precio a dólares dividiendo el precio en córdobas por la tasa de cambio
                precioUSD[i] = preciosCórdobas[i] / tasaCambio;  
                Console.WriteLine($"El precio en dólares del artículo {i + 1} es: {precioUSD[i]:F2}");
            }
            
            // Otra forma de hacerlo es usando las funciones de LINQ => Select, la cual permite hacer operaciones dentro del mismo arreglo
            // Usamos Select para realizar la conversión y ToArray para convertir el resultado en un array
            // double[] precioUSD = preciosCórdobas.Select(x => x / tasaCambio).ToArray();

            Console.Write("Precios en dólares: ");

            // Imprimimos el array de precios en dólares con dos decimales
            Console.WriteLine("[" + String.Join(", ", precioUSD.Select(p => p.ToString("F2"))) + "]");
        }
        static void Main(string[] args)
        {
            // Ejercicio 5: 

            // Solicita al usuario que ingrese una cantidad determinada de precios en córdobas 
            Console.WriteLine("Ingrese la cantidad de números a ingresar:");
            int cantidadNumeros = int.Parse(Console.ReadLine());

            // Hacemos un array con la cantidad de números ingresados
            double[] preciosCordobas = new double[cantidadNumeros];

            // Llamamos a la función que convierte los precios 
            preciosDólares(preciosCordobas);

        }
    }
}
