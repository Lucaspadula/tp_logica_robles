using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tp_logica_robles.Datos;
using tp_logica_robles.Negocio;
using tp_logica_robles.Servicios;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace tp_logica_robles.Presentacion
{
    public partial class DetalleProductoForm : Form
    {
        ServicioFormAgregarProducto servicioFormAgregarProducto = new ServicioFormAgregarProducto();
        
        public enum Modo
        {
            Nuevo,
            Editar
        }

        public DetalleProductoForm(int codigoArticulo, Modo modo)
        {
            InitializeComponent();

        }

        public DetalleProductoForm()
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
            Productos producto = new Productos();

            if (Validar())
            {
                producto.Nombre = txt_Nom_Prod.Text;
                producto.Precio = Convert.ToDouble(txt_precio.Text);
                producto.Descripcion = txt_descrip.Text;
                Categorias cat = new Categorias();
                cat.Id = Convert.ToInt32(cboCategoria.SelectedValue);
                producto.Categoria = cat;
                OrigenProductos origen = new OrigenProductos();
                origen.Id = Convert.ToInt32(cboOrigen.SelectedValue);
                producto.Origen = origen;
                if (servicioFormAgregarProducto.guardarNuevo(producto))
                {
                    MessageBox.Show("se cargo el nuevo Producto");
                    txt_Nom_Prod.Text = "";
                    txt_precio.Text = "";
                    txt_descrip.Text = "";
                    cboCategoria.SelectedValue = -1;
                    cboOrigen.SelectedValue = -1;
                }
                else
                {
                    MessageBox.Show("No se pudo realizar la carga del nuevo producto");
                }
            }



        }

        private bool Validar()
        {
            if (string.IsNullOrEmpty(txt_Nom_Prod.Text))
            {
                MessageBox.Show("Debe ingresar el nombre del Producto");
                return false;
            }
            if (cboCategoria.TabIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una Categoria");
                return false;
            }
            if (string.IsNullOrEmpty(txt_precio.Text ))
            {
                MessageBox.Show("Debe ingresar el precio del Producto");
                return false;
            }
            if (string.IsNullOrEmpty(txt_descrip.Text))
            {
                MessageBox.Show("Debe ingresar el precio del Producto");
                return false;
            }
                       
            return true;
        }
    }
}
