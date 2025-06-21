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

    //public int guardarNuevo()
    //    {
    //        Productos producto = new Productos();
    //        string query = 
    //    }
    }
}
