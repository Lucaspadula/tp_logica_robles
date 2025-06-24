namespace tp_logica_robles.Presentacion
{
    partial class AcercadeForm
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
            lblTituloAcercade = new Label();
            lblDescripcion = new Label();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lblTituloAcercade
            // 
            lblTituloAcercade.AutoSize = true;
            lblTituloAcercade.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTituloAcercade.Location = new Point(63, 74);
            lblTituloAcercade.Margin = new Padding(7, 0, 7, 0);
            lblTituloAcercade.Name = "lblTituloAcercade";
            lblTituloAcercade.Size = new Size(297, 51);
            lblTituloAcercade.TabIndex = 12;
            lblTituloAcercade.Text = "Descripción";
            lblTituloAcercade.Click += lblTituloAcercade_Click;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescripcion.Location = new Point(133, 200);
            lblDescripcion.Margin = new Padding(6, 0, 6, 0);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(529, 32);
            lblDescripcion.TabIndex = 14;
            lblDescripcion.Text = "Descripcion de la consulta seleccionada";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(523, 458);
            btnSalir.Margin = new Padding(6);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(139, 49);
            btnSalir.TabIndex = 15;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click_1;
            // 
            // AcercadeForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(771, 594);
            Controls.Add(btnSalir);
            Controls.Add(lblDescripcion);
            Controls.Add(lblTituloAcercade);
            Name = "AcercadeForm";
            Text = "AcercadeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloAcercade;
        private Label lblDescripcion;
        private Button btnSalir;
    }
}