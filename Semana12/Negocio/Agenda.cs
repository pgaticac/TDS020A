using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class Agenda
    {
        private List<Persona> _contactos;

        public Agenda()
        {
            _contactos = new List<Persona>();

            
        }

        public void Add(Persona p)
        {
            //validaciones
            _contactos.Add(p);
        }

        public List<Persona> GetAll()
        {
            return _contactos;
        }
    }
}
