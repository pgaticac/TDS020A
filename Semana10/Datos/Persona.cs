using System;

namespace Datos
{
    public class Persona
    {
        private string _nombre;
        private string _apellido;
        private DateTime _fechaNacimiento;
        

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }

        public int Edad
        {
            get
            {
                return this.CalcularEdad();
            }
        }

        public Persona()
        {

        }

        public Persona(string nombre, string apellido)
        {
            this._nombre = nombre;  //asigno directamente en el campo. En java: this.nombre = nombre;
            this.Apellido = apellido; //asigno mediante su propiedad. En java: this.setApellido(apellido);
        }

        private int CalcularEdad()
        {
            int añoActual = DateTime.Today.Year;
            int añoNacimiento = this.FechaNacimiento.Year;

            return añoActual - añoNacimiento;
        }

      
        public override string ToString()
        {
            return this.Nombre + " " + this.Apellido + " " + this.Edad + " años";
        }



    }
}
