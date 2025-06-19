using tp_logica_robles.Presentacion;
using tp_logica_robles.Servicios;
using static tp_logica_robles.Presentacion.AgregrarProductoForm;

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

            servicioFormProductos.cargarBtnGrilla(this);

        }



        private void labelProducto_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AgregrarProductoForm agregrarProductoForm = new AgregrarProductoForm();
            agregrarProductoForm.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int codigoArticulo = Convert.ToInt32(dataGridViewProductos.Rows[e.RowIndex].Cells["codigo"].Value);
            string nomArticulo = (string)dataGridViewProductos.Rows[e.RowIndex].Cells["nombre"].Value;
            if (e.ColumnIndex == dataGridViewProductos.Columns[5].Index)
            {
                AgregrarProductoForm agregrarProductoForm = new AgregrarProductoForm(codigoArticulo, Modo.Editar);
                agregrarProductoForm.ShowDialog();
            }
            if (e.ColumnIndex == dataGridViewProductos.Columns[6].Index)
            {
                MessageBox.Show($"Desea eliminar el producto {nomArticulo}", "CONFIRMACION", MessageBoxButtons.OKCancel);
                //falta la logica para borrar 
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

    }
}
