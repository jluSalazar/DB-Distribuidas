using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppBiblioteca.Logica
{
    
        internal class Buscar
        {
        public Buscar()
        {
            

        }
        public DataTable listado(string sqlconection)
        {

            SQLiteDataReader resultado;
            DataTable dt = new DataTable();
            SQLiteConnection sqlcon = new SQLiteConnection();

            try
            {
                sqlcon = Conexion.getInstancia().crearConexion();
                string sql_tarea = sqlconection;
                SQLiteCommand cmd = new SQLiteCommand(sql_tarea, sqlcon);
                sqlcon.Open();
                resultado = cmd.ExecuteReader();
                dt.Load(resultado);
                return dt;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }


        }


    }
    }
