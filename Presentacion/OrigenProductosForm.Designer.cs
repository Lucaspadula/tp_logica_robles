namespace tp_logica_robles.Presentacion
{
    partial class OrigenProductosForm
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
            dgvOrigenProductos = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            btnConsultar = new Button();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvOrigenProductos).BeginInit();
            SuspendLayout();
            // 
            // dgvOrigenProductos
            // 
            dgvOrigenProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrigenProductos.Columns.AddRange(new DataGridViewColumn[] { colId, colNombre });
            dgvOrigenProductos.Location = new Point(46, 57);
            dgvOrigenProductos.Name = "dgvOrigenProductos";
            dgvOrigenProductos.RowTemplate.Height = 25;
            dgvOrigenProductos.Size = new Size(245, 150);
            dgvOrigenProductos.TabIndex = 0;
            // 
            // colId
            // 
            colId.HeaderText = "Id";
            colId.Name = "colId";
            colId.Visible = false;
            // 
            // colNombre
            // 
            colNombre.HeaderText = "Origen";
            colNombre.Name = "colNombre";
            colNombre.Width = 200;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(216, 28);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 1;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(216, 213);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 2;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // OrigenProductosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 247);
            Controls.Add(btnVolver);
            Controls.Add(btnConsultar);
            Controls.Add(dgvOrigenProductos);
            Name = "OrigenProductosForm";
            Text = "OrigenProductosForm";
            ((System.ComponentModel.ISupportInitialize)dgvOrigenProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvOrigenProductos;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colNombre;
        private Button btnConsultar;
        private Button btnVolver;
    }
}