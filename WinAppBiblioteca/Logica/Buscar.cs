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
        public DataTable Listar( )
        {
            SQLiteDataReader Resultado;
            DataTable Tabla = new DataTable();
            SQLiteConnection SqlCon = new SQLiteConnection();
            try
            {
                SqlCon = Conexion.getInstancia().crearConexion();
                string Sql_tarea = "select * from libro" ;
                SQLiteCommand Comando = new SQLiteCommand(Sql_tarea, SqlCon);
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }


    }
    }
