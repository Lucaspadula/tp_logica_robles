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
            textBox1 = new TextBox();
            btnConsultar = new Button();
            Categoria = new DataGridViewTextBoxColumn();
            Origen = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Codigo = new DataGridViewTextBoxColumn();
            dataGridView1 = new DataGridView();
            grpFiltro = new GroupBox();
            labelbuscar = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(137, 22);
            salirToolStripMenuItem.Text = "Salir";
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
            btnNuevo.Margin = new Padding(4, 4, 4, 4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(113, 32);
            btnNuevo.TabIndex = 5;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(130, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(351, 23);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged;
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
            // 
            // Categoria
            // 
            Categoria.HeaderText = "categoria";
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            // 
            // Origen
            // 
            Origen.HeaderText = "origen";
            Origen.Name = "Origen";
            Origen.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nombre.HeaderText = "nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "codigo";
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Codigo, Nombre, Origen, Categoria });
            dataGridView1.Location = new Point(19, 68);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(754, 251);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // grpFiltro
            // 
            grpFiltro.Controls.Add(labelbuscar);
            grpFiltro.Controls.Add(btnConsultar);
            grpFiltro.Controls.Add(textBox1);
            grpFiltro.Controls.Add(dataGridView1);
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
            // Product
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 455);
            Controls.Add(grpFiltro);
            Controls.Add(btnNuevo);
            Controls.Add(labelProducto);
            Controls.Add(menuStrip1);
            Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Product";
            Text = "Productos";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Origen;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridView dataGridView1;
        private GroupBox grpFiltro;
        private Label labelbuscar;
    }
}
