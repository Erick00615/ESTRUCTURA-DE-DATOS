﻿using System;
using System.Collections.Generic;

namespace Ejercicio
{
    class Curso
    {
        public List<string> Asignaturas { get; set; }

        public Curso()
        {
            Asignaturas = new List<string> { "Matemáticas", "Física", "Química", "Historia", "Lengua" };
        }

        public void MostrarAsignaturas()
        {
            Console.WriteLine("Asignaturas del curso:");
            foreach (var asignatura in Asignaturas)
            {
                Console.WriteLine(asignatura);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Curso curso = new Curso();
            curso.MostrarAsignaturas();
        }
    }
}