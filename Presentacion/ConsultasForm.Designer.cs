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
            groupBox1.Location = new Point(13, 203);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(819, 310);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // dgbConsulta
            // 
            dgbConsulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgbConsulta.Location = new Point(15, 34);
            dgbConsulta.Name = "dgbConsulta";
            dgbConsulta.RowHeadersWidth = 82;
            dgbConsulta.RowTemplate.Height = 25;
            dgbConsulta.Size = new Size(779, 257);
            dgbConsulta.TabIndex = 0;
            // 
            // labelDescripcion
            // 
            labelDescripcion.AutoSize = true;
            labelDescripcion.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelDescripcion.Location = new Point(12, 77);
            labelDescripcion.Name = "labelDescripcion";
            labelDescripcion.Size = new Size(88, 16);
            labelDescripcion.TabIndex = 1;
            labelDescripcion.Text = "Descripción:";
            labelDescripcion.Click += label1_Click;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescripcion.Location = new Point(27, 106);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(270, 16);
            lblDescripcion.TabIndex = 2;
            lblDescripcion.Text = "Descripcion de la consulta seleccionada";
            lblDescripcion.Click += label1_Click_1;
            // 
            // lblTituloConsulta
            // 
            lblTituloConsulta.AutoSize = true;
            lblTituloConsulta.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTituloConsulta.Location = new Point(13, 21);
            lblTituloConsulta.Margin = new Padding(4, 0, 4, 0);
            lblTituloConsulta.Name = "lblTituloConsulta";
            lblTituloConsulta.Size = new Size(114, 25);
            lblTituloConsulta.TabIndex = 11;
            lblTituloConsulta.Text = "Consulta";
            lblTituloConsulta.Click += lblTituloConsulta_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(721, 519);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 13;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // ConsultasForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 558);
            Controls.Add(btnSalir);
            Controls.Add(lblTituloConsulta);
            Controls.Add(lblDescripcion);
            Controls.Add(labelDescripcion);
            Controls.Add(groupBox1);
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