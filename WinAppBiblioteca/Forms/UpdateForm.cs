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
            DGVGeneral.DataSource = readAux.Listar("Libro");
        }

        private void DGVGeneral_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DGVGeneral.Rows[e.RowIndex];
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
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            DataRow row = readAux.BuscarRegistroPorCodigo("Libro", txt_BuscarCodigo.Text, "codigo_libro");
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
    }

}
