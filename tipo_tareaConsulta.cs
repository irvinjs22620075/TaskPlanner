using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TaskPlanner
{
    internal class tipo_tareaConsulta
    {
        private ConexionMsql conexionMsql;
        private List<tipo_tarea> mTareas;
        public tipo_tareaConsulta()
        {
            conexionMsql = new ConexionMsql();
            mTareas = new List<tipo_tarea>();
        }

      public List<tipo_tarea> getTareas(string filtro)
        {
            string QUERY = "SELECT * FROM  tipo_tareas ";
            MySqlDataReader mnReader = null;
           
            try
            {
                if (filtro != "") 
                {
                    QUERY += "WHERE" +
                        "id LIKE '%" + filtro + "%' OR " +
                        "titulo_tarea LIKE '%" + filtro + "%' OR"+
                        "informacion LIKE '%" + filtro + "%' OR " +
                        "fecha LIKE '%" + filtro + "%'; ";

                }
                MySqlCommand mComando = new MySqlCommand(QUERY);
                mComando.Connection = conexionMsql.GetConnection();
              mnReader = mComando.ExecuteReader();

                tipo_tarea mTarea = null;
                while (mnReader.Read())
                {
                    mTarea = new tipo_tarea();
                    mTarea.id = mnReader.GetInt16("id");
                    mTarea.titulo_tarea = mnReader.GetString("titulo_tarea");
                    mTarea.informacion = mnReader.GetString("informacion");
                    mTarea.fecha = mnReader.GetString("fecha");
                    mTareas.Add(mTarea);
                
                }
                mnReader.Close();
            }
            catch (Exception  ){

            }
            return mTareas;
        }
        
    }

}
