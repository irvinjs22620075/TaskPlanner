using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TaskPlanner
{
    internal class ConexionMysql : Conexion
    {
        private MySqlConnection connection;

        public ConexionMysql()
        {
            // Utilizando el método GetConexion() de la clase base
            connection = getConexion();
        }

        public MySqlConnection GetConnection()
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return connection;
        }
    }

}
