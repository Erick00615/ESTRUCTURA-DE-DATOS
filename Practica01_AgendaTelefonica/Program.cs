using System;
using System.Collections.Generic;

namespace Practica01_AgendaTelefonica
{
    class Program
    {
        static List<Contacto> agenda = new List<Contacto>();

        static void Main()
        {
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("=== AGENDA TELEFÓNICA ===");
                Console.WriteLine("1. Agregar contacto");
                Console.WriteLine("2. Listar contactos");
                Console.WriteLine("3. Buscar contacto");
                Console.WriteLine("4. Editar contacto");
                Console.WriteLine("5. Eliminar contacto");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1: AgregarContacto(); break;
                    case 2: ListarContactos(); break;
                    case 3: BuscarContacto(); break;
                    case 4: EditarContacto(); break;
                    case 5: EliminarContacto(); break;
                }
            } while (opcion != 0);
        }

        static void AgregarContacto()
        {
            Console.Write("Ingrese nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese teléfono: ");
            string telefono = Console.ReadLine();
            agenda.Add(new Contacto(nombre, telefono));
            Console.WriteLine("Contacto agregado. Presione una tecla...");
            Console.ReadKey();
        }

        static void ListarContactos()
        {
            Console.WriteLine("== LISTA DE CONTACTOS ==");
            foreach (var c in agenda)
                Console.WriteLine(c);
            Console.ReadKey();
        }

        static void BuscarContacto()
        {
            Console.Write("Ingrese nombre a buscar: ");
            string nombre = Console.ReadLine();
            var resultado = agenda.Find(c => c.Nombre.ToLower() == nombre.ToLower());
            if (resultado != null)
                Console.WriteLine(resultado);
            else
                Console.WriteLine("Contacto no encontrado.");
            Console.ReadKey();
        }

        static void EditarContacto()
        {
            Console.Write("Ingrese nombre a editar: ");
            string nombre = Console.ReadLine();
            var contacto = agenda.Find(c => c.Nombre.ToLower() == nombre.ToLower());

            if (contacto != null)
            {
                Console.Write("Nuevo nombre: ");
                contacto.Nombre = Console.ReadLine();
                Console.Write("Nuevo teléfono: ");
                contacto.Telefono = Console.ReadLine();
                Console.WriteLine("Contacto editado.");
            }
            else
                Console.WriteLine("No encontrado.");
            Console.ReadKey();
        }

        static void EliminarContacto()
        {
            Console.Write("Ingrese nombre a eliminar: ");
            string nombre = Console.ReadLine();
            var contacto = agenda.Find(c => c.Nombre.ToLower() == nombre.ToLower());

            if (contacto != null)
            {
                agenda.Remove(contacto);
                Console.WriteLine("Eliminado.");
            }
            else
                Console.WriteLine("No encontrado.");
            Console.ReadKey();
        }
    }
}