namespace tp_logica_robles.Presentacion
{
    partial class ConsultasForm
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
            dgbConsulta = new DataGridView();
            labelDescripcion = new Label();
            lblDescripcion = new Label();
            lblTituloConsulta = new Label();
            btnSalir = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgbConsulta).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgbConsulta);
            groupBox1.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(24, 433);
            groupBox1.Margin = new Padding(6, 6, 6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(6, 6, 6, 6);
            groupBox1.Size = new Size(1521, 661);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // dgbConsulta
            // 
            dgbConsulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgbConsulta.Location = new Point(28, 73);
            dgbConsulta.Margin = new Padding(6, 6, 6, 6);
            dgbConsulta.Name = "dgbConsulta";
            dgbConsulta.RowHeadersWidth = 82;
            dgbConsulta.RowTemplate.Height = 25;
            dgbConsulta.Size = new Size(1447, 548);
            dgbConsulta.TabIndex = 0;
            // 
            // labelDescripcion
            // 
            labelDescripcion.AutoSize = true;
            labelDescripcion.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelDescripcion.Location = new Point(22, 164);
            labelDescripcion.Margin = new Padding(6, 0, 6, 0);
            labelDescripcion.Name = "labelDescripcion";
            labelDescripcion.Size = new Size(176, 32);
            labelDescripcion.TabIndex = 1;
            labelDescripcion.Text = "Descripción:";
            labelDescripcion.Click += label1_Click;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescripcion.Location = new Point(50, 226);
            lblDescripcion.Margin = new Padding(6, 0, 6, 0);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(529, 32);
            lblDescripcion.TabIndex = 2;
            lblDescripcion.Text = "Descripcion de la consulta seleccionada";
            lblDescripcion.Click += label1_Click_1;
            // 
            // lblTituloConsulta
            // 
            lblTituloConsulta.AutoSize = true;
            lblTituloConsulta.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTituloConsulta.Location = new Point(24, 45);
            lblTituloConsulta.Margin = new Padding(7, 0, 7, 0);
            lblTituloConsulta.Name = "lblTituloConsulta";
            lblTituloConsulta.Size = new Size(227, 51);
            lblTituloConsulta.TabIndex = 11;
            lblTituloConsulta.Text = "Consulta";
            lblTituloConsulta.Click += lblTituloConsulta_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(1339, 1107);
            btnSalir.Margin = new Padding(6, 6, 6, 6);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(139, 49);
            btnSalir.TabIndex = 13;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // ConsultasForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1567, 1182);
            Controls.Add(btnSalir);
            Controls.Add(lblTituloConsulta);
            Controls.Add(lblDescripcion);
            Controls.Add(labelDescripcion);
            Controls.Add(groupBox1);
            Margin = new Padding(6, 6, 6, 6);
            Name = "ConsultasForm";
            Text = "Consulta";
            Load += ConsultasForm_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgbConsulta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label labelDescripcion;
        private Label lblDescripcion;
        private DataGridView dgbConsulta;
        private Label lblTituloConsulta;
        private Button btnSalir;
    }
}