using System;

class Nodo
{
    public int Dato;
    public Nodo Siguiente;

    public Nodo(int dato)
    {
        Dato = dato;
        Siguiente = null;
    }
}

class ListaEnlazada
{
    public Nodo Cabeza;

    public void InsertarAlFinal(int dato)
    {
        Nodo nuevo = new Nodo(dato);
        if (Cabeza == null)
        {
            Cabeza = nuevo;
        }
        else
        {
            Nodo actual = Cabeza;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevo;
        }
    }

    // Ejercicio 1: Contar elementos
    public int ContarElementos()
    {
        int contador = 0;
        Nodo actual = Cabeza;
        while (actual != null)
        {
            contador++;
            actual = actual.Siguiente;
        }
        return contador;
    }

    // Ejercicio 2: Invertir la lista
    public void Invertir()
    {
        Nodo anterior = null;
        Nodo actual = Cabeza;
        Nodo siguiente = null;

        while (actual != null)
        {
            siguiente = actual.Siguiente;
            actual.Siguiente = anterior;
            anterior = actual;
            actual = siguiente;
        }

        Cabeza = anterior;
    }

    public void MostrarLista()
    {
        Nodo actual = Cabeza;
        while (actual != null)
        {
            Console.Write(actual.Dato + " -> ");
            actual = actual.Siguiente;
        }
        Console.WriteLine("null");
    }

    public void CargarDatosEjemplo()
    {
        InsertarAlFinal(10);
        InsertarAlFinal(20);
        InsertarAlFinal(30);
        InsertarAlFinal(40);
    }
}

class Program
{
    static void Main(string[] args)
    {
        ListaEnlazada lista = new ListaEnlazada();
        lista.CargarDatosEjemplo();

        int opcion;
        do
        {
            Console.WriteLine("\nMENÚ DE OPCIONES:");
            Console.WriteLine("1. Contar elementos (Ejercicio 1)");
            Console.WriteLine("2. Invertir la lista (Ejercicio 2)");
            Console.WriteLine("3. Mostrar lista");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine($"Cantidad de elementos: {lista.ContarElementos()}");
                    break;
                case 2:
                    lista.Invertir();
                    Console.WriteLine("Lista invertida correctamente.");
                    break;
                case 3:
                    Console.WriteLine("Contenido de la lista:");
                    lista.MostrarLista();
                    break;
                case 0:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        } while (opcion != 0);
    }
}
