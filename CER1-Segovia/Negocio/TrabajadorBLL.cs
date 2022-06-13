using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatosSQL;

namespace Negocio
{
    public class TrabajadorBLL
    {
        SegoviaEntities se = new SegoviaEntities();

        public TrabajadorBLL()
        {
           
        }

        public void Add(Trabajador t)
        {
            //Validaciones de negocio

            //Agregar a la colección
            //trabajadores.Add(t);

            //Agregar a la base de datos
            se.Trabajador.Add(t);   //INSERT INTO Trabajador VALUES(.....);
            se.SaveChanges();

        }

        public void Update(int id, string nombre, DateTime fechaNacimiento, Experiencia experiencia, Profesion profesion)
        {
            Trabajador t = Get(id);

            t.Nombre = nombre;
            t.FechaNacimiento = fechaNacimiento;
            t.Experiencia = experiencia.ToString();
            t.Profesion = profesion.ToString();

            se.SaveChanges();
        }

        public List<Trabajador> GetAll()
        {
            return se.Trabajador.ToList(); //SELECT * FROM Trabajador
        }

        public Trabajador Get(int id)
        {
            Trabajador trabajador = se.Trabajador.Where(t => t.Id == id).FirstOrDefault();
            return trabajador;
        }

        public void Delete(int id)
        {
            Trabajador trabajador = Get(id);
            se.Trabajador.Remove(trabajador);
            se.SaveChanges();
        }
    }
}
