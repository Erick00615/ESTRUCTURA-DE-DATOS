using System;
using System.Collections.Generic;

namespace Ejercicio5
{
    class Numeros
    {
        public List<int> NumerosLista { get; set; }

        public Numeros()
        {
            NumerosLista = new List<int>();
            for (int i = 1; i <= 10; i++)
            {
                NumerosLista.Add(i);
            }
        }

        public void MostrarInverso()
        {
            NumerosLista.Reverse();
            Console.WriteLine("Números del 10 al 1 separados por comas:");
            Console.WriteLine(string.Join(", ", NumerosLista));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Numeros numeros = new Numeros();
            numeros.MostrarInverso();
        }
    }
}