using DemoCV.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class VentasForm : Form
    {
        public VentasForm()
        {
            InitializeComponent();
        }
        void ListarVentas()
        {
            listVenta.Items.Clear();
            foreach (Venta ventas in GlobalVar.concesionario.VentasRealizadas)
            {
                listVenta.Items.Add(new ListViewItem(ventas.itemView()));
            }
        }
        public void LlenarcmbxClientes()
        {
            cmbxCliente.Items.Clear();
            cmbxCliente.Items.AddRange(GlobalVar.clientes.ToArray());

        }
        public void LlenarcmbxVehiculo()
        {
            cmbxVehiculo.Items.Clear();
            cmbxVehiculo.Items.AddRange(GlobalVar.Inventario.Lista().ToArray());

        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void VentasForm_Load(object sender, EventArgs e)
        {
            LlenarcmbxClientes();
            LlenarcmbxVehiculo();
            listVenta.View = View.Details;
            listVenta.FullRowSelect = true;
            listVenta.GridLines = true;
            listVenta.Columns.Add("Id");
            listVenta.Columns.Add("Vehículo");
            listVenta.Columns.Add("Cliente");
            listVenta.Columns.Add("Precio");
            listVenta.Columns.Add("Fecha");

            foreach (ColumnHeader column in listVenta.Columns)
            {
                if (column.Index == 0)
                    column.Width = 0;
                else
                    column.Width = 100;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Validar cmbxs para que no sea nulo y solo se puedan seleccionar elementos de la lista
            if (cmbxCliente.SelectedItem == null)
            {
                MessageBox.Show("Ingresa un cliente");
                cmbxCliente.Focus();
                return;
            }
            if (cmbxVehiculo.SelectedItem == null)
            {
                MessageBox.Show("Ingrese un vehiculo");
                cmbxVehiculo.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtPrecio.Text))
            {
                MessageBox.Show("Ingresa el precio");
                txtPrecio.Focus();
                return;
            }

            decimal lukas;
            bool isOk = decimal.TryParse(txtPrecio.Text, out lukas);

            if (!isOk)
            {
                MessageBox.Show("Ingresa precio válido");
                txtPrecio.Focus();
                return;
            }
            Cliente clienteSelect = cmbxCliente.SelectedItem as Cliente;
            Vehiculo vehiculoSelect = cmbxVehiculo.SelectedItem as Vehiculo;
            GlobalVar.concesionario.RegistrarVenta(vehiculoSelect, clienteSelect);
            
            ListarVentas();
            LlenarcmbxVehiculo();

            cmbxCliente.SelectedIndex = -1;
            cmbxVehiculo.SelectedIndex = -1;
            txtPrecio.Clear();
        }
        private void cmbxVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Hace que el textBox tenga el precio del vehiculo
            if (cmbxVehiculo.SelectedItem is Vehiculo vehiculo)
                txtPrecio.Text = vehiculo.Precio.ToString();
        }
    }
}
