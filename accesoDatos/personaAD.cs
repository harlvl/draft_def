using modelo;
using MySql.Data.MySqlClient;
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
        private String server;
        private String user;
        private String password;
        public personaAD()
        {
            listaPersonas = new BindingList<Persona>();
            //llenar credenciales antes de ejecutar
            server = "ssssssssssssss";
            user = "uuuuuuuuuuuuuu";
            password = "ppppppppppp";
        }

        public BindingList<Persona> listar()
        {
            //usando bd
            String url = "server="+ server + ";" +
                "user=" + user + ";database=a20121532;" +
                "port=3306;password=" + password + ";SslMode=none;" +
                "";
            MySqlConnection con = new MySqlConnection(url);
            con.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "SELECT * FROM persona";
            comando.Connection = con;
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Persona p = new Persona();
                p.Id = reader.GetInt32("idPersona");
                p.Nombre = reader.GetString("nombre");
                p.Edad = reader.GetInt32("edad");
                p.Dni = reader.GetInt32("dni");
                listaPersonas.Add(p);
            }
            con.Close();
            return listaPersonas;
        }
        public int insertar(Persona p)
        {
            String url = "server=" + server + ";" +
                "user=" + user + ";database=a20121532;" +
                "port=3306;password=" + password + ";SslMode=none;" +
                "";
            MySqlConnection con = new MySqlConnection(url);
            con.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "insertarPersona";
            comando.Connection = con;
            comando.Parameters.Add("_nombre", MySqlDbType.VarChar).Value =
                p.Nombre;
            comando.Parameters.Add("_edad", MySqlDbType.Int32).Value =
                p.Edad;
            comando.Parameters.Add("_dni", MySqlDbType.Int32).Value =
                p.Dni;
            comando.Parameters.Add("_id", MySqlDbType.Int32).Direction =
                System.Data.ParameterDirection.Output;
            comando.ExecuteNonQuery();
            con.Close();

            return Int32.Parse
            (comando.Parameters["_id"].Value.ToString());
        }

        public bool modificar(Persona persona)
        {
            return true;
        }
    }
}
