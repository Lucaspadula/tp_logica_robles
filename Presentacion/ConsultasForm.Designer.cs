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
            labelDescripcion = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 108);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 310);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // labelDescripcion
            // 
            labelDescripcion.AutoSize = true;
            labelDescripcion.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelDescripcion.Location = new Point(12, 62);
            labelDescripcion.Name = "labelDescripcion";
            labelDescripcion.Size = new Size(82, 16);
            labelDescripcion.TabIndex = 1;
            labelDescripcion.Text = "Descripción";
            labelDescripcion.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(359, 217);
            label1.Name = "label1";
            label1.Size = new Size(82, 16);
            label1.TabIndex = 2;
            label1.Text = "Descripción";
            label1.Click += label1_Click_1;
            // 
            // ConsultasForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(labelDescripcion);
            Controls.Add(groupBox1);
            Name = "ConsultasForm";
            Text = "ConsultasForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label labelDescripcion;
        private Label label1;
    }
}