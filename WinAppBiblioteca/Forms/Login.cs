using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinAppBiblioteca.Logica;

namespace WinAppBiblioteca.Forms
{
    public partial class Login : Form
    {

        SQLiteConnection sqlcon = new SQLiteConnection();
       
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            sqlcon= Conexion.getInstancia().crearConexion();

            if (((tusers.Text == "") && (tPass.Text == "")) || (tusers.Text == "") || (tPass.Text == ""))
            {
                lmessage.Visible = true;
                lmessage.Text = "INPUT'S VACIOS";
            }
            else
            {

                try
                {
                    sqlcon.Open();
                    string query = "SELECT * FROM Usuarios WHERE Username= '" + tusers.Text + "'and Password= '" + tPass.Text + "' ";
                    SQLiteCommand cmd = new SQLiteCommand(query, sqlcon);
                    cmd.ExecuteNonQuery();
                    SQLiteDataReader dr = cmd.ExecuteReader();

                    int count = 0;
                    while (dr.Read())
                    {
                        count++;
                    }
                    if (count == 1)
                    {
                        Diseno pantalla = new Diseno();
                        pantalla.Show();
                        this.Hide();

                    }
                    if (count < 1)
                    {
                        lmessage.Visible = true;
                        lmessage.Text = "ERROR: INGRESE DATOS CORRECTOS";


                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("erorr" + ex);

                }

            }
        }
    }
}
