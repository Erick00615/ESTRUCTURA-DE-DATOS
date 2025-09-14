using System;
using System.Collections.Generic;

namespace BusquedaCatalogoRevistas
{
    class Program
    {
        // Punto de entrada del programa
        static void Main(string[] args)
        {
            // Catálogo de revistas: lista con 10 títulos
            List<string> catalogo = new List<string>
            {
                "National Geographic",
                "Time",
                "Scientific American",
                "Forbes",
                "Nature",
                "People",
                "The Economist",
                "Sports Illustrated",
                "Vogue",
                "Reader's Digest"
            };

            // Menú interactivo para el usuario
            int opcion = 0;
            do
            {
                Console.WriteLine();
                Console.WriteLine("===== Catálogo de Revistas =====");
                Console.WriteLine("1) Buscar revista");
                Console.WriteLine("2) Mostrar catálogo completo");
                Console.WriteLine("3) Salir");
                Console.Write("Seleccione una opción: ");

                string entrada = Console.ReadLine();
                if (!int.TryParse(entrada, out opcion))
                {
                    Console.WriteLine("Entrada no válida. Ingrese un número.");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        // Pedir el título a buscar
                        Console.Write("\nIngrese el título de la revista a buscar: ");
                        string titulo = Console.ReadLine();

                        if (string.IsNullOrWhiteSpace(titulo))
                        {
                            Console.WriteLine("Título vacío. Intente nuevamente.");
                            break;
                        }

                        // Llamada al método de búsqueda (iterativa)
                        bool encontrado = BuscarRevista(catalogo, titulo);

                        // Mostrar resultado exactamente como pide la tarea
                        if (encontrado)
                            Console.WriteLine("Encontrado");
                        else
                            Console.WriteLine("No encontrado");
                        break;

                    case 2:
                        // Mostrar todos los títulos del catálogo
                        Console.WriteLine();
                        Console.WriteLine("--- Catálogo completo ---");
                        for (int i = 0; i < catalogo.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {catalogo[i]}");
                        }
                        break;

                    case 3:
                        // Salir del programa
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        break;
                }

            } while (opcion != 3);
        }

        // Método iterativo para buscar un título en la lista (no distingue mayúsculas/minúsculas)
        static bool BuscarRevista(List<string> catalogo, string titulo)
        {
            for (int i = 0; i < catalogo.Count; i++)
            {
                if (catalogo[i].Equals(titulo, StringComparison.OrdinalIgnoreCase))
                    return true;
            }
            return false;
        }
    }
}
