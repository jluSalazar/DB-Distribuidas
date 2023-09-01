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
using WinAppBiblioteca.Model;

namespace WinAppBiblioteca
{
    public partial class Diseno : Form
    {
        Usuario user;
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
        
        public Diseno(Usuario usuario)
        {
            InitializeComponent();
            user = usuario;
            
            Console.WriteLine(user.ToString());
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
            btnInsert.BackColor = btnColor;
            btnUpdate.BackColor = btnColor;
            btnFrag.BackColor = btnColor;
            btnAnalytics.BackColor = btnColor;
            btnAuditoria.BackColor = btnColor;
            btnSettings.BackColor = btnColor;
            button.BackColor = activeColor;
        }

        private void BtnInsert_Click(object sender, EventArgs e) //Insertar
        {
           pnlNavIndicator.Height = btnInsert.Height;
            pnlNavIndicator.Top = btnInsert.Top;
            pnlNavIndicator.Left = btnInsert.Left;
            ButtonColorReset(btnInsert);
           
           
            lblTabTitle.Text = "Insertar";
            this.pnlContent.Controls.Clear();
            TablasInsert tinsert = new TablasInsert(user) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlContent.Controls.Add(tinsert);
            tinsert.Show();

            /*
              // Configura pnlNavIndicator para resaltar el botón actual
                pnlNavIndicator.Height = btnCustomers.Height;
                pnlNavIndicator.Top = btnCustomers.Top;
                pnlNavIndicator.Left = btnCustomers.Left;

                // Oculta los paneles de contenido actuales (si los hay)
                foreach (Control control in pnlContent.Controls)
                {
                    control.Visible = false;
                }

                // Muestra el panel de Customers (o el que desees mostrar)
                if (customersPanel == null)
                {
                    customersPanel = new CustomersPanel(); // Reemplaza con el nombre de tu clase de panel
                    customersPanel.Dock = DockStyle.Fill;
                    customersPanel.TopLevel = false;
                    customersPanel.TopMost = true;
                    pnlContent.Controls.Add(customersPanel);
                }
    
                customersPanel.Visible = true; // Muestra el panel Customers
             */
        }

        public void MostrarPanel(int opc)
        {
            switch (opc)
            {
                case 1:

                    ClienteGYEinsert clientInsert = new ClienteGYEinsert(user) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                    this.pnlContent.Controls.Add(clientInsert);
                    clientInsert.Show();
                    break;
            }

        }
        private void BtnAuditoria_Click(object sender, EventArgs e)
        {
            pnlNavIndicator.Height = btnAuditoria.Height;
            pnlNavIndicator.Top = btnAuditoria.Top;
            pnlNavIndicator.Left = btnAuditoria.Left;
            ButtonColorReset(btnAuditoria);

            lblTabTitle.Text = "Auditoria";
            this.pnlContent.Controls.Clear();
            Auditoria audit = new Auditoria(user) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlContent.Controls.Add(audit);
            audit.Show();
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
            ProductoActualizar update = new ProductoActualizar(user){ Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlContent.Controls.Add(update);
            update.Show();
        }

        private void btnFrag_Click(object sender, EventArgs e)
        {
            pnlNavIndicator.Height = btnUpdate.Height;
            pnlNavIndicator.Top = btnUpdate.Top;
            pnlNavIndicator.Left = btnUpdate.Left;
            ButtonColorReset(btnFrag);

            lblTabTitle.Text = "Fragmentacion";
            this.pnlContent.Controls.Clear();
            ReadFrag readFrag = new ReadFrag(user) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlContent.Controls.Add(readFrag);
            readFrag.Show();
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            pnlNavIndicator.Height = btnUpdate.Height;
            pnlNavIndicator.Top = btnUpdate.Top;
            pnlNavIndicator.Left = btnUpdate.Left;
            ButtonColorReset(btnFrag);

            lblTabTitle.Text = "REPLICACIÓN";
            this.pnlContent.Controls.Clear();
            VistaMaterializada deleteForm = new VistaMaterializada() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlContent.Controls.Add(deleteForm);
            deleteForm.Show();
        }
    }
}
