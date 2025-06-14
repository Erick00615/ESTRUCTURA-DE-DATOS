using System;

namespace ArraysYMatrices
{
    class Estudiante
    {
        public int Id;
        public string Nombres;
        public string Apellidos;
        public string Direccion;
        public string[] Telefonos = new string[3];

        public void MostrarDatos()
        {
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Nombres: " + Nombres);
            Console.WriteLine("Apellidos: " + Apellidos);
            Console.WriteLine("Dirección: " + Direccion);
            Console.WriteLine("Teléfonos:");
            for (int i = 0; i < Telefonos.Length; i++)
            {
                Console.WriteLine($"Teléfono {i + 1}: {Telefonos[i]}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante = new Estudiante();

            estudiante.Id = 1;
            estudiante.Nombres = "Erick Anderson";
            estudiante.Apellidos = "Sarchi González";
            estudiante.Direccion = "Av. América y Mariana de Jesús";

            estudiante.Telefonos[0] = "0987654321";
            estudiante.Telefonos[1] = "0991122334";
            estudiante.Telefonos[2] = "022345678";

            estudiante.MostrarDatos();
        }
    }
}
