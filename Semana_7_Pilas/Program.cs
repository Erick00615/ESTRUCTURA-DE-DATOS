using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Seleccione el ejercicio a ejecutar:");
        Console.WriteLine("1 - Verificación de paréntesis balanceados");
        Console.WriteLine("2 - Torres de Hanoi con pilas");

        string opcion = Console.ReadLine();

        if (opcion == "1")
            ParentesisBalanceados.Probar();
        else if (opcion == "2")
            TorresDeHanoi.Probar();
        else
            Console.WriteLine("Opción no válida.");
    }
}