using System.Diagnostics;
using tp_logica_robles.Datos;
using tp_logica_robles.Presentacion;
using tp_logica_robles.Servicios;
using tp_logica_robles.Utilidades;
using static tp_logica_robles.Presentacion.AcercadeForm;
using static tp_logica_robles.Presentacion.ConsultasForm;
using static tp_logica_robles.Presentacion.DetalleProductoForm;

namespace tp_logica_robles
{
    public partial class ProductForm : Form
    {
        ServicioFormProductos servicioFormProductos = new ServicioFormProductos();
        public ProductForm()
        {
            InitializeComponent();

        }

        public DataGridView DataGridViewProductos
        {
            get { return dataGridViewProductos; }
        }

        public TextBox textBoxCodigoProd
        {
            get { return txtCodigoProd; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormsFijos.ConfigurarFormFijo(this);
            servicioFormProductos.cargarBtnGrilla(this);
            GridUtilidad.ConfigurarGrid(dataGridViewProductos);


        }



        private void labelProducto_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DetalleProductoForm agregrarProductoForm = new DetalleProductoForm();
            agregrarProductoForm.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int codigoProducto = Convert.ToInt32(dataGridViewProductos.Rows[e.RowIndex].Cells["codigo"].Value);
                string nomProducto = (string)dataGridViewProductos.Rows[e.RowIndex].Cells["nombre"].Value;
                if (e.ColumnIndex == dataGridViewProductos.Columns[5].Index)
                {
                    DetalleProductoForm agregrarProductoForm = new DetalleProductoForm(codigoProducto, Modo.Editar);
                    agregrarProductoForm.ShowDialog();
                }
                if (e.ColumnIndex == dataGridViewProductos.Columns[6].Index)
                {
                    DialogResult result = MessageBox.Show($"Desea eliminar el producto {nomProducto}", "CONFIRMACION", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        int filasAfectadas = servicioFormProductos.EliminarProducto(codigoProducto);
                        if (filasAfectadas == 0)
                        {
                            MessageBox.Show($"No se pudo eliminar el producto: {nomProducto}.");
                        }
                        else
                        {
                            MessageBox.Show($"El producto {nomProducto} se elimino con exito.");
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error al hacer click en algun campo {ex}");
            }


        }


        private void labelbuscar_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            servicioFormProductos.btnConsultar(this);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Cerrar aplicación?",
                                                  "Salir",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoriaForm categoriaForm = new CategoriaForm();
            categoriaForm.ShowDialog();
        }

        private void nuevaCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoriaForm categoriaForm = new CategoriaForm();
            categoriaForm.ShowDialog();
        }

        private void origenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrigenProductosForm origenProductosForm = new OrigenProductosForm();
            origenProductosForm.ShowDialog();
        }

        private void RutasConductoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioConsulta(TipoConsulta.HrConductores);
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void AbrirFormularioConsulta(TipoConsulta tipoConsulta)
        {
            var frm = new ConsultasForm(tipoConsulta);
            frm.ShowDialog();
        }

        private void canalesComunicacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioConsulta(TipoConsulta.CanalesComunicacion);


        }

        private void detallesDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioConsulta(TipoConsulta.DetalleProducto);
        }

        private void mayorCapacidadDeGalponesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioConsulta(TipoConsulta.GalponesMayorCapacidad);
        }

        private void devolucionDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioConsulta(TipoConsulta.DevolucionProducto);
        }

        private void facturasDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioConsulta(TipoConsulta.FacturasDeClientes);
        }

        private void detalleDeFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioConsulta(TipoConsulta.DetalleDeFacturas);
        }

        private void informacionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AbrirFormularioAcercade(TipoAcercade.Informacion);
        }

        private void AbrirFormularioAcercade(TipoAcercade acercaDe)
        {
            var frm = new AcercadeForm(acercaDe);
            frm.ShowDialog();
        }

        private void datosDeContactoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioAcercade(TipoAcercade.DatosContacto);
        }

        private void versionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioAcercade(TipoAcercade.Version);
        }
    }
}
