using System;

// Clase que representa un Círculo
public class Circulo
{
    // Atributo privado para almacenar el radio
    private double radio;

    // Constructor para inicializar el radio del círculo
    public Circulo(double radio)
    {
        this.radio = radio;
    }

    // Método para calcular el área del círculo
    public double CalcularArea()
    {
        return Math.PI * radio * radio;
    }

    // Método para calcular el perímetro del círculo
    public double CalcularPerimetro()
    {
        return 2 * Math.PI * radio;
    }
}

// Clase que representa un Rectángulo
public class Rectangulo
{
    private double largo;
    private double ancho;

    public Rectangulo(double largo, double ancho)
    {
        this.largo = largo;
        this.ancho = ancho;
    }

    public double CalcularArea()
    {
        return largo * ancho;
    }

    public double CalcularPerimetro()
    {
        return 2 * (largo + ancho);
    }
}

// Clase principal para probar las figuras
public class Programa
{
    public static void Main(string[] args)
    {
        Circulo miCirculo = new Circulo(5.0);
        Console.WriteLine("Área del círculo: " + miCirculo.CalcularArea());
        Console.WriteLine("Perímetro del círculo: " + miCirculo.CalcularPerimetro());

        Rectangulo miRectangulo = new Rectangulo(10.0, 4.0);
        Console.WriteLine("Área del rectángulo: " + miRectangulo.CalcularArea());
        Console.WriteLine("Perímetro del rectángulo: " + miRectangulo.CalcularPerimetro());
    }
}