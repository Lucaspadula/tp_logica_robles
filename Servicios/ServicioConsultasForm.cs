using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tp_logica_robles.Datos;
using tp_logica_robles.Presentacion;
using static tp_logica_robles.Presentacion.ConsultasForm;

namespace tp_logica_robles.Servicios
{

    public class ServicioConsultasForm
    {
        AccesoDatos acceso = new AccesoDatos();
        ScriptConsultas scriptConsultas = new ScriptConsultas();
        string sql;

        public void MostrarConsulta(ConsultasForm form, TipoConsulta tipoConsulta)
        {

            switch (tipoConsulta)
            {
                case TipoConsulta.HrConductores://lUCAS
                    sql = scriptConsultas.ObtenerConsulta("sqlHrConductores");
                    form.DGBProductos.DataSource = acceso.ConsultarBD(sql);
                    form.LblTituloConsulta.Text = $"CONSULTA RUTAS CONDUCTORES";
                    form.LblDescripcion.Text = "Muestra un listado de conductores con sus vehículos asignados y las rutas programadas para los últimos\r\n5 meses, incluyendo datos clave como la empresa logística responsable, identificar las hojas de ruta y \r\nobservaciones de cada servicio.\r\n";
                    break;
                case TipoConsulta.CanalesComunicacion://MICA
                    sql = scriptConsultas.ObtenerConsulta("CanalesComunicacion");
                    form.DGBProductos.DataSource = acceso.ConsultarBD(sql);
                    form.LblTituloConsulta.Text = $"CONSULTA CANALES COMUNICACION";
                    form.LblDescripcion.Text = "Obtener los canales de atención en los que intervinieron empleados que residen en provincias que comienzan \r\ncon la letra “C” o “B”, y donde los clientes atendidos no viven en barrios que contengan la palabra \r\n“NUEVA”. Mostrar el tipo y la descripción del canal, el nombre completo del empleado y la provincia.";
                    break;
                case TipoConsulta.DetalleProducto: //NOLIS
                    sql = scriptConsultas.ObtenerConsulta("DetalleProducto");
                    form.DGBProductos.DataSource = acceso.ConsultarBD(sql);
                    form.LblTituloConsulta.Text = $"CONSULTA DETALLE PRODUCTO";
                    form.LblDescripcion.Text = "Esta consulta recupera información detallada de productos que cumplen con criterios específicos relacionados \r\na su categoría, subcategoría y precio. Para cada producto listado, se muestran su nombre, descripción, \r\nprecio unitario, la categoría a la que pertenece y su subcategoría.\r\n";
                    break;
                case TipoConsulta.GalponesMayorCapacidad: //MATI DUARTE
                    sql = scriptConsultas.ObtenerConsulta("GalponesMayorCapacidad");
                    form.DGBProductos.DataSource = acceso.ConsultarBD(sql);
                    form.LblTituloConsulta.Text = $"CONSULTA GALPONES CON MAYOR CAPACIDAD";
                    form.LblDescripcion.Text = "Indicar cuales son los 5 galpones con mayor capacidad, ordenados de mayor a menor, y saber a qué sucursal \r\npertenecen, dirección, barrio, provincia y si se encuentran habilitados.\r\n";
                    break;
                case TipoConsulta.DevolucionProducto: //CINTIA
                    sql = scriptConsultas.ObtenerConsulta("DevolucionProducto");
                    form.DGBProductos.DataSource = acceso.ConsultarBD(sql);
                    form.LblTituloConsulta.Text = $"CONSULTA DEVOLUCION PRODUCTO";
                    form.LblDescripcion.Text = " La consulta deberá mostrar la cantidad devuelta, la observación, el motivo, el producto y la fecha de \r\naquellas devoluciones que el motivo no contenga la palabra \"incorrecto\"(sin importar mayúsculas y minúsculas) \r\ny que su cantidad sea 1.\r\n";
                    break;
                case TipoConsulta.FacturasDeClientes: //MATI
                    sql = scriptConsultas.ObtenerConsulta("FacturasDeClientes");
                    form.DGBProductos.DataSource = acceso.ConsultarBD(sql);
                    form.LblTituloConsulta.Text = $"CONSULTA FACTURAS DE CLIENTES";
                    form.LblDescripcion.Text = "Mostrar el nombre y apellido del cliente, el codigo, precio y  fecha de las facturas de las ventas \r\nrealizadas en 2025 cuyo precio sea mayor a $10.000 y el apellido del cliente contenga la letra 'R'.";
                    break;
                case TipoConsulta.DetalleDeFacturas: //FACU
                    sql = scriptConsultas.ObtenerConsulta("DetalleDeFacturas");
                    form.DGBProductos.DataSource = acceso.ConsultarBD(sql);
                    form.LblTituloConsulta.Text = $"CONSULTA DETALLE DE LAS FACTURAS";
                    form.LblDescripcion.Text = "Mostrar el detalle de las facturas de los años 2023 y 2024, listando el nombre y apellido del empleado \r\n(en una sola columna) cuyo rol finalice con las letras 'RO' o sea 'ASESOR COMERCIAL' y el puesto dentro de la \r\nempresa, se pide listar el nombre y descripcion del articulo junto a la fecha de la factura, precio, cantidad y \r\nmonto total de la compra. De los detalles se pide filtrar aquellos que el monto \r\ntotal pedido sea mayor al promedio de los productos.\r\n";
                    break;
            }

        }

    }



}

