using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinAppBiblioteca.Model;
using System.Windows.Forms;

namespace WinAppBiblioteca.Logica
{
    public class Update
    {
        SQLiteConnection SqlCon = new SQLiteConnection(); //Crea la conexion
        string sqlActualizar; // Sentencia SQL de actualizar
        SQLiteCommand Comando; //Ejecuta la sentencia SQL con la DB conectada

        public void ActualizarLibro(Libro libro)
        {
            try
            {
                SqlCon = Conexion.getInstancia().crearConexion();
                sqlActualizar = "UPDATE Libro SET nombre_libro = @NombreLibro, fecha_publicacion = @Fecha, edicion = @Edicion, nombre_autor = @AutorNombre, apellido_autor = @AutorApellido, categoria = @Categoria, stock = @Stock, disponibilidad = @Disponibilidad WHERE codigo_libro = @CodigoLibro";
                Comando = new SQLiteCommand(sqlActualizar, SqlCon);

                // Agregar parámetros 
                Comando.Parameters.AddWithValue("@NombreLibro", libro.NombreLibro);
                Comando.Parameters.AddWithValue("@Fecha", libro.FechaPublicacion);
                Comando.Parameters.AddWithValue("@Edicion", libro.Edicion);
                Comando.Parameters.AddWithValue("@AutorNombre", libro.NombreAutor);
                Comando.Parameters.AddWithValue("@AutorApellido", libro.ApellidoAutor);
                Comando.Parameters.AddWithValue("@Categoria", libro.Categoria);
                Comando.Parameters.AddWithValue("@Stock", libro.Stock);
                Comando.Parameters.AddWithValue("@Disponibilidad", libro.Disponibilidad);
                Comando.Parameters.AddWithValue("@CodigoLibro", libro.CodigoLibro);

                SqlCon.Open();
                Comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        public void ActualizarEstudiante(Estudiante estudiante)
        {
            try
            {
                SqlCon = Conexion.getInstancia().crearConexion();
                sqlActualizar = "UPDATE Estudiante SET nombre_estudiante = @NombreEstudiante, apellido_estudiante = @ApellidoEstudiante, celular_estudiante = @CelularEstudiante, sector = @Sector, facultad = @Facultad, correo_estudiante = @CorreoEstudiante WHERE codigo_estudiante = @CodigoEstudiante";
                Comando = new SQLiteCommand(sqlActualizar, SqlCon);

                // Agregar parámetros
                Comando.Parameters.AddWithValue("@NombreEstudiante", estudiante.NombreEstudiante);
                Comando.Parameters.AddWithValue("@ApellidoEstudiante", estudiante.ApellidoEstudiante);
                Comando.Parameters.AddWithValue("@CelularEstudiante", estudiante.CelularEstudiante);
                Comando.Parameters.AddWithValue("@Sector", estudiante.Sector);
                Comando.Parameters.AddWithValue("@Facultad", estudiante.Facultad);
                Comando.Parameters.AddWithValue("@CorreoEstudiante", estudiante.CorreoEstudiante);
                Comando.Parameters.AddWithValue("@CodigoEstudiante", estudiante.CodigoEstudiante);

                SqlCon.Open();
                Comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        public void ActualizarPrestamo(Prestamo prestamo)
        {
            try
            {
                SqlCon = Conexion.getInstancia().crearConexion();
                sqlActualizar = "UPDATE Prestamo SET codigo_libro = @CodigoLibro, codigo_estudiante = @CodigoEstudiante, fecha_prestamo = @FechaPrestamo, fecha_devolucion = @FechaDevolucion WHERE codigo_prestamo = @CodigoPrestamo";
                Comando = new SQLiteCommand(sqlActualizar, SqlCon);

                // Agregar parámetros
                Comando.Parameters.AddWithValue("@CodigoLibro", prestamo.CodigoLibro);
                Comando.Parameters.AddWithValue("@CodigoEstudiante", prestamo.CodigoEstudiante);
                Comando.Parameters.AddWithValue("@FechaPrestamo", prestamo.FechaPrestamo);
                Comando.Parameters.AddWithValue("@FechaDevolucion", prestamo.FechaDevolucion);
                Comando.Parameters.AddWithValue("@CodigoPrestamo", prestamo.CodigoPrestamo);

                SqlCon.Open();
                Comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }
    }
}
