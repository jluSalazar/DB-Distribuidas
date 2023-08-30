using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinAppBiblioteca.Forms;

namespace WinAppBiblioteca
{
    public partial class Diseno : Form
    {
        bool IsMaster;
        Query query;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        

        private static extern IntPtr CreateRoundRectRgn
     (
          int nLeftRect,
          int nTopRect,
          int nRightRect,
          int nBottomRect,
          int nWidthEllipse,
          int nHeightEllipse

      );
        
        public Diseno(bool ismaster)
        {
            InitializeComponent();
            IsMaster = ismaster;
            
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
        private void ButtonColorReset(Button button)
        {
            Color activeColor = Color.FromArgb(31, 27, 48);
            Color btnColor = Color.FromArgb(26, 23, 40);
            btnDashboard.BackColor = btnColor;
            btnCustomers.BackColor = btnColor;
            btnUpdate.BackColor = btnColor;
            btnDelete.BackColor = btnColor;
            btnAnalytics.BackColor = btnColor;
            btnRestaurants.BackColor = btnColor;
            btnSettings.BackColor = btnColor;
            button.BackColor = activeColor;
        }

        private void BtnDashboard_Click(object sender, EventArgs e) //Insertar
        {
           pnlNavIndicator.Height = btnDashboard.Height;
            pnlNavIndicator.Top = btnDashboard.Top;
            pnlNavIndicator.Left = btnDashboard.Left;
            ButtonColorReset(btnDashboard);
           
           
            lblTabTitle.Text = "Insertar";
            this.pnlContent.Controls.Clear();
            Insertar insertar = new Insertar() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlContent.Controls.Add(insertar);
            insertar.Show();
        }

        private void BtnCustomers_Click(object sender, EventArgs e)
        {
           pnlNavIndicator.Height = btnCustomers.Height;
            pnlNavIndicator.Top = btnCustomers.Top;
            pnlNavIndicator.Left = btnCustomers.Left;
            ButtonColorReset(btnCustomers);
            
            lblTabTitle.Text = "Query";
            this.pnlContent.Controls.Clear();
             query = new Query() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlContent.Controls.Add(query);
            query.Show();
        }
        private void BtnRestaurants_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel_header_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            pnlNavIndicator.Height = btnUpdate.Height;
            pnlNavIndicator.Top = btnUpdate.Top;
            pnlNavIndicator.Left = btnUpdate.Left;
            ButtonColorReset(btnUpdate);

            lblTabTitle.Text = "Update";
            this.pnlContent.Controls.Clear();
            UpdateForm update = new UpdateForm(IsMaster){ Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlContent.Controls.Add(update);
            update.Show();
        }

        private void btnDelet_Click(object sender, EventArgs e)
        {
            pnlNavIndicator.Height = btnUpdate.Height;
            pnlNavIndicator.Top = btnUpdate.Top;
            pnlNavIndicator.Left = btnUpdate.Left;
            ButtonColorReset(btnDelete);

            lblTabTitle.Text = "Delete";
            this.pnlContent.Controls.Clear();
            DeleteForm deleteForm = new DeleteForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlContent.Controls.Add(deleteForm);
            deleteForm.Show();
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            pnlNavIndicator.Height = btnUpdate.Height;
            pnlNavIndicator.Top = btnUpdate.Top;
            pnlNavIndicator.Left = btnUpdate.Left;
            ButtonColorReset(btnDelete);

            lblTabTitle.Text = "REPLICACIÓN";
            this.pnlContent.Controls.Clear();
            VistaMaterializada deleteForm = new VistaMaterializada() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlContent.Controls.Add(deleteForm);
            deleteForm.Show();
        }
    }
}
