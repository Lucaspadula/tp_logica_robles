using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tp_logica_robles.Datos;
using static tp_logica_robles.Presentacion.AgregrarProductoForm;
using tp_logica_robles.Presentacion;

namespace tp_logica_robles.Servicios
{

    public class ServicioFormProductos
    {
        AccesoDatos acceso = new AccesoDatos();
        string sql;
        public void cargarBtnGrilla(ProductForm form)
        {
            List<string> txtBotones = new List<string> { "Editar", "Eliminar" };
            foreach (string btn in txtBotones)
            {

                DataGridViewButtonColumn Gridbtn = new DataGridViewButtonColumn();
                Gridbtn.Text = $"{btn}";
                Gridbtn.UseColumnTextForButtonValue = true;
                form.DataGridViewProductos.Columns.Add(Gridbtn);
            }

        }

        public void btnConsultar(ProductForm form)
        {

            sql = @"select p.id, p.nombre, p.precio_unitario, op.nombre ,c.nombre " +
                "from productos p inner join origen_productos op on op.id = p.id_origen" +
                " inner join categorias c on c.id = p.id_categoria ";


            string producto = form.textBoxCodigoProd.Text;
            var parametros = new List<Parametro>();
            Debug.WriteLine($"valor de producto {producto}");

            if (!string.IsNullOrEmpty(producto))
            {
                bool esNumero = int.TryParse(producto, out int id);
                if (esNumero)
                {
                    sql += @"where p.id = @producto";
                    parametros.Add(new Parametro("@producto", producto));

                }
                else
                {
                    sql += @"where p.nombre like @producto ";
                    parametros.Add(new Parametro("@producto", $"%{producto}%"));
                };


            }


            DataTable prod = acceso.ConsultarBD(sql, parametros);
            form.DataGridViewProductos.Rows.Clear();

            foreach (DataRow fila in prod.Rows)
            {
                form.DataGridViewProductos.Rows.Add(fila[0], fila[1], fila[2], fila[3], fila[4]);
            }
        }

    }
}
