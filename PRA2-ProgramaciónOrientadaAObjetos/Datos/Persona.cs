using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Persona
    {
        private string _nombre;
        private string _apellido;
        private DateTime _fechaNacimiento;
        private string _telefono;
        private Clasificacion _grupo;
        

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public Clasificacion Grupo { get => _grupo; set => _grupo = value; }

        public int Edad { get => this.CalcularEdad(); }

        public Persona()
        {
            this.Grupo = Clasificacion.Default;
        }

        public Persona(string nombre, string apellido, DateTime fechaNacimiento, string telefono, Clasificacion grupo)
        {
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            Telefono = telefono;
            Grupo = grupo;
        }

        private int CalcularEdad()
        {
            int añoActual = DateTime.Today.Year;
            int añoNacimiento = this.FechaNacimiento.Year;

            int edad = añoActual - añoNacimiento;

            if (FechaNacimiento.AddYears(edad) > DateTime.Today)
            {
                edad--;
            }

            return edad;
        }

        public override string ToString()
        {
            string datos = "";
            datos += this.Nombre + " " + this.Apellido + "\n";
            datos += this.Telefono + "\n";
            datos += this.FechaNacimiento.ToString("dd MMMM") + " cumple " + this.Edad + "\n";
            datos += this.Grupo + "\n";
            return datos;
        }
    }
}
