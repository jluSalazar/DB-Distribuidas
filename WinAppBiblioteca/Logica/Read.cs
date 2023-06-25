using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppBiblioteca.Logica
{
    public class Read
    {

        public DataTable Listar(string tableName)
        {
            SQLiteDataReader Resultado;
            DataTable Tabla = new DataTable();
            SQLiteConnection SqlCon = new SQLiteConnection();
            try
            {
                SqlCon = Conexion.getInstancia().crearConexion();
                string Sql_tarea = "select * from " + tableName;
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
