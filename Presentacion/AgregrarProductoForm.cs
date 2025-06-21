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
    public partial class AgregrarProductoForm : Form
    {
        ServicioFormAgregarProducto servicioFormAgregarProducto = new ServicioFormAgregarProducto();
        public enum Modo
        {
            Nuevo,
            Editar,
            Eliminar
        }
        public AgregrarProductoForm(int codigoArticulo, Modo modo)
        {
            InitializeComponent();

        }
        public AgregrarProductoForm()
        {
            InitializeComponent();
            DataTable dtCategoria = new DataTable();

            dtCategoria = servicioFormAgregarProducto.cargarComboCategoria();
            cboCategoria.DataSource = dtCategoria;
            cboCategoria.DisplayMember = dtCategoria.Columns[1].ColumnName;
            cboCategoria.ValueMember = "ID";

            DataTable dtOrigen = new DataTable();
            dtOrigen = servicioFormAgregarProducto.cargarComboOrigen();
            cboOrigen.DataSource = dtOrigen;
            cboOrigen.DisplayMember = "NOMBRE";
            cboOrigen.ValueMember = "ID";
        }

        private void AgregrarProducto_Load(object sender, EventArgs e)
        {

        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            //int response = servicioFormAgregarProducto.guardarNuevo();
        }
    }
}
