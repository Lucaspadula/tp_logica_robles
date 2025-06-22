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
    }
}
