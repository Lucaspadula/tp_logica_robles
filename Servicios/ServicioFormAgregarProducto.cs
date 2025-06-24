using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tp_logica_robles.Datos;
using tp_logica_robles.Negocio;

namespace tp_logica_robles.Servicios
{
    internal class ServicioFormAgregarProducto
    {
        AccesoDatos acceso = new AccesoDatos();
        string sql;
    
        public void Validacion()
        {

        }
        public DataTable cargarComboCategoria()
        {
            return acceso.ConsultarTabla("categorias");
           

        }
        public DataTable cargarComboOrigen()
        {
            return acceso.ConsultarTabla("ORIGEN_PRODUCTOS");
        }

        public bool guardarNuevo(Productos p)
        {
            
            string query = @"INSERT INTO PRODUCTOS (NOMBRE, PRECIO_UNITARIO, DESCRIPCION, ID_CATEGORIA,ID_ORIGEN)
                                VALUES(@NOMBRE, @PRECIO_UNITARIO, @DESCRIPCION, @ID_CATEGORIA, @ID_ORIGEN)";

            
            List<Parametro> list = new List<Parametro>();
            list.Add(new Parametro("@NOMBRE", p.Nombre));
            list.Add(new Parametro("@PRECIO_UNITARIO", p.Precio));
            list.Add(new Parametro("@DESCRIPCION", p.Descripcion));
            list.Add(new Parametro("@ID_CATEGORIA", p.Categoria.Id));
            list.Add(new Parametro("@ID_ORIGEN", p.Origen.Id));

            return acceso.ActualizarBD(query, list) == 1;

        }

        public bool editarProducto( Productos p, int codigoProducto)
        {
            string query = "UPDATE PRODUCTOS" +
            " SET NOMBRE = @nombre, PRECIO_UNITARIO = @precio, DESCRIPCION = @descripcion, ID_CATEGORIA = @categoria, ID_ORIGEN = @origen" +
            " WHERE ID =  @codigoProducto";

            List<Parametro> list = new List<Parametro>();
            list.Add(new Parametro("@nombre", p.Nombre));
            list.Add(new Parametro("@precio", p.Precio));
            list.Add(new Parametro("@descripcion", p.Descripcion));
            list.Add(new Parametro("@categoria", p.Categoria.Id));
            list.Add(new Parametro("@origen", p.Origen.Id));
            list.Add(new Parametro("@codigoProducto", codigoProducto));

            return acceso.ActualizarBD(query, list) == 1;
        }

        public DataTable verProducto(int codigoProducto)
        {
            string query = "SELECT * FROM PRODUCTOS WHERE ID = @CODIGOPRODUCTO";

            List<Parametro> list = new List<Parametro>();
            list.Add(new Parametro("@CODIGOPRODUCTO", codigoProducto));

           return acceso.ConsultarBD(query, list);
        }
    }
}
