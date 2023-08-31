using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppBiblioteca.Forms
{
    public partial class InventarioActualizar : Form
    {
        OracleConnection conn;
        string conStr = @"DATA SOURCE = localhost:1521/orcl; USER ID=jsalazar;PASSWORD=jsalazar";

        bool IsMaster;
        public InventarioActualizar(bool ismaster)
        {
            InitializeComponent();
            conn = new OracleConnection(conStr);
            IsMaster = ismaster;
        }
        private void ListarDGV()
        {

            string consulta = "SELECT * FROM Inventario";
            conn.Open();
            OracleCommand comando = new OracleCommand(consulta, conn);
            OracleDataAdapter adaptador = new OracleDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            DGV_Act.DataSource = tabla;

            conn.Close(); // Cierra la conexión después de usarla

        }

        private void InventarioActualizar_Load(object sender, EventArgs e)
        {
            this.ListarDGV();
        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DGV_Act.Rows[e.RowIndex];

                string idProducto = row.Cells["idproducto"].Value.ToString();
                string idSucursal = row.Cells["idsucursal"].Value.ToString();
                string cantidad = row.Cells["cantidad"].Value.ToString();

                // Establecer los valores en los cuadros de texto
                txt_IDPROD.Text = idProducto;
                txt_IDSUCURSAL.Text = idSucursal;
                txt_CANTIDAD.Text = cantidad;

                txt_IDPROD.ReadOnly = true;
                txt_IDSUCURSAL.ReadOnly = true;
            }
        }

        private void Actualizar(string idproducto, string idsucursal, int cantidad)
        {

            string updateQuery = "";
            if (IsMaster)
            {
                updateQuery = "UPDATE Inventario SET Cantidad = :cantidad WHERE IdProducto = :idProducto AND IdSucursal = :idSucursal";
            }
            else
            {
                updateQuery = "UPDATE Inventario@replica_proyrad SET Cantidad = :cantidad WHERE IdProducto = :idProducto AND IdSucursal = :idSucursal";
            }


            // Crea un objeto OracleCommand
            OracleCommand updateCommand = new OracleCommand(updateQuery, conn);

            // Asigna valores a los parámetros
            updateCommand.Parameters.Add(":cantidad", OracleDbType.Varchar2).Value = cantidad;
            updateCommand.Parameters.Add(":idProducto", OracleDbType.Varchar2).Value = idproducto;
            updateCommand.Parameters.Add(":idSucursal", OracleDbType.Varchar2).Value = idsucursal;

            try
            {
                // Abre la conexión y ejecuta la consulta de actualización
                conn.Open();
                int rowsAffected = updateCommand.ExecuteNonQuery();
                conn.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("La actualización del inventario se realizó con éxito.");
                }
                else
                {
                    MessageBox.Show("No se encontró un producto con el ID especificado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el inventario: " + ex.Message);
                conn.Close();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string idProd = txt_IDPROD.Text;
            string idsucursal = txt_IDSUCURSAL.Text;
            int cantidad = int.Parse(txt_CANTIDAD.Text);


            Actualizar(idProd, idsucursal, cantidad);
            ListarDGV(); // Actualiza el DataGridView para mostrar los datos actualizados
        }

    }
}
