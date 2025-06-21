using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tp_logica_robles.Datos;

namespace tp_logica_robles.Presentacion
{
    public partial class OrigenProductosForm : Form
    {
        AccesoDatos accesoDatos;
        public OrigenProductosForm()
        {
            InitializeComponent();
            accesoDatos = new AccesoDatos();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string consultaSQL = "select * from origen_productos";
            CargarGrilla(consultaSQL);
        }

        private void CargarGrilla(string consultaSQL)
        {
            DataTable dataTable = accesoDatos.ConsultarBD(consultaSQL);
            dgvOrigenProductos.Rows.Clear();
            foreach (DataRow row in dataTable.Rows)
            {
                dgvOrigenProductos.Rows.Add(row[0], row[1]);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea volver atras?",
                                                  "Volver",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
