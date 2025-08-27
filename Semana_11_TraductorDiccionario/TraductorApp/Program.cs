using System;


class Program
{
    // Diccionario inglés -> español
    static Dictionary<string, string> enToEs = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
    {
        {"time", "tiempo"},
        {"person", "persona"},
        {"year", "año"},
        {"way", "camino"},
        {"day", "día"},
        {"thing", "cosa"},
        {"man", "hombre"},
        {"world", "mundo"},
        {"life", "vida"},
        {"hand", "mano"},
        {"part", "parte"},
        {"child", "niño"},
        {"eye", "ojo"},
        {"woman", "mujer"},
        {"place", "lugar"},
        {"work", "trabajo"},
        {"week", "semana"},
        {"case", "caso"},
        {"point", "punto"},
        {"government", "gobierno"},
        {"company", "empresa"}
    };

    // Diccionario español -> inglés (se llena automáticamente)
    static Dictionary<string, string> esToEn = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

    static void Main()
    {
        // Llenamos el diccionario inverso
        foreach (var kvp in enToEs)
        {
            if (!esToEn.ContainsKey(kvp.Value))
                esToEn.Add(kvp.Value, kvp.Key);
        }

        int opcion;
        do
        {
            Console.WriteLine("==================== MENÚ ====================");
            Console.WriteLine("1. Traducir una frase");
            Console.WriteLine("2. Agregar palabras al diccionario");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
            
            if (!int.TryParse(Console.ReadLine(), out opcion)) opcion = -1;

            switch (opcion)
            {
                case 1:
                    TraducirFrase();
                    break;
                case 2:
                    AgregarPalabra();
                    break;
                case 0:
                    Console.WriteLine("¡Hasta luego!");
                    break;
                default:
                    Console.WriteLine("Opción inválida. Intente de nuevo.");
                    break;
            }
        } while (opcion != 0);
    }

    static void TraducirFrase()
    {
        Console.Write("Ingrese la frase: ");
        string frase = Console.ReadLine() ?? "";

        Console.Write("Seleccione el idioma de origen (es/en): ");
        string idioma = Console.ReadLine()?.ToLower() ?? "es";

        string[] palabras = frase.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < palabras.Length; i++)
        {
            string palabra = palabras[i].Trim(',', '.', ';', ':', '!', '?');

            string traduccion = null;
            if (idioma == "es" && esToEn.ContainsKey(palabra.ToLower()))
                traduccion = esToEn[palabra.ToLower()];
            else if (idioma == "en" && enToEs.ContainsKey(palabra.ToLower()))
                traduccion = enToEs[palabra.ToLower()];

            if (traduccion != null)
                palabras[i] = palabras[i].Replace(palabra, traduccion);
        }

        Console.WriteLine("Traducción: " + string.Join(" ", palabras));
    }

    static void AgregarPalabra()
    {
        Console.Write("Ingrese la palabra en inglés: ");
        string en = Console.ReadLine() ?? "";

        Console.Write("Ingrese la traducción en español: ");
        string es = Console.ReadLine() ?? "";

        if (!enToEs.ContainsKey(en.ToLower()))
        {
            enToEs.Add(en.ToLower(), es.ToLower());
        }

        if (!esToEn.ContainsKey(es.ToLower()))
        {
            esToEn.Add(es.ToLower(), en.ToLower());
        }

        Console.WriteLine("Palabra agregada correctamente.");
    }
}