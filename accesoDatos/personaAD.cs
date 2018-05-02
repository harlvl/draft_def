using modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accesoDatos
{
    public class personaAD
    {
        private BindingList<Persona> listaPersonas;
        public personaAD()
        {
            listaPersonas = new BindingList<Persona>();
            //temporalmente agregar aqui a las personas, luego se leeran de bd
            Persona p1 = new Persona("Luis", 23);
            Persona p2 = new Persona("Maria", 25);
            Persona p3 = new Persona("Piero", 19);
            listaPersonas.Add(p1);
            listaPersonas.Add(p2);
            listaPersonas.Add(p3);
        }

        public BindingList<Persona> listar()
        {
            return listaPersonas;
        }

        public bool modificar(int idPersona)
        {
            return false;
        }
    }
}
