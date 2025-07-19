using System;
using System.Collections.Generic;

namespace NavegadorWeb
{
    class Navegador
    {
        private Stack<string> historial;

        public Navegador()
        {
            historial = new Stack<string>();
        }

        public void VisitarPagina(string url)
        {
            historial.Push(url);
            Console.WriteLine($"Has visitado: {url}");
        }

        public void Retroceder()
        {
            if (historial.Count > 1)
            {
                historial.Pop();
                Console.WriteLine($"Página actual: {historial.Peek()}");
            }
            else
            {
                Console.WriteLine("No hay páginas anteriores para retroceder.");
            }
        }

        public void MostrarHistorial()
        {
            Console.WriteLine("\nHistorial de navegación:");
            foreach (string pagina in historial)
            {
                Console.WriteLine(pagina);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Navegador navegador = new Navegador();
            navegador.VisitarPagina("https://www.google.com");
            navegador.VisitarPagina("https://www.wikipedia.org");
            navegador.VisitarPagina("https://www.openai.com");

            navegador.MostrarHistorial();

            Console.WriteLine("\n--- Presionando botón retroceder ---");
            navegador.Retroceder();
            navegador.MostrarHistorial();
        }
    }
}