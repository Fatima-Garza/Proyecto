using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;



namespace Papeleria_Cataluña
{
    class Conexion
    {
        public static MySqlConnection obtenerConexion()
        {
            MySqlConnection conexion = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=papeleria;");
            conexion.Open();
            return conexion;
        }
    }
}
