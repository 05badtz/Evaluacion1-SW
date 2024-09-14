using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace WinFormsApp1
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form formClient in Application.OpenForms)
            {
                if (formClient is ClientesForm)
                {
                    formClient.Activate();
                    return;
                }
            }

            ClientesForm formcliente = new ClientesForm();
            formcliente.MdiParent = this;
            formcliente.Dock = DockStyle.Fill;
            formcliente.Show();
            formcliente.WindowState = FormWindowState.Maximized;

        }

        private void Principal_Load(object sender, EventArgs e)
        {
            //notifyIcon1.BalloonTipText = "The quick brown fox. Jump!";
            //notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            //notifyIcon1.BalloonTipTitle = "Alert!";
            //notifyIcon1.ShowBalloonTip(2000);
            //notifyIcon1.Visible = true;

        }

        private void ventasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (Form formVentas in Application.OpenForms)
            {
                if (formVentas is VentasForm)
                {
                    formVentas.Activate();
                    return;
                }
            }
            VentasForm formventa = new VentasForm();
            formventa.MdiParent = this;
            formventa.Dock = DockStyle.Bottom;
            formventa.Show();
            formventa.WindowState = FormWindowState.Maximized;
        }

        private void vehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form formVehiculo in Application.OpenForms)
            {
                if (formVehiculo is VehiculosForms)
                {
                    formVehiculo.Activate();
                    return;
                }
            }
            VehiculosForms formvehiculo = new VehiculosForms();
            formvehiculo.MdiParent = this;
            formvehiculo.Dock = DockStyle.Fill;
            formvehiculo.Show();
            formvehiculo.WindowState = FormWindowState.Maximized;

        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
