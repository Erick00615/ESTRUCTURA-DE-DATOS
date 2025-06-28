using System;
using System.Collections.Generic;

namespace Ejercicio4
{
    class Loteria
    {
        public List<int> Numeros { get; set; }

        public Loteria()
        {
            Numeros = new List<int>();
        }

        public void PedirNumeros()
        {
            Console.WriteLine("Ingresa 6 números ganadores de la lotería:");
            for (int i = 0; i < 6; i++)
            {
                Console.Write($"Número {i + 1}: ");
                int numero;
                while (!int.TryParse(Console.ReadLine(), out numero))
                {
                    Console.Write("Entrada inválida. Por favor, ingresa un número entero: ");
                }
                Numeros.Add(numero);
            }
        }

        public void MostrarOrdenados()
        {
            Numeros.Sort();
            Console.WriteLine("Números ordenados: " + string.Join(", ", Numeros));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Loteria loteria = new Loteria();
            loteria.PedirNumeros();
            loteria.MostrarOrdenados();
        }
    }
}