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
    public enum Modo
    {
        Nuevo,
        Editar
    }
    public partial class DetalleProductoForm : Form
    {
        ServicioFormAgregarProducto servicioFormAgregarProducto = new ServicioFormAgregarProducto();
        Modo accion;
        int codigoProducto;
        Productos producto = new Productos();

        public DetalleProductoForm(int codigoArticulo, Modo accion)
        {
            InitializeComponent();
            this.codigoProducto = codigoArticulo;
            this.accion = accion;
        }

        public DetalleProductoForm()
        {
            InitializeComponent();
        }

        private void cargarCombo(DataTable dt, System.Windows.Forms.ComboBox cbo) {
            cbo.DataSource = dt;
            cbo.DisplayMember = dt.Columns[1].ColumnName;
            cbo.ValueMember = dt.Columns[0].ColumnName;
        }

        private void AgregarProducto_Load(object sender, EventArgs e)
        {
            DataTable dtCategoria = servicioFormAgregarProducto.cargarComboCategoria();
            DataTable dtOrigen = servicioFormAgregarProducto.cargarComboOrigen();
            cargarCombo(dtCategoria, cboCategoria);
            cargarCombo(dtOrigen, cboOrigen);
            if(accion == Modo.Editar)
            {
                cargarProducto(codigoProducto);
            }
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

        private void cargarProducto(int codigoProducto)
        {
            DataTable dataTable = servicioFormAgregarProducto.verProducto(codigoProducto);
            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];
                producto.Id = Convert.ToInt32(row[0]);  
                producto.Nombre = row[1] != DBNull.Value ? Convert.ToString(row[1]) : string.Empty;
                producto.Precio = Convert.ToInt32(row[2]);
                producto.Descripcion = row[3] != DBNull.Value ? Convert.ToString(row[3]) : string.Empty;
                producto.Categoria = new Categorias { Id = Convert.ToInt32(row[4]) };
                producto.Origen = new OrigenProductos { Id = Convert.ToInt32(row[5]) };


                txt_Nom_Prod.Text = producto.Nombre;
                txt_precio.Text = producto.Precio.ToString();
                txt_descrip.Text = producto.Descripcion;
                cboCategoria.SelectedValue = producto.Categoria.Id;
                cboOrigen.SelectedValue = producto.Origen.Id;
            }
        }

        private void nuevoProducto()
        {
            if (servicioFormAgregarProducto.guardarNuevo(producto))
            {
                MessageBox.Show("se cargo el nuevo Producto");
                txt_Nom_Prod.Text = "";
                txt_precio.Text = "";
                txt_descrip.Text = "";
                cboCategoria.SelectedValue = -1;
                cboOrigen.SelectedValue = -1;
            } else
            {
                MessageBox.Show("No se pudo realizar la carga del nuevo producto");
            }
        }

        private void editarProducto(Productos producto, int codigoProducto)
        {
            if (servicioFormAgregarProducto.editarProducto(producto, codigoProducto))
            {
                MessageBox.Show("Se modificó el producto");
                Close();
            }
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
                if (accion == Modo.Nuevo)
                {
                    nuevoProducto();
                }
                else if (accion == Modo.Editar)
                {
                    editarProducto(producto, codigoProducto);
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
