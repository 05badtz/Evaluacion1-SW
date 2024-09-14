using DemoCV.clases;

namespace WinFormsApp1
{
    public partial class ClientesForm : Form
    {
        string idGlobal = "";
        public ClientesForm()
        {
            InitializeComponent();

        }

        void ListarClientes()
        {
            listView1.Items.Clear();
            foreach (Cliente cliente in GlobalVar.clientes)
            {
                listView1.Items.Add(new ListViewItem(cliente.itemView()));
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tx_nombre.Text))
            {
                MessageBox.Show("Debes ingresar un nombre");
                tx_nombre.Focus();
                return;
            }
            if (String.IsNullOrEmpty(tx_apellido.Text))
            {
                MessageBox.Show("Debes ingresar un apellido");
                tx_apellido.Focus();
                return;
            }

            if (String.IsNullOrEmpty(tx_dinero.Text))
            {
                MessageBox.Show("Debes ingresar un dinerillo");
                tx_dinero.Focus();
                return;
            }

            decimal lukas;

            bool isOk = decimal.TryParse(tx_dinero.Text, out lukas);
            if (!isOk)
            {
                MessageBox.Show("Ingresa dinero valido");
                tx_dinero.Focus();
                return;
            }

            Cliente cliente = new Cliente()
            {
                Nombre = tx_nombre.Text,
                Apellidos = tx_apellido.Text,
                DineroDisponible = lukas
            };

            if (String.IsNullOrEmpty(idGlobal))
            {
                GlobalVar.clientes.Add(cliente);

            }
            else
            {
                Cliente cliente_Modificar = GlobalVar.clientes.Where(c => c.Id == idGlobal).FirstOrDefault()!;
                cliente_Modificar.Nombre = tx_nombre.Text;
                cliente_Modificar.Apellidos = tx_apellido.Text;
                cliente_Modificar.DineroDisponible = Convert.ToDecimal(tx_dinero.Text);
                idGlobal = "";
            }

            ListarClientes();


            tx_nombre.Text = "";
            tx_apellido.Text = "";
            tx_dinero.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Columns.Add("Id");
            listView1.Columns.Add("Nombre");
            listView1.Columns.Add("Apellido");
            listView1.Columns.Add("Dinero");

            foreach (ColumnHeader column in listView1.Columns)
            {
                if (column.Index == 0)
                    column.Width = 0;
                else
                    column.Width = 100;
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String id = listView1.SelectedItems[0].Text;
            //Consultas sobre listas de objetos
            Cliente cliente_Eliminar = GlobalVar.clientes.Where(c => c.Id == id).FirstOrDefault()!;
            GlobalVar.clientes.Remove(cliente_Eliminar);
            ListarClientes();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String id = listView1.SelectedItems[0].Text;
            idGlobal = id;
            Cliente cliente_Modificar = GlobalVar.clientes.Where(c => c.Id == id).FirstOrDefault()!;
            tx_nombre.Text = cliente_Modificar.Nombre;
            tx_apellido.Text = cliente_Modificar.Apellidos;
            tx_dinero.Text = Convert.ToString(cliente_Modificar.DineroDisponible);

        }

        private void listView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            if (listView1.Columns[e.ColumnIndex].Index == 0)
            {

                e.Cancel = true;
                e.NewWidth=listView1.Columns[e.ColumnIndex].Width;
            }
        }
    }
}
