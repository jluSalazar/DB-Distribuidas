
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinAppBiblioteca.Logica;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinAppBiblioteca
{
    public partial class Query : Form
    {

        Buscar buscar;
       
        public Query()
        {

            InitializeComponent();
            buscar= new Buscar();
     
         
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }


        private void Listado_ar()
        {
        }
        private void Estudiante_Load(object sender, EventArgs e)
        {
            Listado_ar();
        }

        private void button15_Click(object sender, EventArgs e)
        {
          

        }

        private void button16_Click(object sender, EventArgs e)
        {
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button17_Click(object sender, EventArgs e)
        {
            

        }

        



        private void button18_Click(object sender, EventArgs e)
        {
          


        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGLibro_Layout(object sender, LayoutEventArgs e)
        {
            Buscar buscar = new Buscar();
            DataTable dt = buscar.listado();
            dataGLibro.DataSource = dt;
        }
    }
}