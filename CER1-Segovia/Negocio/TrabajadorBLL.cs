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

        public List<Trabajador> getAll()
        {
            return se.Trabajador.ToList(); //SELECT * FROM Trabajador
        }
    }
}
