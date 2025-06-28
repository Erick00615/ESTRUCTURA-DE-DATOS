using System;
using System.Collections.Generic;

namespace Ejercicio3
{
    class Curso
    {
        public List<string> Asignaturas { get; set; }
        public Dictionary<string, double> Notas { get; set; }

        public Curso()
        {
            Asignaturas = new List<string> { "Matemáticas", "Física", "Química", "Historia", "Lengua" };
            Notas = new Dictionary<string, double>();
        }

        public void PedirNotas()
        {
            foreach (var asignatura in Asignaturas)
            {
                Console.Write($"¿Qué nota sacaste en {asignatura}? ");
                double nota = Convert.ToDouble(Console.ReadLine());
                Notas[asignatura] = nota;
            }
        }

        public void MostrarNotas()
        {
            Console.WriteLine("\nResumen de tus notas:");
            foreach (var item in Notas)
            {
                Console.WriteLine($"En {item.Key} has sacado {item.Value}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Curso curso = new Curso();
            curso.PedirNotas();
            curso.MostrarNotas();
        }
    }
}
