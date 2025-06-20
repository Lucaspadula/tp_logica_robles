namespace tp_logica_robles.Presentacion
{
    partial class CategoriaForm
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
            btnVolver = new Button();
            dgvCategoria = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colCategoria = new DataGridViewTextBoxColumn();
            colSubCategoria = new DataGridViewTextBoxColumn();
            label1 = new Label();
            txtCategoria = new TextBox();
            btnBuscar = new Button();
            cboSubCategoria = new ComboBox();
            label2 = new Label();
            btnNuevaCategoria = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).BeginInit();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(477, 334);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // dgvCategoria
            // 
            dgvCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategoria.Columns.AddRange(new DataGridViewColumn[] { colId, colCategoria, colSubCategoria });
            dgvCategoria.Location = new Point(45, 133);
            dgvCategoria.Name = "dgvCategoria";
            dgvCategoria.RowTemplate.Height = 25;
            dgvCategoria.Size = new Size(507, 181);
            dgvCategoria.TabIndex = 2;
            // 
            // colId
            // 
            colId.HeaderText = "id";
            colId.Name = "colId";
            colId.Visible = false;
            // 
            // colCategoria
            // 
            colCategoria.HeaderText = "Categoria";
            colCategoria.Name = "colCategoria";
            colCategoria.Width = 150;
            // 
            // colSubCategoria
            // 
            colSubCategoria.HeaderText = "Sub Categoria";
            colSubCategoria.Name = "colSubCategoria";
            colSubCategoria.Width = 300;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 43);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(61, 15);
            label1.TabIndex = 3;
            label1.Text = "Categoria:";
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(112, 40);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(171, 23);
            txtCategoria.TabIndex = 4;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(477, 91);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 5;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // cboSubCategoria
            // 
            cboSubCategoria.FormattingEnabled = true;
            cboSubCategoria.Location = new Point(135, 75);
            cboSubCategoria.Name = "cboSubCategoria";
            cboSubCategoria.Size = new Size(182, 23);
            cboSubCategoria.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 78);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 7;
            label2.Text = "Sub Categoria:";
            // 
            // btnNuevaCategoria
            // 
            btnNuevaCategoria.Location = new Point(45, 334);
            btnNuevaCategoria.Name = "btnNuevaCategoria";
            btnNuevaCategoria.Size = new Size(114, 23);
            btnNuevaCategoria.TabIndex = 8;
            btnNuevaCategoria.Text = "Nueva categoria";
            btnNuevaCategoria.UseVisualStyleBackColor = true;
            btnNuevaCategoria.Click += btnNuevaCategoria_Click;
            // 
            // CategoriaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 383);
            Controls.Add(btnNuevaCategoria);
            Controls.Add(label2);
            Controls.Add(cboSubCategoria);
            Controls.Add(btnBuscar);
            Controls.Add(txtCategoria);
            Controls.Add(label1);
            Controls.Add(dgvCategoria);
            Controls.Add(btnVolver);
            Name = "CategoriaForm";
            Text = "CategoriaForm";
            Load += CategoriaForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnVolver;
        private DataGridView dgvCategoria;
        private Label label1;
        private TextBox txtCategoria;
        private Button btnBuscar;
        private ComboBox cboSubCategoria;
        private Label label2;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colCategoria;
        private DataGridViewTextBoxColumn colSubCategoria;
        private Button btnNuevaCategoria;
    }
}