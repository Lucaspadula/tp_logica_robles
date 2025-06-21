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
            ejVerProductosToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            informacionToolStripMenuItem = new ToolStripMenuItem();
            datosDeContactoToolStripMenuItem = new ToolStripMenuItem();
            versionToolStripMenuItem = new ToolStripMenuItem();
            labelProducto = new Label();
            btnNuevo = new Button();
            txtCodigoProd = new TextBox();
            btnConsultar = new Button();
            dataGridViewProductos = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Origen = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            grpFiltro = new GroupBox();
            labelbuscar = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).BeginInit();
            grpFiltro.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, soporteToolStripMenuItem, consultasToolStripMenuItem, acercaDeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(809, 24);
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
            origenToolStripMenuItem.Size = new Size(180, 22);
            origenToolStripMenuItem.Text = "Origen";
            origenToolStripMenuItem.Click += origenToolStripMenuItem_Click;
            // 
            // consultasToolStripMenuItem
            // 
            consultasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ejVerProductosToolStripMenuItem });
            consultasToolStripMenuItem.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            consultasToolStripMenuItem.Size = new Size(83, 20);
            consultasToolStripMenuItem.Text = "Consultas";
            // 
            // ejVerProductosToolStripMenuItem
            // 
            ejVerProductosToolStripMenuItem.Name = "ejVerProductosToolStripMenuItem";
            ejVerProductosToolStripMenuItem.Size = new Size(189, 22);
            ejVerProductosToolStripMenuItem.Text = "ej: ver productos";
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
            // 
            // datosDeContactoToolStripMenuItem
            // 
            datosDeContactoToolStripMenuItem.Name = "datosDeContactoToolStripMenuItem";
            datosDeContactoToolStripMenuItem.Size = new Size(199, 22);
            datosDeContactoToolStripMenuItem.Text = "Datos de Contacto";
            // 
            // versionToolStripMenuItem
            // 
            versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            versionToolStripMenuItem.Size = new Size(199, 22);
            versionToolStripMenuItem.Text = "Version";
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
            dataGridViewProductos.AllowUserToDeleteRows = false;
            dataGridViewProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProductos.Columns.AddRange(new DataGridViewColumn[] { Codigo, Nombre, Precio, Origen, Categoria });
            dataGridViewProductos.Location = new Point(19, 68);
            dataGridViewProductos.Margin = new Padding(4);
            dataGridViewProductos.Name = "dataGridViewProductos";
            dataGridViewProductos.ReadOnly = true;
            dataGridViewProductos.RowTemplate.Height = 25;
            dataGridViewProductos.Size = new Size(754, 251);
            dataGridViewProductos.TabIndex = 2;
            dataGridViewProductos.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "codigo";
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nombre.HeaderText = "nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.HeaderText = "precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // Origen
            // 
            Origen.HeaderText = "origen";
            Origen.Name = "Origen";
            Origen.ReadOnly = true;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "categoria";
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            // 
            // grpFiltro
            // 
            grpFiltro.Controls.Add(labelbuscar);
            grpFiltro.Controls.Add(btnConsultar);
            grpFiltro.Controls.Add(txtCodigoProd);
            grpFiltro.Controls.Add(dataGridViewProductos);
            grpFiltro.Location = new Point(13, 66);
            grpFiltro.Name = "grpFiltro";
            grpFiltro.Size = new Size(785, 333);
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
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 455);
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
        private ToolStripMenuItem ejVerProductosToolStripMenuItem;
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
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Origen;
        private DataGridViewTextBoxColumn Categoria;
        private TextBox txtCodigoProd;
    }
}
