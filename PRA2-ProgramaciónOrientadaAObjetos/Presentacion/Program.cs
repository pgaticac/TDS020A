using Negocio;
using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Agenda miAgenda = new Agenda();

            Persona uno = new Persona("Pedro", "Parker", new DateTime(1999, 7, 6), "+5697845123", Datos.Clasificacion.Amigos);
            Persona dos = new Persona("Antonio", "Stark", new DateTime(1980, 9, 24), "+56999856422", Clasificacion.Trabajo);
            Persona tres = new Persona("Pedro", "Stark", new DateTime(1972, 11, 2), "+56978451251", Clasificacion.Familia);

            miAgenda.Add(uno);
            miAgenda.Add(dos);
            miAgenda.Add(tres);

            foreach (Persona persona in miAgenda.getAll())
            {
                Console.WriteLine(persona);
            }

            Console.Write("Ingresa filtro: ");
            string filtro = Console.ReadLine();

            Console.WriteLine();

            List<Persona> filtrados = miAgenda.getPersonas(filtro);

            if (filtrados.Count() != 0)
            {
                foreach (Persona persona in filtrados)
                {
                    Console.WriteLine(persona);
                }
            }
            else
            {
                Console.WriteLine("No existen coincidencias");
            }

            Console.ReadKey();

        }
    }
}
