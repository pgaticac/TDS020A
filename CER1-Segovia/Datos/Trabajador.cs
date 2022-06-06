using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Trabajador
    {
        private string _nombre;
        private DateTime _fechaNacimiento;
        private Profesion _profesion;
        private Experiencia _experiencia;


        //public string Nombre { get => _nombre; set => _nombre = value; }

        public string Nombre
        {
            get { return _nombre; }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _nombre = value;
                }
            }
        }

        // public DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }

        public DateTime FechaNacimiento
        {
            get { return _fechaNacimiento; }
            set
            {
                if (this.FechaNacimiento <= DateTime.Today)
                {
                    _fechaNacimiento = value;
                }

            }
        }

        public Profesion Profesion { get => _profesion; set => _profesion = value; }
        public Experiencia Experiencia { get => _experiencia; set => _experiencia = value; }

        public int Edad
        {
            get { return this.CalcularEdad(); }

        }

        public int Sueldo
        {
            get { return this.CalcularSueldo();  }
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

        private int CalcularSueldo()
        {
            int sueldoBase = 0;
            int bonoExperiencia = 0;
            int bonoEdad = 0;

            switch (Profesion)
            {
                case Profesion.Soldador:
                    sueldoBase = 860000;
                    break;
                case Profesion.Ceramista:
                case Profesion.Pintor:
                case Profesion.Carpintero:
                    sueldoBase = 680000;
                    break;
                case Profesion.Constructor:
                case Profesion.Ingeniero:
                case Profesion.Arquitecto:
                    sueldoBase = 1300000;
                    break;
                default:
                    sueldoBase = 0;
                    break;
            }

            switch (Experiencia)
            {
                case Experiencia.Junior:
                    bonoExperiencia = 0;
                    break;
                case Experiencia.Maestro:
                    bonoExperiencia = sueldoBase * 20 / 100;
                    break;
                case Experiencia.Instructor:
                    bonoExperiencia = sueldoBase * 50 / 100;
                    break;
                default:
                    bonoExperiencia = 0;
                    break;
            }

            if (Edad > 55)
            {
                bonoEdad = 150000;
            }
            else
            {
                if (Edad < 30)
                {
                    bonoEdad = 100000;
                }
            }

            int sueldoTotal = sueldoBase + bonoExperiencia + bonoEdad;
            return sueldoTotal;

        }

        public override string ToString()
        {
            string datos = "";
            string bono = "Sin bono";

            datos += "Nombre: " + this.Nombre + " \n";
            datos += "Edad: " + this.Edad + " \n";
            datos += "Cargo: " + this.Profesion + "\n";
            datos += "Experiencia: " + this.Experiencia + "\n";

            if (Experiencia == Experiencia.Maestro)
            {
                bono = "Bono Experiencia 20%";
            }

            if (Experiencia == Experiencia.Instructor)
            {
                bono = "Bono Experiencia 50%";
            }

            if (Edad < 30)
            {
                bono += " - Bono Trabajador Joven";
            }

            if (Edad > 55)
            {
                bono += " - Bono Trayectoria";
            }

            datos += "Bonos: " + bono + "\n";
            datos += "Sueldo: $" + this.Sueldo + "\n";

            return datos;


        }
    }

    

}



