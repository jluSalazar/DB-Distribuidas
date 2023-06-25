using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace WinAppBiblioteca.Logica
{
    public class Conexion
    {
        private string baseDatos;
        private static Conexion con = null;

        private Conexion() 
        {
            this.baseDatos = "./Biblioteca.db";
        }

        public SQLiteConnection crearConexion()
        {
            SQLiteConnection cadena = new SQLiteConnection();
            try
            {
                cadena.ConnectionString = "Data Source="+this.baseDatos;
            }
            catch (Exception ex)
            {
                cadena = null;
                throw ex;
            }
            return cadena;
        }

        public static Conexion getInstancia()
        {
            if (con == null)
            {
                con = new Conexion();
            }
            return con;
        }
    }
}
