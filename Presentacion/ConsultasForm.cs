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
using tp_logica_robles.Utilidades;

namespace tp_logica_robles.Presentacion
{
    public partial class ConsultasForm : Form
    {
        public enum TipoConsulta
        {
            HrConductores,
            CanalesComunicacion,
            DetalleProducto,
            GalponesMayorCapacidad,
            DevolucionProducto,
            FacturasDeClientes,
            DetalleDeFacturas
        }
        public DataGridView DGBProductos
        {
            get { return dgbConsulta; }
        }

        public Label LblDescripcion
        {
            get { return lblDescripcion; }
        }

        public Label LblTituloConsulta
        {
            get { return lblTituloConsulta; }
        }
        public ConsultasForm()
        {
            InitializeComponent();
        }
        private TipoConsulta _tipoConsulta;
        ServicioConsultasForm servicioConsultasForm = new ServicioConsultasForm();
        public ConsultasForm(TipoConsulta tipoConsulta)
        {
            InitializeComponent();
            _tipoConsulta = tipoConsulta;
            servicioConsultasForm.MostrarConsulta(this, _tipoConsulta);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¨¿Estas seguro que desea salir? ", "Saliendo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ConsultasForm_Load(object sender, EventArgs e)
        {
            FormsFijos.ConfigurarFormFijo(this);

        }

    }
}
