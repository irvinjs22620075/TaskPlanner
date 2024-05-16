using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TaskPlanner
{
    class Conexion
    {
        public static MySqlConnection getConexion()

        {
            string server = "localhost";
           // string puerto = "3306";
            string database = "taskplanner";
            string user = "root";
            string password = "";

            string cadenaConexion = "server=" + server + "; user id=" + user + "; password=" + password + "; database=" + database;

            MySqlConnection conexion = new MySqlConnection(cadenaConexion);

            return conexion;
        }
    }
}       
