using System;
using System.Diagnostics;

namespace TorneoFutbol
{
    class Program
    {
        static void Main(string[] args)
        {
            // Conjunto de equipos registrados
            HashSet<string> equipos = new HashSet<string>();

            // Diccionario que asocia equipos con su conjunto de jugadores
            Dictionary<string, HashSet<string>> torneo = new Dictionary<string, HashSet<string>>();

            // Iniciar cronómetro para medir el tiempo de ejecución
            Stopwatch tiempo = new Stopwatch();
            tiempo.Start();

            // === Registro de equipos ===
            equipos.Add("Barcelona");
            equipos.Add("Emelec");
            equipos.Add("Liga de Quito");

            // Asociar equipos con sus listas de jugadores
            torneo["Barcelona"] = new HashSet<string>();
            torneo["Emelec"] = new HashSet<string>();
            torneo["Liga de Quito"] = new HashSet<string>();

            // === Registro de jugadores en los equipos ===
            torneo["Barcelona"].Add("Pedro");
            torneo["Barcelona"].Add("Juan");
            torneo["Emelec"].Add("Carlos");
            torneo["Liga de Quito"].Add("Luis");

            // === Reportería: Mostrar equipos y jugadores ===
            Console.WriteLine("=== Reporte del Torneo de Fútbol ===");
            foreach (var equipo in torneo)
            {
                Console.WriteLine($"Equipo:{equipo.Key}-> Jugadores: {string.Join(", ", equipo.Value)}");
            }

            // Detener cronómetro y mostrar tiempo de ejecución
            tiempo.Stop();
            Console.WriteLine($"\nTiempo de ejecución: {tiempo.Elapsed.TotalMilliseconds} ms");
        }
    }
}

