using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Telefono { get; set; }
        public Grupo Grupo { get; set; }

        public int Edad
        {
            get
            {
                return DateTime.Today.Year - FechaNacimiento.Year;
            }
        }

        public Persona()
        {
            this.Grupo = Grupo.Default;
        }

        public Persona(string  nombre, string apellido, DateTime fechaNacimiento, string telefono)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.FechaNacimiento = fechaNacimiento;
            this.Telefono = telefono;
            this.Grupo = Grupo.Default;
        }

        public override string ToString()
        {
            string datos = "";

            datos = Nombre + " " + Apellido;
            datos += "\n" + Telefono;
            datos += "\n" + Edad + " años";
            datos += "\n Grupo: " + Grupo;
            return datos;
        }
    }
}
