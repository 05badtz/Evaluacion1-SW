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

namespace WinFormsApp1
{
    public partial class VehiculosForms : Form
    {
        string globalId = "";
        List<Vehiculo> vehiculos = new List<Vehiculo>();
        public VehiculosForms()
        {
            InitializeComponent();
        }

        private void VehiculosForms_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Columns.Add("Id");
            listView1.Columns.Add("Marca");
            listView1.Columns.Add("Modelo");
            listView1.Columns.Add("Año");
            listView1.Columns.Add("Kilometraje");
            listView1.Columns.Add("Precio");

            foreach (ColumnHeader column in listView1.Columns)
            {
                if (column.Index == 0)
                    column.Width = 0;
                else
                    column.Width = 100;
            }

        }
        public void ListarVehiculo()
        {
            listView1.Items.Clear();
            foreach (Vehiculo vehiculo in GlobalVar.Inventario.Lista())
            {
                listView1.Items.Add(new ListViewItem(vehiculo.itemView()));
            }
        }

        private void bt_guardar_Click(object sender, EventArgs e)
        {
            //Validar ojoj ojojojjo
            if (String.IsNullOrEmpty(tx_marca.Text))
            {
                MessageBox.Show("Debes ingresar una marca");
                tx_marca.Focus();
                return;
            }
            if (String.IsNullOrEmpty(tx_modelo.Text))
            {
                MessageBox.Show("Debes ingresar un modelo");
                tx_modelo.Focus();
                return;
            }

            if (String.IsNullOrEmpty(tx_año.Text))
            {
                MessageBox.Show("Debes ingresar el año del vehículo");
                tx_año.Focus();
                return;
            }
            if (String.IsNullOrEmpty(tx_km.Text))
            {
                MessageBox.Show("Debes ingresar el kilometraje");
                tx_km.Focus();
                return;
            }
            if (String.IsNullOrEmpty(tx_precio.Text))
            {
                MessageBox.Show("Debes ingresar dinero");
                tx_precio.Focus();
                return;
            }

            decimal lukas;
            bool isOk = decimal.TryParse(tx_precio.Text, out lukas);
            if (!isOk)
            {
                MessageBox.Show("Ingresa dinero válido");
                tx_precio.Focus();
                return;
            }

            int año, kilometraje;
            isOk = int.TryParse(tx_año.Text, out año);
            if (!isOk)
            {
                MessageBox.Show("Ingresa año válido");
                tx_año.Focus();
                return;
            }
            isOk = int.TryParse(tx_km.Text, out kilometraje);
            if (!isOk)
            {
                MessageBox.Show("Ingresa kilometraje");
                tx_km.Focus();
                return;
            }

            Vehiculo vehiculo = new Vehiculo()
            {
                Marca = tx_marca.Text,
                Modelo = tx_modelo.Text,
                Año = Convert.ToInt16(tx_año.Text),
                Kilometraje = Convert.ToInt16(tx_km.Text),
                Precio = Convert.ToDecimal(tx_precio.Text),
            };

            if (String.IsNullOrEmpty(globalId))
            {
                vehiculos.Add(vehiculo);
                GlobalVar.Inventario.AgregarVehiculo(vehiculo);
            }
            else
            {
                String id = listView1.SelectedItems[0].Text;
                Vehiculo vehiculo_modificar = GlobalVar.Inventario.Lista().Where(v => v.Id == id).FirstOrDefault()!;
                vehiculo_modificar.Marca = tx_marca.Text;
                vehiculo_modificar.Modelo = tx_modelo.Text;
                vehiculo_modificar.Año = Convert.ToInt16(tx_año.Text);
                vehiculo_modificar.Kilometraje = Convert.ToInt16(tx_km.Text);
                vehiculo_modificar.Precio = Convert.ToDecimal(tx_precio.Text);
                globalId = "";
            }
            
            ListarVehiculo();


            tx_marca.Text = "";
            tx_modelo.Text = "";
            tx_año.Text = "";
            tx_km.Text = "";
            tx_precio.Text = "";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            if (listView1.Columns[e.ColumnIndex].Index == 0)
            {

                e.Cancel = true;
                e.NewWidth = listView1.Columns[e.ColumnIndex].Width;
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String id = listView1.SelectedItems[0].Text;
            Vehiculo vehiculo_eliminar = GlobalVar.Inventario.Lista().Where(v => v.Id == id).FirstOrDefault()!;
            GlobalVar.Inventario.EliminarVehiculo(vehiculo_eliminar);
            ListarVehiculo();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String id = listView1.SelectedItems[0].Text;
            globalId = id;
            Vehiculo vehiculo_modificar = GlobalVar.Inventario.Lista().Where(v => v.Id == id).FirstOrDefault()!;
            tx_marca.Text = vehiculo_modificar.Marca;
            tx_modelo.Text = vehiculo_modificar.Modelo;
            tx_año.Text = Convert.ToString(vehiculo_modificar.Año);
            tx_km.Text = Convert.ToString(vehiculo_modificar.Kilometraje);
            tx_precio.Text = Convert.ToString(vehiculo_modificar.Precio);
        }
    }
}
