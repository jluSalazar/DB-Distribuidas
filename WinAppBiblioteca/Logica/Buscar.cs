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

        public void OrdenarPorNombreLibroBurbuja(DataTable dt)
        {
            DataRow[] rows = dt.Select();

            for (int i = 0; i < rows.Length - 1; i++)
            {
                for (int j = 0; j < rows.Length - i - 1; j++)
                {
                    string nombreLibro1 = rows[j]["nombre_libro"].ToString();
                    string nombreLibro2 = rows[j + 1]["nombre_libro"].ToString();

                    if (string.Compare(nombreLibro1, nombreLibro2) > 0)
                    {
                        DataRow tempRow = rows[j];
                        rows[j] = rows[j + 1];
                        rows[j + 1] = tempRow;
                    }
                }
            }
        }

        public DataTable BuscarLibro(string texto)
        {
            SQLiteDataReader resultado;
            DataTable dt = new DataTable();
            SQLiteConnection sqlcon = new SQLiteConnection();

            try
            {
                sqlcon = Conexion.getInstancia().crearConexion();
                string sql_tarea = "SELECT * FROM Libro WHERE LOWER(nombre_libro) LIKE @texto OR codigo_libro LIKE @texto";
                SQLiteCommand cmd = new SQLiteCommand(sql_tarea, sqlcon);
                cmd.Parameters.AddWithValue("@texto", "%" + texto.ToLower() + "%");
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

        public int BuscarPorCodigoLibro(string codigo)
        {
            DataTable dt = listado("SELECT codigo_libro FROM Libro ORDER BY codigo_libro ASC");

            int inicio = 0;
            int fin = dt.Rows.Count - 1;

            while (inicio <= fin)
            {
                int medio = (inicio + fin) / 2;
                string codigoMedio = dt.Rows[medio]["codigo_libro"].ToString();

                if (codigoMedio == codigo)
                {
                    return medio; // Encontrado
                }
                else if (String.Compare(codigoMedio, codigo) > 0)
                {
                    fin = medio - 1; // Buscar en la mitad inferior
                }
                else
                {
                    inicio = medio + 1; // Buscar en la mitad superior
                }
            }

            return -1; // No encontrado
        }

    }
}
