using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo
{
    public class Persona
    {
        private int id;
        private int dni;
        private String nombre;
        private int edad;

        public Persona()
        {

        }

        public Persona(int dni, String nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.dni = dni;
        }

        public Persona(int dni, String nombre, int edad, int id)
        {
            this.dni = dni;
            this.id = id;
            this.nombre = nombre;
            this.edad = edad;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public int Dni { get => dni; set => dni = value; }
    }
}
