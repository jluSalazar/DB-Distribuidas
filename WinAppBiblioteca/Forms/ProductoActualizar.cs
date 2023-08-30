using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;
using WinAppBiblioteca.Logica;
using WinAppBiblioteca.Model;

namespace WinAppBiblioteca.Forms
{
    public partial class ProductoActualizar : Form
    {
        OracleConnection conn;
        
        bool IsMaster;
        public ProductoActualizar(bool ismaster)
        {
            InitializeComponent();
            IsMaster = ismaster;
        }
        public void ListarDGV()
        {
            txt_Codigo.ReadOnly = false;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            this.ListarDGV();
        }

        private void DGVLibro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DGVLibro.Rows[e.RowIndex];
                string codigoLibro = row.Cells["codigo_libro"].Value.ToString();
                string nombreLibro = row.Cells["nombre_libro"].Value.ToString();
                string fechaPublicacion = row.Cells["fecha_publicacion"].Value.ToString();
                string edicion = row.Cells["edicion"].Value.ToString();
                string nombreAutor = row.Cells["nombre_autor"].Value.ToString();
                string apellidoAutor = row.Cells["apellido_autor"].Value.ToString();
                string categoria = row.Cells["categoria"].Value.ToString();
                int stock = Convert.ToInt32(row.Cells["stock"].Value);
                int disponibilidad = Convert.ToInt32(row.Cells["disponibilidad"].Value);

                // Establecer los valores en los cuadros de texto
                txt_Codigo.Text = codigoLibro.ToString();
                txt_Nombre.Text = nombreLibro;
                txt_Desc.Text = fechaPublicacion;
                txt_PrecUnit.Text = edicion;

                txt_Codigo.ReadOnly = true;
            }
        }

        private void Btn_search_Click(object sender, EventArgs e)
        {
            DataRow row = readAux.BuscarRegistroPorCodigo("Libro", txt_Codigo.Text, "codigo_libro");
            if (row != null)
            {
                // Obtener los valores de las columnas del registro seleccionado
                string codigoLibro = row["codigo_libro"].ToString();
                string nombreLibro = row["nombre_libro"].ToString();
                string fechaPublicacion = row["fecha_publicacion"].ToString();
                string edicion = row["edicion"].ToString();
                string nombreAutor = row["nombre_autor"].ToString();
                string apellidoAutor = row["apellido_autor"].ToString();
                string categoria = row["categoria"].ToString();
                int stock = Convert.ToInt32(row["stock"]);
                int disponibilidad = Convert.ToInt32(row["disponibilidad"]);

                // Establecer los valores en los cuadros de texto
                txt_Codigo.Text = codigoLibro;
                txt_Nombre.Text = nombreLibro;
                txt_Desc.Text = fechaPublicacion;
                txt_PrecUnit.Text = edicion;

                txt_Codigo.ReadOnly = true;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string idProducto = txt_Codigo.Text;
            string nombreProducto = txt_Nombre.Text;
            string descripcion = txt_Desc.Text;
            float precioUnitario = ;

            // Valida y convierte el valor del TextBox de Precio Unitario a decimal
            if (!decimal.TryParse(txtPrecioUnitario.Text, out precioUnitario))
            {
                MessageBox.Show("El precio unitario no es válido.");
                return;
            }

            // Verifica que el campo IdProducto no esté vacío antes de la actualización
            if (string.IsNullOrWhiteSpace(idProducto))
            {
                MessageBox.Show("El campo IdProducto es obligatorio para la actualización.");
                return;
            }

            string updateQuery = "UPDATE Producto@replica_proyrad SET NombreProducto = :nombreProducto, Descripcion = :descripcion, PrecioUnitario = :precioUnitario " +
                                 "WHERE IdProducto = :idProducto";

            // Crea un objeto OracleCommand
            OracleCommand updateCommand = new OracleCommand(updateQuery, conn);

            // Asigna valores a los parámetros
            updateCommand.Parameters.Add(":idProducto", OracleDbType.Varchar2).Value = idProducto;
            updateCommand.Parameters.Add(":nombreProducto", OracleDbType.Varchar2).Value = nombreProducto;
            updateCommand.Parameters.Add(":descripcion", OracleDbType.Varchar2).Value = descripcion;
            updateCommand.Parameters.Add(":precioUnitario", OracleDbType.Decimal).Value = precioUnitario;

            try
            {
                // Abre la conexión y ejecuta la sentencia SQL de actualización
                conn.Open();
                updateCommand.ExecuteNonQuery();
                conn.Close();

                // Actualiza el DataGridView para mostrar los datos actualizados
                mostrardatos(); // Asumiendo que este método también muestra datos de productos
                MessageBox.Show("La actualización del producto se realizó con éxito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar producto: " + ex.Message);
            }
        }
        
        private void actualizar()
        {
            try
            {

            }
        }
        private void limpiarTxt()
        {
            this.txt_Codigo.ReadOnly= false;
            foreach (Control control in panel3.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                }
            }
        }

        private void DGVLibro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
