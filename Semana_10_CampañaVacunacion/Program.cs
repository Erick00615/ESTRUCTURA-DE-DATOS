using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Conjunto total de ciudadanos
        HashSet<string> ciudadanos = new HashSet<string>();
        for (int i = 1; i <= 500; i++)
        {
            ciudadanos.Add($"Ciudadano {i}");
        }

        // Conjunto de vacunados con Pfizer
        HashSet<string> pfizer = new HashSet<string>();
        for (int i = 1; i <= 75; i++)
        {
            pfizer.Add($"Ciudadano {i}");
        }

        // Conjunto de vacunados con AstraZeneca
        HashSet<string> astrazeneca = new HashSet<string>();
        for (int i = 50; i < 125; i++) // se superpone un poco para simular doble dosis
        {
            astrazeneca.Add($"Ciudadano {i}");
        }

        // Operaciones de teoría de conjuntos

        // 1. Ciudadanos no vacunados
        HashSet<string> noVacunados = new HashSet<string>(ciudadanos);
        noVacunados.ExceptWith(pfizer);
        noVacunados.ExceptWith(astrazeneca);

        // 2. Ciudadanos con ambas dosis (Pfizer ∩ AstraZeneca)
        HashSet<string> ambasDosis = new HashSet<string>(pfizer);
        ambasDosis.IntersectWith(astrazeneca);

        // 3. Ciudadanos solo con Pfizer
        HashSet<string> soloPfizer = new HashSet<string>(pfizer);
        soloPfizer.ExceptWith(astrazeneca);

        // 4. Ciudadanos solo con AstraZeneca
        HashSet<string> soloAstraZeneca = new HashSet<string>(astrazeneca);
        soloAstraZeneca.ExceptWith(pfizer);

        // Mostrar resultados
        Console.WriteLine("=== Ciudadanos que no se han vacunado ===");
        Console.WriteLine(string.Join(", ", noVacunados.Take(20)) + " ..."); // solo muestro 20 para no saturar

        Console.WriteLine("\n=== Ciudadanos con ambas dosis ===");
        Console.WriteLine(string.Join(", ", ambasDosis));

        Console.WriteLine("\n=== Ciudadanos solo Pfizer ===");
        Console.WriteLine(string.Join(", ", soloPfizer));

        Console.WriteLine("\n=== Ciudadanos solo AstraZeneca ===");
        Console.WriteLine(string.Join(", ", soloAstraZeneca));
    }
}
