using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp_logica_robles.Presentacion
{
    public partial class AgregrarProductoForm : Form
    {
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
    }
}
