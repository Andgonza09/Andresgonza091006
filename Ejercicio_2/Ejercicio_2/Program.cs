using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Program
    {
        static void MostrarUsuariosActivos(String[] estado)
        {
            // Declaramos una variable con el estado que queremos filtrar
            String usuariosActivos = "Activo";

            // Where: filtra los elementos de una secuencia en función de una condición
            // En este caso, filtramos los usuarios que están activos, y creamos un nuevo array con Toarray() que almacena los usuarios activos
            String[] usuarios_activos = estado.Where(u => u == usuariosActivos).ToArray();

            // Mostramos los usuarios activos en el array
            Console.WriteLine("Usuarios activos: " + String.Join(", ", usuarios_activos));
        }
        static void Main(string[] args)
        {
            // Ejercicio 2: filtrado de estado de usuarios

            // Elaboramos un array de strings con el estado de varios usuarios (Activo, Inactivo)
            String[] estado = { "Activo", "Inactivo", "Activo", "Inactivo", "Activo", "Activo", "Activo", "Inactivo" };
            Console.WriteLine("---- Usuarios activos ----");

            // Llamamos a la función que muestra los usuarios activos
            MostrarUsuariosActivos(estado);

        }
    }
}
