using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Agenda
    {
        List<Persona> contactos;

        public Agenda()
        {
            contactos = new List<Persona>();
        }

        public void Add(Persona p)
        {
            contactos.Add(p);
        }

        public List<Persona> getAll() {
            return this.contactos;
        }

        public List<Persona> getPersonas(string filtro) {
            List<Persona> contactosFiltrados = new List<Persona>();

            foreach (Persona p in contactos)
            {
                if (p.Nombre.ToLower() == filtro.ToLower() || p.Apellido.ToLower() == filtro.ToLower())  //Para omitir mayusculas/minusculas usar ToLower() o ToUpper() en la comparación
                {
                    contactosFiltrados.Add(p);
                }
            }

            return contactosFiltrados;
                
        }


    }
}
