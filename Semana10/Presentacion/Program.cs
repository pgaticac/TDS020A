using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Presentacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            persona.Nombre = "Pedro";  //set
            persona.Apellido = "Parker"; //set
            persona.FechaNacimiento = new DateTime(2000, 5, 14);

            Persona otraPersona = new Persona("Antonio", "Stark");
            otraPersona.FechaNacimiento = new DateTime(1980, 9, 24);

          

            Console.WriteLine("Persona: " + persona.Nombre + " " + persona.Apellido + " " + persona.Edad + " años"); //get
            Console.WriteLine(otraPersona);

            Console.ReadKey();
        }
    }
}

