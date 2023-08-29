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
            string conStr = @"DATA SOURCE = localhost:1521/orcl; USER ID=marmijo;PASSWORD=marmijo";
            conn = new OracleConnection(conStr);
            updateGried();
        }

        private void updateGried()
        {
            conn.Open();
            OracleCommand getemps= conn.CreateCommand();
            getemps.CommandText = "SELECT * FROM DATOS";
            getemps.CommandType = CommandType.Text;
            OracleDataReader empDR= getemps.ExecuteReader();
            DataTable empdt = new DataTable();
            empdt.Load(empDR);
            dataGridView1.DataSource=empdt;
            conn.Close();
        }

    }
}
