﻿using System;
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
using WinAppBiblioteca.Model;

namespace WinAppBiblioteca.Forms
{
    public partial class Login : Form
    {
        Usuario user1 = new Usuario
        {
            username = "jsalazar",
            password = "jsalazar",
            ismaster = true
        };

        Usuario user2 = new Usuario
        {
            username = "marmijo",
            password = "marmijo",
            ismaster = false
        };

        SQLiteConnection sqlcon = new SQLiteConnection();
       
        public Login()
        {
            InitializeComponent();
        }
        private Point lastLocation;

        private void PanelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                lastLocation = e.Location;
            }
        }

        private void PanelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X,
                    (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
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

                if (tusers.Text == user1.username)
                {
                    Diseno pantalla = new Diseno(user1.ismaster);
                    pantalla.Show();
                    this.Hide();
                }
                else if(tusers.Text == user2.username)
                {
                    Diseno pantalla = new Diseno(user2.ismaster);
                    pantalla.Show();
                    this.Hide();
                }

            }
        }
    }
}
