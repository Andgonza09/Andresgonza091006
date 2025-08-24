using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaramos el umbral en 1000
            int umbral = 1000;

            // Pedimos al usuario la cantidad de compras que realizó
            Console.WriteLine("Ingresa la cantidad de compras que realizaste:");
            int cantidadCompras = int.Parse(Console.ReadLine());

            // Creamos un arreglo con la cantidad de compras que el usuario indicó
            double[] compras = new double[cantidadCompras];

            // Recorremos el arreglo para pedir al usuario que ingrese el monto de cada compra
            for (int i = 0; i < compras.Length; i++)
            {
                Console.WriteLine($"Ingresa el monto de la compra {i + 1}:");
                compras[i] = int.Parse(Console.ReadLine());

            }

            // where es un método de LINQ que permite filtrar una colección según una condición
            // En este caso, filtramos las compras que son mayores al umbral
            double[] ComprasUmbral = compras.Where(u => u > umbral).ToArray();

            // Mostramos las compras que son mayores al umbral
            Console.WriteLine("Las compras mayores al umbral son:");
            Console.WriteLine("[" + String.Join(", ", ComprasUmbral) + "]");

        }
    }
}
