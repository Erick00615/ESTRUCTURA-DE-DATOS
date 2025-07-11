using System;
using System.Collections.Generic;

class ParentesisBalanceados
{
    public static bool EstaBalanceado(string expresion)
    {
        Stack<char> pila = new Stack<char>();
        foreach (char c in expresion)
        {
            if (c == '(' || c == '{' || c == '[') pila.Push(c);
            else if (c == ')' || c == '}' || c == ']')
            {
                if (pila.Count == 0) return false;
                char ultimo = pila.Pop();
                if (!Coinciden(ultimo, c)) return false;
            }
        }
        return pila.Count == 0;
    }

    private static bool Coinciden(char abierto, char cerrado)
    {
        return (abierto == '(' && cerrado == ')') ||
               (abierto == '{' && cerrado == '}') ||
               (abierto == '[' && cerrado == ']');
    }

    public static void Probar()
    {
        Console.WriteLine("Ingrese una expresión matemática:");
        string expresion = Console.ReadLine();
        Console.WriteLine(EstaBalanceado(expresion) ? "Fórmula balanceada." : "Fórmula no balanceada.");
    }
}