using System;
using System.Collections.Generic;

namespace Ejercicio2
{
    class Curso
    {
        public List<string> Asignaturas { get; set; }

        public Curso()
        {
            Asignaturas = new List<string> { "Matemáticas", "Física", "Química", "Historia", "Lengua" };
        }

        public void MostrarFrases()
        {
            foreach (var asignatura in Asignaturas)
            {
                Console.WriteLine($"Yo estudio {asignatura}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Curso curso = new Curso();
            curso.MostrarFrases();
        }
    }
}