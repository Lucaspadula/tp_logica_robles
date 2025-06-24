using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tp_logica_robles.Servicios;


namespace tp_logica_robles.Presentacion
{
    public partial class AcercadeForm : Form
    {
        public enum TipoAcercade
        {
            Informacion,
            DatosContacto,
            Version,

        }
        public Label LblDescripcion
        {
            get { return lblDescripcion; }
        }

        public Label LblTituloAcercade
        {
            get { return lblTituloAcercade; }
        }



        public AcercadeForm()
        {
            InitializeComponent();
        }
        private TipoAcercade _tipoAcercade;
        ServicioConsultasAcercade servicioConsultasAcercadeForm = new ServicioConsultasAcercade();
        public AcercadeForm(TipoAcercade tipoAcercade)
        {
            InitializeComponent();
            _tipoAcercade = tipoAcercade;
            servicioConsultasAcercadeForm.MostrarConsulta(this, _tipoAcercade);

        }
        private void lblTituloAcercade_Click(object sender, EventArgs e)
        {

        }


        

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¨¿Estas seguro que desea salir? ", "Saliendo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
