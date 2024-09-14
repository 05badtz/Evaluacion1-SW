namespace WinFormsApp1
{
    partial class VehiculosForms
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            btnCerrar = new Button();
            bt_guardar = new Button();
            tx_marca = new TextBox();
            tx_modelo = new TextBox();
            tx_año = new TextBox();
            tx_km = new TextBox();
            tx_precio = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            listView1 = new ListView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            modificarToolStripMenuItem = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCerrar);
            groupBox1.Controls.Add(bt_guardar);
            groupBox1.Controls.Add(tx_marca);
            groupBox1.Controls.Add(tx_modelo);
            groupBox1.Controls.Add(tx_año);
            groupBox1.Controls.Add(tx_km);
            groupBox1.Controls.Add(tx_precio);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(11, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(400, 213);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nuevo Vehículo";
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(283, 172);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(94, 29);
            btnCerrar.TabIndex = 6;
            btnCerrar.Text = "&Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // bt_guardar
            // 
            bt_guardar.Location = new Point(283, 40);
            bt_guardar.Name = "bt_guardar";
            bt_guardar.Size = new Size(94, 29);
            bt_guardar.TabIndex = 5;
            bt_guardar.Text = "&Guardar";
            bt_guardar.UseVisualStyleBackColor = true;
            bt_guardar.Click += bt_guardar_Click;
            // 
            // tx_marca
            // 
            tx_marca.Location = new Point(101, 41);
            tx_marca.Name = "tx_marca";
            tx_marca.Size = new Size(140, 27);
            tx_marca.TabIndex = 0;
            // 
            // tx_modelo
            // 
            tx_modelo.Location = new Point(101, 75);
            tx_modelo.Name = "tx_modelo";
            tx_modelo.Size = new Size(113, 27);
            tx_modelo.TabIndex = 1;
            // 
            // tx_año
            // 
            tx_año.Location = new Point(101, 107);
            tx_año.Name = "tx_año";
            tx_año.Size = new Size(69, 27);
            tx_año.TabIndex = 2;
            // 
            // tx_km
            // 
            tx_km.Location = new Point(101, 140);
            tx_km.Name = "tx_km";
            tx_km.Size = new Size(89, 27);
            tx_km.TabIndex = 3;
            // 
            // tx_precio
            // 
            tx_precio.Location = new Point(101, 173);
            tx_precio.Name = "tx_precio";
            tx_precio.Size = new Size(100, 27);
            tx_precio.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 176);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 4;
            label5.Text = "Precio:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 143);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 3;
            label4.Text = "Kilometraje:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 109);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 2;
            label3.Text = "Año:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 77);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 1;
            label2.Text = "Modelo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 44);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 0;
            label1.Text = "Marca:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listView1);
            groupBox2.Location = new Point(9, 231);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(403, 263);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Listado";
            // 
            // listView1
            // 
            listView1.ContextMenuStrip = contextMenuStrip1;
            listView1.Dock = DockStyle.Fill;
            listView1.Location = new Point(3, 23);
            listView1.Name = "listView1";
            listView1.Size = new Size(397, 237);
            listView1.TabIndex = 7;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.List;
            listView1.ColumnWidthChanging += listView1_ColumnWidthChanging;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { eliminarToolStripMenuItem, modificarToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(143, 52);
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(142, 24);
            eliminarToolStripMenuItem.Text = "Eliminar";
            eliminarToolStripMenuItem.Click += eliminarToolStripMenuItem_Click;
            // 
            // modificarToolStripMenuItem
            // 
            modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            modificarToolStripMenuItem.Size = new Size(142, 24);
            modificarToolStripMenuItem.Text = "Modificar";
            modificarToolStripMenuItem.Click += modificarToolStripMenuItem_Click;
            // 
            // VehiculosForms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 507);
            ControlBox = false;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "VehiculosForms";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VehiculosForms";
            Load += VehiculosForms_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button bt_guardar;
        private TextBox tx_marca;
        private TextBox tx_modelo;
        private TextBox tx_año;
        private TextBox tx_km;
        private TextBox tx_precio;
        private GroupBox groupBox2;
        private ListView listView1;
        private Button btnCerrar;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private ToolStripMenuItem modificarToolStripMenuItem;
    }
}