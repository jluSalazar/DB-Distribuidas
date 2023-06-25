using System;
using System.Data;
using System.Windows.Forms;
using WinAppBiblioteca.Logica;
using WinAppBiblioteca.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace WinAppBiblioteca.Forms
{
    public partial class UpdateForm : Form
    {
        Read readAux;
        Update updateAux;
        public UpdateForm()
        {
            InitializeComponent();
            readAux = new Read();
            updateAux = new Update();
        }

        //Mostrar Registros en el DGV
        private void UpdateForm_Load(object sender, EventArgs e)
        {
            this.ListarDGV();
        }

        private void ListarDGV()
        {
            string tabName = this.tabControl1.SelectedTab.Text;
            DGVGeneral.DataSource = readAux.Listar(tabName);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ListarDGV();
        }

        private void DGVGeneral_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DGVGeneral.Rows[e.RowIndex];
                switch (tabControl1.SelectedIndex)
                {
                    case 0:

                        // Obtener los valores de las columnas del registro seleccionado
                        int codigoLibro = Convert.ToInt32(row.Cells["codigo_libro"].Value);
                        string nombreLibro = row.Cells["nombre_libro"].Value.ToString();
                        string fechaPublicacion = row.Cells["fecha_publicacion"].Value.ToString();
                        string edicion = row.Cells["edicion"].Value.ToString();
                        string nombreAutor = row.Cells["nombre_autor"].Value.ToString();
                        string apellidoAutor = row.Cells["apellido_autor"].Value.ToString();
                        string categoria = row.Cells["categoria"].Value.ToString();
                        int stock = Convert.ToInt32(row.Cells["stock"].Value);
                        int disponibilidad = Convert.ToInt32(row.Cells["disponibilidad"].Value);

                        // Establecer los valores en los cuadros de texto
                        txt_Cod_Lib.Text = codigoLibro.ToString();
                        txt_Name_Lib.Text = nombreLibro;
                        txt_PubDate_Lib.Text = fechaPublicacion;
                        txt_Ed_Lib.Text = edicion;
                        txt_NameAutor_Lib.Text = nombreAutor;
                        txt_LNameAu_Lib.Text = apellidoAutor;
                        txt_Cat_Lib.Text = categoria;
                        txt_Stock_Lib.Text = stock.ToString();
                        txt_Disp_Lib.Text = disponibilidad.ToString();
                        break;
                    case 1:
                        // Obtener los valores de las columnas del registro seleccionado
                        int codigoEstudiante = Convert.ToInt32(row.Cells["codigo_estudiante"].Value);
                        string nombreEstudiante = row.Cells["nombre_estudiante"].Value.ToString();
                        string apellidoEstudiante = row.Cells["apellido_estudiante"].Value.ToString();
                        int celularEstudiante = Convert.ToInt32(row.Cells["celular_estudiante"].Value);
                        string sector = row.Cells["sector"].Value.ToString();
                        string facultad = row.Cells["facultad"].Value.ToString();
                        string correoEstudiante = row.Cells["correo_estudiante"].Value.ToString();

                        // Establecer los valores en los cuadros de texto
                        txt_Cod_Est.Text = codigoEstudiante.ToString();
                        txt_Name_Est.Text = nombreEstudiante;
                        txt_LName_Est.Text = apellidoEstudiante;
                        txt_Cel_Est.Text = celularEstudiante.ToString();
                        txt_Sector_Est.Text = sector;
                        txt_Fac_Est.Text = facultad;
                        txt_Correo_Est.Text = correoEstudiante;
                        break;
                    case 2:
                        // Obtener los valores de las columnas del registro seleccionado
                        int codigoPrestamo = Convert.ToInt32(row.Cells["codigo_prestamo"].Value);
                        int codigoLibro_Prest = Convert.ToInt32(row.Cells["codigo_libro"].Value);
                        int codigoEstudiante_Prest = Convert.ToInt32(row.Cells["codigo_estudiante"].Value);
                        string fechaPrestamo = row.Cells["fecha_prestamo"].Value.ToString();
                        string fechaDevolucion = row.Cells["fecha_devolucion"].Value.ToString();

                        // Por ejemplo, establecer los valores en los cuadros de texto
                        txt_Cod_Prest.Text = codigoPrestamo.ToString();
                        txt_CodLib_Prest.Text = codigoLibro_Prest.ToString();
                        txt_CodEst_Prest.Text = codigoEstudiante_Prest.ToString();
                        txt_FechaInicio_Prest.Text = fechaPrestamo;
                        txt_FechaFin_Prest.Text = fechaDevolucion;
                        break;

                }
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string tabName = this.tabControl1.SelectedTab.Text;
            DataRow row;
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    row = readAux.BuscarRegistroPorCodigo(tabName, txt_BuscarCodigo.Text, "codigo_libro");
                    if (row != null)
                    {
                        // Obtener los valores de las columnas del registro seleccionado
                        int codigoLibro = Convert.ToInt32(row["codigo_libro"]);
                        string nombreLibro = row["nombre_libro"].ToString();
                        string fechaPublicacion = row["fecha_publicacion"].ToString();
                        string edicion = row["edicion"].ToString();
                        string nombreAutor = row["nombre_autor"].ToString();
                        string apellidoAutor = row["apellido_autor"].ToString();
                        string categoria = row["categoria"].ToString();
                        int stock = Convert.ToInt32(row["stock"]);
                        int disponibilidad = Convert.ToInt32(row["disponibilidad"]);

                        // Establecer los valores en los cuadros de texto
                        txt_Cod_Lib.Text = codigoLibro.ToString();
                        txt_Name_Lib.Text = nombreLibro;
                        txt_PubDate_Lib.Text = fechaPublicacion;
                        txt_Ed_Lib.Text = edicion;
                        txt_NameAutor_Lib.Text = nombreAutor;
                        txt_LNameAu_Lib.Text = apellidoAutor;
                        txt_Cat_Lib.Text = categoria;
                        txt_Stock_Lib.Text = stock.ToString();
                        txt_Disp_Lib.Text = disponibilidad.ToString();
                    }

                    break;
                case 1:
                    row = readAux.BuscarRegistroPorCodigo(tabName, txt_BuscarCodigo.Text, "codigo_estudiante");
                    if (row != null)
                    {
                        // Obtener los valores de las columnas del registro seleccionado
                        int codigoEstudiante = Convert.ToInt32(row["codigo_estudiante"]);
                        string nombreEstudiante = row["nombre_estudiante"].ToString();
                        string apellidoEstudiante = row["apellido_estudiante"].ToString();
                        int celularEstudiante = Convert.ToInt32(row["celular_estudiante"]);
                        string sector = row["sector"].ToString();
                        string facultad = row["facultad"].ToString();
                        string correoEstudiante = row["correo_estudiante"].ToString();

                        // Establecer los valores en los cuadros de texto
                        txt_Cod_Est.Text = codigoEstudiante.ToString();
                        txt_Name_Est.Text = nombreEstudiante;
                        txt_LName_Est.Text = apellidoEstudiante;
                        txt_Cel_Est.Text = celularEstudiante.ToString();
                        txt_Sector_Est.Text = sector;
                        txt_Fac_Est.Text = facultad;
                        txt_Correo_Est.Text = correoEstudiante;
                    }
                    break;
                case 2:
                    row = readAux.BuscarRegistroPorCodigo(tabName, txt_BuscarCodigo.Text, "codigo_prestamo");
                    if (row != null)
                    {
                        // Obtener los valores de las columnas del registro seleccionado
                        int codigoPrestamo = Convert.ToInt32(row["codigo_prestamo"]);
                        int codigoLibro_Prest = Convert.ToInt32(row["codigo_libro"]);
                        int codigoEstudiante_Prest = Convert.ToInt32(row["codigo_estudiante"]);
                        string fechaPrestamo = row["fecha_prestamo"].ToString();
                        string fechaDevolucion = row["fecha_devolucion"].ToString();

                        // Por ejemplo, establecer los valores en los cuadros de texto
                        txt_Cod_Prest.Text = codigoPrestamo.ToString();
                        txt_CodLib_Prest.Text = codigoLibro_Prest.ToString();
                        txt_CodEst_Prest.Text = codigoEstudiante_Prest.ToString();
                        txt_FechaInicio_Prest.Text = fechaPrestamo;
                        txt_FechaFin_Prest.Text = fechaDevolucion;
                    }
                    break;
            }
        }

        private void btn_Update_Lib_Click(object sender, EventArgs e)
        {
            try
            {
                Libro libro = new Libro(int.Parse(txt_Cod_Lib.Text),
                    txt_Name_Lib.Text, txt_PubDate_Lib.Text, txt_Ed_Lib.Text,
                    txt_NameAutor_Lib.Text, txt_LNameAu_Lib.Text, txt_Cat_Lib.Text,
                    int.Parse(txt_Stock_Lib.Text), int.Parse(txt_Disp_Lib.Text));

                updateAux.ActualizarLibro(libro);
                this.ListarDGV();
                MessageBox.Show("Se ha actualizado el Registro", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Update_Est_Click(object sender, EventArgs e)
        {
            try
            {
                Estudiante estudiante = new Estudiante(int.Parse(txt_Cod_Est.Text),
                    txt_Name_Est.Text, txt_LName_Est.Text, int.Parse(txt_Cel_Est.Text),
                    txt_Sector_Est.Text, txt_Fac_Est.Text, txt_Correo_Est.Text);

                updateAux.ActualizarEstudiante(estudiante);
                this.ListarDGV();
                MessageBox.Show("Se ha actualizado el Registro", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Update_Prest_Click(object sender, EventArgs e)
        {
            try
            {
                Prestamo prestamo = new Prestamo(int.Parse(txt_Cod_Prest.Text),
                int.Parse(txt_CodLib_Prest.Text), int.Parse(txt_CodEst_Prest.Text),
                txt_FechaInicio_Prest.Text, txt_FechaFin_Prest.Text);
                updateAux.ActualizarPrestamo(prestamo);
                this.ListarDGV();
                MessageBox.Show("Se ha actualizado el Registro", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }

}
