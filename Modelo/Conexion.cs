using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Modelo
{
    public class Conexion
    {
        
            /**********************DEFINIR VARIBLES*********************************/
            private static MySqlConnection connection;
            private static string error;

            /*********************METODOS DE CONEXION*******************************/

            public static MySqlConnection getConnection()
            {
                if (connection != null)
                    return connection;

                connection = new MySqlConnection("Server = localhost; user = nian; password = 8203; Database = pruebaV3; ;Convert Zero Datetime=True");

                try
                {
                    connection.Open();
                    return connection;
                }
                catch (Exception e)
                {
                    error = e.Message;
                    return null;
                }
            }
        
    }
}
