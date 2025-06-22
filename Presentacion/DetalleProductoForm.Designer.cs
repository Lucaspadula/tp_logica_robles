namespace tp_logica_robles.Presentacion
{
    partial class DetalleProductoForm
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
            label1 = new Label();
            txt_Nom_Prod = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txt_precio = new TextBox();
            txt_descrip = new TextBox();
            btn_guardar = new Button();
            btn_salir = new Button();
            cboCategoria = new ComboBox();
            cboOrigen = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, 55);
            label1.Name = "label1";
            label1.Size = new Size(125, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre del Produto : ";
            label1.Click += label1_Click;
            // 
            // txt_Nom_Prod
            // 
            txt_Nom_Prod.Location = new Point(260, 52);
            txt_Nom_Prod.Name = "txt_Nom_Prod";
            txt_Nom_Prod.Size = new Size(151, 23);
            txt_Nom_Prod.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(149, 130);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 2;
            label2.Text = "Precio Unitario : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(165, 183);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 3;
            label3.Text = "Descripcion : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(129, 249);
            label4.Name = "label4";
            label4.Size = new Size(132, 15);
            label4.TabIndex = 4;
            label4.Text = "Categoria del Produto : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(129, 306);
            label5.Name = "label5";
            label5.Size = new Size(123, 15);
            label5.TabIndex = 5;
            label5.Text = "Origen del Producto : ";
            // 
            // txt_precio
            // 
            txt_precio.Location = new Point(260, 122);
            txt_precio.Name = "txt_precio";
            txt_precio.Size = new Size(151, 23);
            txt_precio.TabIndex = 6;
            // 
            // txt_descrip
            // 
            txt_descrip.Location = new Point(260, 180);
            txt_descrip.Name = "txt_descrip";
            txt_descrip.Size = new Size(151, 23);
            txt_descrip.TabIndex = 7;
            // 
            // btn_guardar
            // 
            btn_guardar.Location = new Point(118, 380);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(94, 28);
            btn_guardar.TabIndex = 10;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = true;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // btn_salir
            // 
            btn_salir.Location = new Point(364, 380);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(94, 28);
            btn_salir.TabIndex = 11;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += btn_salir_Click;
            // 
            // cboCategoria
            // 
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(263, 248);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(148, 23);
            cboCategoria.TabIndex = 12;
            // 
            // cboOrigen
            // 
            cboOrigen.FormattingEnabled = true;
            cboOrigen.Location = new Point(263, 303);
            cboOrigen.Name = "cboOrigen";
            cboOrigen.Size = new Size(148, 23);
            cboOrigen.TabIndex = 13;
            // 
            // DetalleProductoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cboOrigen);
            Controls.Add(cboCategoria);
            Controls.Add(btn_salir);
            Controls.Add(btn_guardar);
            Controls.Add(txt_descrip);
            Controls.Add(txt_precio);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_Nom_Prod);
            Controls.Add(label1);
            Name = "DetalleProductoForm";
            Text = "AgregrarProducto";
            Load += AgregrarProducto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_Nom_Prod;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txt_precio;
        private TextBox txt_descrip;
        private Button btn_guardar;
        private Button btn_salir;
        private ComboBox cboCategoria;
        private ComboBox cboOrigen;
    }
}