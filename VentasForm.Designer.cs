namespace WinFormsApp1
{
    partial class VentasForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnGuardar = new Button();
            txtPrecio = new TextBox();
            lblPrecio = new Label();
            cmbxVehiculo = new ComboBox();
            cmbxCliente = new ComboBox();
            lblVehiculo = new Label();
            lblCliente = new Label();
            gpbxList = new GroupBox();
            listVenta = new ListView();
            btnCerrar = new Button();
            groupBox1.SuspendLayout();
            gpbxList.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCerrar);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(txtPrecio);
            groupBox1.Controls.Add(lblPrecio);
            groupBox1.Controls.Add(cmbxVehiculo);
            groupBox1.Controls.Add(cmbxCliente);
            groupBox1.Controls.Add(lblVehiculo);
            groupBox1.Controls.Add(lblCliente);
            groupBox1.Location = new Point(11, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(403, 241);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Generar Venta";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(281, 58);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtPrecio
            // 
            txtPrecio.Enabled = false;
            txtPrecio.Location = new Point(35, 191);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(151, 27);
            txtPrecio.TabIndex = 2;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(35, 168);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(90, 20);
            lblPrecio.TabIndex = 4;
            lblPrecio.Text = "Precio venta";
            // 
            // cmbxVehiculo
            // 
            cmbxVehiculo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbxVehiculo.FormattingEnabled = true;
            cmbxVehiculo.Location = new Point(35, 123);
            cmbxVehiculo.Name = "cmbxVehiculo";
            cmbxVehiculo.Size = new Size(340, 28);
            cmbxVehiculo.TabIndex = 1;
            cmbxVehiculo.SelectedIndexChanged += cmbxVehiculo_SelectedIndexChanged;
            // 
            // cmbxCliente
            // 
            cmbxCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbxCliente.FormattingEnabled = true;
            cmbxCliente.Location = new Point(35, 59);
            cmbxCliente.Name = "cmbxCliente";
            cmbxCliente.Size = new Size(151, 28);
            cmbxCliente.TabIndex = 0;
            // 
            // lblVehiculo
            // 
            lblVehiculo.AutoSize = true;
            lblVehiculo.Location = new Point(35, 100);
            lblVehiculo.Name = "lblVehiculo";
            lblVehiculo.Size = new Size(143, 20);
            lblVehiculo.TabIndex = 1;
            lblVehiculo.Text = "Seleccione  vehículo";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(35, 36);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(128, 20);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Seleccione cliente";
            // 
            // gpbxList
            // 
            gpbxList.Controls.Add(listVenta);
            gpbxList.Location = new Point(11, 259);
            gpbxList.Name = "gpbxList";
            gpbxList.Size = new Size(403, 236);
            gpbxList.TabIndex = 1;
            gpbxList.TabStop = false;
            gpbxList.Text = "Listado de ventas";
            // 
            // listVenta
            // 
            listVenta.Location = new Point(6, 26);
            listVenta.Name = "listVenta";
            listVenta.Size = new Size(391, 204);
            listVenta.TabIndex = 5;
            listVenta.UseCompatibleStateImageBehavior = false;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(281, 190);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(94, 29);
            btnCerrar.TabIndex = 4;
            btnCerrar.Text = "&Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // VentasForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 507);
            ControlBox = false;
            Controls.Add(gpbxList);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "VentasForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ventas";
            Load += VentasForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gpbxList.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnGuardar;
        private TextBox txtPrecio;
        private Label lblPrecio;
        private ComboBox cmbxVehiculo;
        private ComboBox cmbxCliente;
        private Label lblVehiculo;
        private Label lblCliente;
        private GroupBox gpbxList;
        private ListView listVenta;
        private Button btnCerrar;
    }
}