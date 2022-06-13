//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatosSQL
{
    using System;
    using System.Collections.Generic;

    public partial class Trabajador
    {
        private DateTime _fechaNacimiento;

        public int Id { get; set; }
        public string Nombre { get; set; }
        public System.DateTime FechaNacimiento
        {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value; }
        }
        public string Profesion { get; set; }
        public string Experiencia { get; set; }

        public int Edad
        {
            get { return this.CalcularEdad(); }

        }

        public int Sueldo
        {
            get { return this.CalcularSueldo(); }
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

            if (Profesion == Oficio.Soldador.ToString())
            {
                sueldoBase = 860000;
            }

            if (Profesion == Oficio.Ceramista.ToString() || Profesion == Oficio.Pintor.ToString() || Profesion == Oficio.Carpintero.ToString())
            {
                sueldoBase = 680000;
            }

            if (Profesion == Oficio.Constructor.ToString() || Profesion == Oficio.Ingeniero.ToString() || Profesion == Oficio.Arquitecto.ToString())
            {
                sueldoBase = 1300000;
            }

            if (Experiencia == Jerarquia.Maestro.ToString())
            {
                bonoExperiencia = sueldoBase * 20 / 100;
            }

            if (Experiencia == Jerarquia.Instructor.ToString())
            {
                bonoExperiencia = sueldoBase * 50 / 100;
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

            if (Experiencia == Jerarquia.Maestro.ToString())
            {
                bono = "Bono Experiencia 20%";
            }

            if (Experiencia == Jerarquia.Instructor.ToString())
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

    public enum Oficio
    {
        Soldador,
        Ceramista,
        Pintor,
        Carpintero,
        Constructor,
        Ingeniero,
        Arquitecto
    }

    public enum Jerarquia
    {
        Junior,
        Maestro,
        Instructor
    }
}
