namespace tp_logica_robles.Presentacion
{
    partial class AgregarCategoriaForm
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
            btnAgregar = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            label2 = new Label();
            txtCategoria = new TextBox();
            cboSubCategoria = new ComboBox();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(12, 203);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(176, 203);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 47);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 2;
            label1.Text = "Categoria";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 107);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 3;
            label2.Text = "Sub Categoria";
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(76, 44);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(175, 23);
            txtCategoria.TabIndex = 4;
            // 
            // cboSubCategoria
            // 
            cboSubCategoria.FormattingEnabled = true;
            cboSubCategoria.Location = new Point(99, 104);
            cboSubCategoria.Name = "cboSubCategoria";
            cboSubCategoria.Size = new Size(152, 23);
            cboSubCategoria.TabIndex = 5;
            // 
            // AgregarCategoriaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(263, 244);
            Controls.Add(cboSubCategoria);
            Controls.Add(txtCategoria);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Name = "AgregarCategoriaForm";
            Text = "AgregarCategoriaForm";
            Load += AgregarCategoriaForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private Button btnCancelar;
        private Label label1;
        private Label label2;
        private TextBox txtCategoria;
        private ComboBox cboSubCategoria;
    }
}