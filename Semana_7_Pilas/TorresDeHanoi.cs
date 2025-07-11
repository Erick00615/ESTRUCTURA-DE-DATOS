using System;
using System.Collections.Generic;

class TorresDeHanoi
{
    private Stack<int> origen = new Stack<int>();
    private Stack<int> auxiliar = new Stack<int>();
    private Stack<int> destino = new Stack<int>();
    private int totalDiscos;

    public TorresDeHanoi(int n)
    {
        totalDiscos = n;
        for (int i = n; i >= 1; i--)
            origen.Push(i);
    }

    public void Resolver()
    {
        Console.WriteLine("Estado inicial:");
        MostrarTorres();
        MoverDiscos(totalDiscos, origen, destino, auxiliar, "Origen", "Destino", "Auxiliar");
    }

    private void MoverDiscos(int n, Stack<int> desde, Stack<int> hacia, Stack<int> usando,
                             string desdeNombre, string haciaNombre, string usandoNombre)
    {
        if (n == 1)
        {
            int disco = desde.Pop();
            hacia.Push(disco);
            Console.WriteLine($"Mover disco {disco} de {desdeNombre} a {haciaNombre}");
            MostrarTorres();
            return;
        }

        MoverDiscos(n - 1, desde, usando, hacia, desdeNombre, usandoNombre, haciaNombre);
        MoverDiscos(1, desde, hacia, usando, desdeNombre, haciaNombre, usandoNombre);
        MoverDiscos(n - 1, usando, hacia, desde, usandoNombre, haciaNombre, desdeNombre);
    }

    private void MostrarTorres()
    {
        Console.WriteLine("Origen: " + String.Join(",", origen));
        Console.WriteLine("Auxiliar: " + String.Join(",", auxiliar));
        Console.WriteLine("Destino: " + String.Join(",", destino));
        Console.WriteLine();
    }

    public static void Probar()
    {
        Console.WriteLine("Ingrese el número de discos:");
        int n = int.Parse(Console.ReadLine());
        TorresDeHanoi hanoi = new TorresDeHanoi(n);
        hanoi.Resolver();
    }
}