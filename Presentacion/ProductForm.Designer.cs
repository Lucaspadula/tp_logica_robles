namespace tp_logica_robles
{
    partial class ProductForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            categoriaToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            soporteToolStripMenuItem = new ToolStripMenuItem();
            origenToolStripMenuItem = new ToolStripMenuItem();
            consultasToolStripMenuItem = new ToolStripMenuItem();
            RutasConductoresToolStripMenuItem = new ToolStripMenuItem();
            verVentasToolStripMenuItem = new ToolStripMenuItem();
            detallesDeProductosToolStripMenuItem = new ToolStripMenuItem();
            mayorCapacidadDeGalponesToolStripMenuItem = new ToolStripMenuItem();
            devolucionDeProductosToolStripMenuItem = new ToolStripMenuItem();
            facturasDeClientesToolStripMenuItem = new ToolStripMenuItem();
            detalleDeFacturasToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            informacionToolStripMenuItem = new ToolStripMenuItem();
            datosDeContactoToolStripMenuItem = new ToolStripMenuItem();
            versionToolStripMenuItem = new ToolStripMenuItem();
            labelProducto = new Label();
            btnNuevo = new Button();
            txtCodigoProd = new TextBox();
            btnConsultar = new Button();
            dataGridViewProductos = new DataGridView();
            grpFiltro = new GroupBox();
            labelbuscar = new Label();
            Codigo = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Origen = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).BeginInit();
            grpFiltro.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, soporteToolStripMenuItem, consultasToolStripMenuItem, acercaDeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(946, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { categoriaToolStripMenuItem, salirToolStripMenuItem });
            archivoToolStripMenuItem.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(68, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // categoriaToolStripMenuItem
            // 
            categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            categoriaToolStripMenuItem.Size = new Size(137, 22);
            categoriaToolStripMenuItem.Text = "Categoria";
            categoriaToolStripMenuItem.Click += categoriaToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(137, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // soporteToolStripMenuItem
            // 
            soporteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { origenToolStripMenuItem });
            soporteToolStripMenuItem.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            soporteToolStripMenuItem.Name = "soporteToolStripMenuItem";
            soporteToolStripMenuItem.Size = new Size(71, 20);
            soporteToolStripMenuItem.Text = "Soporte";
            // 
            // origenToolStripMenuItem
            // 
            origenToolStripMenuItem.Name = "origenToolStripMenuItem";
            origenToolStripMenuItem.Size = new Size(116, 22);
            origenToolStripMenuItem.Text = "Origen";
            origenToolStripMenuItem.Click += origenToolStripMenuItem_Click;
            // 
            // consultasToolStripMenuItem
            // 
            consultasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { RutasConductoresToolStripMenuItem, verVentasToolStripMenuItem, detallesDeProductosToolStripMenuItem, mayorCapacidadDeGalponesToolStripMenuItem, devolucionDeProductosToolStripMenuItem, facturasDeClientesToolStripMenuItem, detalleDeFacturasToolStripMenuItem });
            consultasToolStripMenuItem.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            consultasToolStripMenuItem.Size = new Size(83, 20);
            consultasToolStripMenuItem.Text = "Consultas";
            consultasToolStripMenuItem.Click += consultasToolStripMenuItem_Click;
            // 
            // RutasConductoresToolStripMenuItem
            // 
            RutasConductoresToolStripMenuItem.Name = "RutasConductoresToolStripMenuItem";
            RutasConductoresToolStripMenuItem.Size = new Size(272, 22);
            RutasConductoresToolStripMenuItem.Text = "Rutas Conductores";
            RutasConductoresToolStripMenuItem.Click += RutasConductoresToolStripMenuItem_Click;
            // 
            // verVentasToolStripMenuItem
            // 
            verVentasToolStripMenuItem.Name = "verVentasToolStripMenuItem";
            verVentasToolStripMenuItem.Size = new Size(272, 22);
            verVentasToolStripMenuItem.Text = "Canales de Atencion";
            verVentasToolStripMenuItem.Click += canalesComunicacionToolStripMenuItem_Click;
            // 
            // detallesDeProductosToolStripMenuItem
            // 
            detallesDeProductosToolStripMenuItem.Name = "detallesDeProductosToolStripMenuItem";
            detallesDeProductosToolStripMenuItem.Size = new Size(272, 22);
            detallesDeProductosToolStripMenuItem.Text = "Detalles de Productos";
            detallesDeProductosToolStripMenuItem.Click += detallesDeProductosToolStripMenuItem_Click;
            // 
            // mayorCapacidadDeGalponesToolStripMenuItem
            // 
            mayorCapacidadDeGalponesToolStripMenuItem.Name = "mayorCapacidadDeGalponesToolStripMenuItem";
            mayorCapacidadDeGalponesToolStripMenuItem.Size = new Size(272, 22);
            mayorCapacidadDeGalponesToolStripMenuItem.Text = "Mayor Capacidad de Galpones";
            mayorCapacidadDeGalponesToolStripMenuItem.Click += mayorCapacidadDeGalponesToolStripMenuItem_Click;
            // 
            // devolucionDeProductosToolStripMenuItem
            // 
            devolucionDeProductosToolStripMenuItem.Name = "devolucionDeProductosToolStripMenuItem";
            devolucionDeProductosToolStripMenuItem.Size = new Size(272, 22);
            devolucionDeProductosToolStripMenuItem.Text = "Devolucion de Productos";
            devolucionDeProductosToolStripMenuItem.Click += devolucionDeProductosToolStripMenuItem_Click;
            // 
            // facturasDeClientesToolStripMenuItem
            // 
            facturasDeClientesToolStripMenuItem.Name = "facturasDeClientesToolStripMenuItem";
            facturasDeClientesToolStripMenuItem.Size = new Size(272, 22);
            facturasDeClientesToolStripMenuItem.Text = "Facturas de Clientes";
            facturasDeClientesToolStripMenuItem.Click += facturasDeClientesToolStripMenuItem_Click;
            // 
            // detalleDeFacturasToolStripMenuItem
            // 
            detalleDeFacturasToolStripMenuItem.Name = "detalleDeFacturasToolStripMenuItem";
            detalleDeFacturasToolStripMenuItem.Size = new Size(272, 22);
            detalleDeFacturasToolStripMenuItem.Text = "Detalle de Facturas";
            detalleDeFacturasToolStripMenuItem.Click += detalleDeFacturasToolStripMenuItem_Click;
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { informacionToolStripMenuItem, datosDeContactoToolStripMenuItem, versionToolStripMenuItem });
            acercaDeToolStripMenuItem.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(86, 20);
            acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // informacionToolStripMenuItem
            // 
            informacionToolStripMenuItem.Name = "informacionToolStripMenuItem";
            informacionToolStripMenuItem.Size = new Size(199, 22);
            informacionToolStripMenuItem.Text = "Informacion";
            informacionToolStripMenuItem.Click += informacionToolStripMenuItem_Click;
            // 
            // datosDeContactoToolStripMenuItem
            // 
            datosDeContactoToolStripMenuItem.Name = "datosDeContactoToolStripMenuItem";
            datosDeContactoToolStripMenuItem.Size = new Size(199, 22);
            datosDeContactoToolStripMenuItem.Text = "Datos de Contacto";
            datosDeContactoToolStripMenuItem.Click += datosDeContactoToolStripMenuItem_Click;
            // 
            // versionToolStripMenuItem
            // 
            versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            versionToolStripMenuItem.Size = new Size(199, 22);
            versionToolStripMenuItem.Text = "Version";
            versionToolStripMenuItem.Click += versionToolStripMenuItem_Click;
            // 
            // labelProducto
            // 
            labelProducto.AutoSize = true;
            labelProducto.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelProducto.Location = new Point(13, 38);
            labelProducto.Margin = new Padding(4, 0, 4, 0);
            labelProducto.Name = "labelProducto";
            labelProducto.Size = new Size(129, 25);
            labelProducto.TabIndex = 3;
            labelProducto.Text = "Productos";
            labelProducto.Click += labelProducto_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnNuevo.Location = new Point(13, 406);
            btnNuevo.Margin = new Padding(4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(113, 32);
            btnNuevo.TabIndex = 5;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += button2_Click;
            // 
            // txtCodigoProd
            // 
            txtCodigoProd.Location = new Point(130, 34);
            txtCodigoProd.Name = "txtCodigoProd";
            txtCodigoProd.Size = new Size(351, 23);
            txtCodigoProd.TabIndex = 6;
            txtCodigoProd.TextChanged += textBox1_TextChanged;
            // 
            // btnConsultar
            // 
            btnConsultar.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnConsultar.Location = new Point(660, 28);
            btnConsultar.Margin = new Padding(4);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(113, 32);
            btnConsultar.TabIndex = 8;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // dataGridViewProductos
            // 
            dataGridViewProductos.AllowUserToAddRows = false;
            dataGridViewProductos.AllowUserToDeleteRows = false;
            dataGridViewProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProductos.Columns.AddRange(new DataGridViewColumn[] { Codigo, Nombre, Precio, Origen, Categoria });
            dataGridViewProductos.Location = new Point(7, 68);
            dataGridViewProductos.Margin = new Padding(4);
            dataGridViewProductos.Name = "dataGridViewProductos";
            dataGridViewProductos.ReadOnly = true;
            dataGridViewProductos.RowHeadersWidth = 82;
            dataGridViewProductos.RowTemplate.Height = 25;
            dataGridViewProductos.Size = new Size(907, 251);
            dataGridViewProductos.TabIndex = 2;
            dataGridViewProductos.CellContentClick += dataGridView1_CellContentClick;
            // 
            // grpFiltro
            // 
            grpFiltro.Controls.Add(labelbuscar);
            grpFiltro.Controls.Add(btnConsultar);
            grpFiltro.Controls.Add(txtCodigoProd);
            grpFiltro.Controls.Add(dataGridViewProductos);
            grpFiltro.Location = new Point(13, 66);
            grpFiltro.Name = "grpFiltro";
            grpFiltro.Size = new Size(921, 333);
            grpFiltro.TabIndex = 9;
            grpFiltro.TabStop = false;
            grpFiltro.Text = "Filtros";
            // 
            // labelbuscar
            // 
            labelbuscar.AutoSize = true;
            labelbuscar.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelbuscar.Location = new Point(7, 37);
            labelbuscar.Margin = new Padding(4, 0, 4, 0);
            labelbuscar.Name = "labelbuscar";
            labelbuscar.Size = new Size(116, 16);
            labelbuscar.TabIndex = 9;
            labelbuscar.Text = "Codigo/Producto";
            // 
            // Codigo
            // 
            Codigo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Codigo.HeaderText = "codigo";
            Codigo.MinimumWidth = 10;
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nombre.HeaderText = "nombre";
            Nombre.MinimumWidth = 10;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Precio.HeaderText = "precio";
            Precio.MinimumWidth = 10;
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // Origen
            // 
            Origen.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Origen.HeaderText = "origen";
            Origen.MinimumWidth = 10;
            Origen.Name = "Origen";
            Origen.ReadOnly = true;
            // 
            // Categoria
            // 
            Categoria.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Categoria.HeaderText = "categoria";
            Categoria.MinimumWidth = 10;
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(946, 467);
            Controls.Add(grpFiltro);
            Controls.Add(btnNuevo);
            Controls.Add(labelProducto);
            Controls.Add(menuStrip1);
            Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "ProductForm";
            Text = "Productos";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).EndInit();
            grpFiltro.ResumeLayout(false);
            grpFiltro.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem categoriaToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem soporteToolStripMenuItem;
        private ToolStripMenuItem origenToolStripMenuItem;
        private ToolStripMenuItem consultasToolStripMenuItem;
        private ToolStripMenuItem RutasConductoresToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private ToolStripMenuItem informacionToolStripMenuItem;
        private ToolStripMenuItem datosDeContactoToolStripMenuItem;
        private ToolStripMenuItem versionToolStripMenuItem;
        private Label labelProducto;
        private Button btnNuevo;
        private TextBox textBox1;
        private Button btnConsultar;
        private DataGridView dataGridViewProductos;
        private GroupBox grpFiltro;
        private Label labelbuscar;
        private TextBox txtCodigoProd;
        private ToolStripMenuItem verVentasToolStripMenuItem;
        private ToolStripMenuItem detallesDeProductosToolStripMenuItem;
        private ToolStripMenuItem mayorCapacidadDeGalponesToolStripMenuItem;
        private ToolStripMenuItem devolucionDeProductosToolStripMenuItem;
        private ToolStripMenuItem facturasDeClientesToolStripMenuItem;
        private ToolStripMenuItem detalleDeFacturasToolStripMenuItem;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Origen;
        private DataGridViewTextBoxColumn Categoria;
    }
}
