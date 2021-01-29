using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class LoginClass
    {

        public MySqlConnection conexionDb;
        public string error;

        public LoginClass()
        {
            this.conexionDb = Conexion.getConnection();
        }


        public Boolean validarCorreo(string correo, string password)
        {
            string sql = "select * from personas where (correo = @correo and password = @password)";
            MySqlCommand cmd = new MySqlCommand(sql, conexionDb);
            cmd.Parameters.AddWithValue("@correo", correo);
            cmd.Parameters.AddWithValue("@password", password);
            MySqlDataReader registro = cmd.ExecuteReader();

            if (registro.Read())
            {
                registro.Close();
                return true;
            }
            else
            {
                registro.Close();
                return false;
            }
        }

       



    }
}
