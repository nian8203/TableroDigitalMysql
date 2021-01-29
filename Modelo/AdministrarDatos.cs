using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using static Modelo.Conexion;

namespace Modelo
{
    public class AdministrarDatos
    {
        public MySqlConnection conexionDb;
        public string error;

        /*******constructor*****/
        public AdministrarDatos()
        {
            this.conexionDb = Conexion.getConnection();
        }


        public List<Personas> ListarPersonas()
        {
            List<Personas> mostrarPersonas = new List<Personas>();
            string sql = "select * from personas";
            MySqlCommand cmd = new MySqlCommand(sql, conexionDb);
            MySqlDataReader registro = cmd.ExecuteReader();

            while (registro.Read())
            {
                Personas p = new Personas();

                p.id = registro.GetString(0);
                p.nombre = registro.GetString(1);
                p.apellido = registro.GetString(2);
                p.telefono = registro.GetString(3);
                p.direccion = registro.GetString(4);
                p.correo = registro.GetString(5);
                p.password = registro.GetString(6);
                p.idRol = registro.GetInt32(7);

                mostrarPersonas.Add(p);
            }
            registro.Close();
            return mostrarPersonas;
        }

        public List<Alumnos> ListarAlumnos()
        {List<Alumnos> mostrarAlumnos = new List<Alumnos>();
            string sql = "select * from alumnos";
            MySqlCommand cmd = new MySqlCommand(sql, conexionDb);
            MySqlDataReader registro = cmd.ExecuteReader();

            while (registro.Read())
            {
                Alumnos empleado = new Alumnos();

                empleado.id = registro.GetString(0);
                empleado.nombre = registro.GetString(1);
                empleado.apellido = registro.GetString(2);
                empleado.telefono = registro.GetString(3);
                empleado.direccion = registro.GetString(4);
                empleado.correo = registro.GetString(5);
                empleado.fechaNacimiento = registro.GetDateTime(6);

                mostrarAlumnos.Add(empleado);
            }
            registro.Close();
            return mostrarAlumnos;
        }



       
        
       

       


    }
}
