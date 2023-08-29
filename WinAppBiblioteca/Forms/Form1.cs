using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace WinAppBiblioteca.Forms
{
    public partial class Form1 : Form
    {
        OracleConnection conn;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/orcl; USER ID=prueba;PASSWORD=prueba";
            conn = new OracleConnection(conStr);
            updateGried();
        }

        private void updateGried()
        {
            string consulta = "SELECT * FROM VWTABLA_ORG"; // Reemplaza mv_ejemplo con el nombre de tu vista materializada
            conn.Open(); // Abre la conexión a la base de datos Oracle
            OracleCommand comando = new OracleCommand(consulta, conn); // Utiliza "conn" como tu objeto de conexión
            OracleDataAdapter adaptador = new OracleDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;

            conn.Close(); // Cierra la conexión después de usarla

        }

        private void button1_Click(object sender, EventArgs e)
        {
            updateGried();
        }
    }
}
