using accesoDatos;
using modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlador
{
    public class personaBL
    {
        private personaAD accesoDatos;
        public personaBL()
        {
            accesoDatos = new personaAD();
        }

        public BindingList<Persona> listar()
        {
            return accesoDatos.listar();
        }

        public bool modificar(Persona persona)
        {
            return accesoDatos.modificar(persona);
        }

        public int insertar(Persona persona)
        {
            return accesoDatos.insertar(persona);
        }
    }
}
