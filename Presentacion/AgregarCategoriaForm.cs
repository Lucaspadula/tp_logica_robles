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
using tp_logica_robles.Negocio;

namespace tp_logica_robles.Presentacion
{
    public partial class AgregarCategoriaForm : Form
    {
        AccesoDatos accesoDatos;
        Categorias categoria = new Categorias();
        List<Parametro> parametro = new List<Parametro>();
        public AgregarCategoriaForm()
        {
            InitializeComponent();
            accesoDatos = new AccesoDatos();
        }

        private void AgregarCategoriaForm_Load(object sender, EventArgs e)
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea cancelar la operacion?",
                                                  "Cancelar",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            categoria.Nombre = txtCategoria.Text;
            categoria.Id_sub_categoria = Convert.ToInt32(cboSubCategoria.SelectedValue);
            string consultaSQL = "insert into categorias (nombre, id_sub_categoria) " +
                                 "values                (@nombre, @id_sub_categoria)";
            parametro.Add(new Parametro("@nombre", categoria.Nombre));
            parametro.Add(new Parametro("@id_sub_categoria", categoria.Id_sub_categoria));

            AgregarCategoria(consultaSQL, parametro);
        }

        private void AgregarCategoria(string consultaSQL, List<Parametro> parametro)
        {
            int filasAfecctadas = accesoDatos.ActualizarBD(consultaSQL, parametro);
            if (filasAfecctadas == 0)
            {
                MessageBox.Show("No se pudo agregar la categoria.");
            }
            else
            {
                MessageBox.Show("Categoria agregada con exito.");
                this.Close();
            }
        }
    }
}
