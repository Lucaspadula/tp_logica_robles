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
    public partial class CategoriaForm : Form
    {
        AccesoDatos accesoDatos;
        public CategoriaForm()
        {
            InitializeComponent();
            accesoDatos = new AccesoDatos();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CategoriaForm_Load(object sender, EventArgs e)
        {
            CargarCombo();
        }

        private void CargarCombo()
        {
            DataTable dataTable = accesoDatos.ConsultarTabla("sub_categorias");
            cboSubCategoria.DataSource = dataTable;
            cboSubCategoria.ValueMember = dataTable.Columns[0].ColumnName;
            cboSubCategoria.DisplayMember = dataTable.Columns[1].ColumnName;
            cboSubCategoria.SelectedIndex = -1;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string consultaSQL = "select c.ID, c.NOMBRE, sc.DESCRIPCION_SUB_CATEGORIA " +
                                 " from CATEGORIAS c join SUB_CATEGORIAS sc on c.ID_SUB_CATEGORIA = sc.ID ";

            if (!string.IsNullOrEmpty(txtCategoria.Text))
            {
                consultaSQL += " where c.nombre like '%" + txtCategoria.Text + "%'";
            }
            if (!string.IsNullOrEmpty(txtCategoria.Text) && cboSubCategoria.SelectedIndex != -1)
            {
                consultaSQL += " and sc.id = " + cboSubCategoria.SelectedValue;
            }
            if (cboSubCategoria.SelectedIndex != -1 && string.IsNullOrEmpty(txtCategoria.Text))
            {
                consultaSQL += " where sc.id = " + cboSubCategoria.SelectedValue;
            }

            CargarGrilla(consultaSQL);
        }

        private void CargarGrilla(string consultaSQL)
        {
            DataTable dataTable = accesoDatos.ConsultarBD(consultaSQL);
            dgvCategoria.Rows.Clear();
            foreach (DataRow row in dataTable.Rows)
            {
                dgvCategoria.Rows.Add(row[0], row[1], row[2]);
            }
        }

        private void btnNuevaCategoria_Click(object sender, EventArgs e)
        {
            AgregarCategoriaForm agregarCategoriaForm = new AgregarCategoriaForm();
            agregarCategoriaForm.ShowDialog();
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
