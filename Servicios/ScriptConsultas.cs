using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tp_logica_robles.Negocio;

namespace tp_logica_robles.Servicios
{
    public class ScriptConsultas
    {
        public string sqlHrConductores = @"select 
							c.NOMBRE +space(2)+ c.APELLIDO as NOMBRE_COMPLETO,
							v.MARCA +space(2)+'| PATENTE:'+ space(2)+ v.PATENTE AS MARCA_PATENTE,
							el.RAZON_SOCIAL as EMPRESA,
							'HR-' + CONVERT(VARCHAR(20), hr.ID) as NUMERO_HOJA_RUTA,
							format(hr.FECHA_CREACION, 'yyyy/MM/dd') as FECHA_CREACION,
							hr.OBSERVACION
							from HOJA_RUTAS hr 
							join  CONDUCTORES_VEHICULOS cv on hr.ID_CONDUCTOR_VEHICULO = cv.id 
							join  CONDUCTORES c on c.id = cv.ID_CONDUCTOR
							join  VEHICULOS v on v.id = cv.ID_VEHICULO
							join  EMPRESAS_LOGISTICAS el on el.CUIT = c.CUIT_EMPRESA_LOGISTICA
							WHERE hr.FECHA_CIERRE >= dateadd(month, -6,GETDATE())
							and v.MARCA in ('IVECO', 'FIAT', 'PEUGEOT')
							AND hr.observacion is not null
							";
        public string CanalesComunicacion = @"SELECT  tc.TIPO_CANAL, ca.DESCRIPCION_CANAL, e.NOMBRE + ' ' + e.APELLIDO AS EMPLEADO, p.PROVINCIA
						FROM CANALES_DE_ATENCION ca
						JOIN TIPOS_CANALES tc ON ca.ID_TIPO_CANAL = tc.ID
						JOIN EMPLEADOS e ON ca.ID_EMPLEADO = e.LEGAJO
						JOIN DIRECCIONES de ON e.ID_DIRECCION = de.ID
						JOIN BARRIOS be ON de.ID_BARRIO = be.ID
						JOIN PROVINCIAS p ON be.ID_PROVINCIA = p.ID
						JOIN CLIENTES c ON ca.ID_CLIENTE = c.NRO_CLIENTE
						JOIN DIRECCIONES dc ON c.ID_DIRECCION = dc.ID
						JOIN BARRIOS bc ON dc.ID_BARRIO = bc.ID
						WHERE 
							(p.PROVINCIA LIKE 'C%' OR p.PROVINCIA LIKE 'B%' OR p.PROVINCIA IS NULL)
							AND (bc.BARRIO NOT LIKE '%NUEVA%' OR bc.BARRIO IS NULL)
						";
        public string DetalleProducto = @"SELECT 
								p.NOMBRE AS Nombre_Producto,
								p.DESCRIPCION AS Descripcion,
								p.PRECIO_UNITARIO,
								c.NOMBRE AS Categoria,
								sc.DESCRIPCION_SUB_CATEGORIA AS Subcategoria
							FROM PRODUCTOS p
							JOIN CATEGORIAS c ON p.ID_CATEGORIA = c.ID
							JOIN SUB_CATEGORIAS sc ON c.ID_SUB_CATEGORIA = sc.ID
							WHERE sc.DESCRIPCION_SUB_CATEGORIA IN ('MUEBLES DE COMEDOR', 'MUEBLES DE DORMITORIO')
							  AND p.PRECIO_UNITARIO BETWEEN 10000 AND 50000
							  AND c.NOMBRE<> 'SILLAS DE COMEDOR'
							";

        public string GalponesMayorCapacidad = @"SELECT TOP 5
							s.NRO_SUCURSAL,
							b.BARRIO,
							p.PROVINCIA,
							g.HABILITADO,
							g.CAPACIDAD
						FROM GALPONES g
						INNER JOIN SUCURSALES s ON s.ID_NRO_GALPON = g.NRO_GALPON
						INNER JOIN DIRECCIONES d ON s.ID_DIRECCIONES = d.ID
						INNER JOIN BARRIOS b ON d.ID_BARRIO = b.ID
						INNER JOIN PROVINCIAS p ON b.ID_PROVINCIA = p.ID
						ORDER BY g.CAPACIDAD DESC";

        public string DevolucionProducto = @"SELECT 
								  D.CANT_DEVOLUCION, 
								  D.OBSERVACION, 
								  MD.DESCRIPCION AS MOTIVO, 
								  D.FECHA, 
								  P.NOMBRE AS PRODUCTO
								FROM DEVOLUCIONES D
								JOIN MOTIVOS_DEVOLUCION MD ON MD.CODIGO = D.MOTIVO
								JOIN DETALLES_REMITOS DR ON DR.ID = D.ID_DETALLE_REMITO
								JOIN PRODUCTOS P ON P.ID = DR.ID_PRODUCTO
								WHERE 
								  LOWER(MD.DESCRIPCION) NOT LIKE '%incorrecto%'
								  AND D.CANT_DEVOLUCION = 1";

        public string FacturasDeClientes = @" SELECT C.NOMBRE, C.APELLIDO, DF.CODIGO_FACTURA, DF.PRECIO,     F.FECHA                                                                                                                 
							FROM FACTURAS F                                                                                                                                        
							JOIN CLIENTES C ON F.NRO_CLIENTE = C.NRO_CLIENTE                                                               
							JOIN DETALLE_FACTURAS DF ON F.CODIGO_FACTURA = DF.CODIGO_FACTURA 
							WHERE YEAR(F.FECHA) =2025
							AND DF.PRECIO > 10000                                                                                                                
							AND C.APELLIDO LIKE '%R%' ";

        public string DetalleDeFacturas = @"SELECT CONCAT(e.NOMBRE, ' ',e.APELLIDO) 'FULL NAME',  r.ROL, pu.PUESTOS, p.NOMBRE, p.DESCRIPCION, 
						   f.FECHA, df.PRECIO, df.CANTIDAD, (df.PRECIO * df.CANTIDAD) 'MONTO TOTAL'
					FROM DETALLE_FACTURAS df, PRODUCTOS p, FACTURAS f, EMPLEADOS e, ROLES r, PUESTOS pu
					WHERE df.CODIGO_FACTURA = f.CODIGO_FACTURA 
					AND df.ID_PRODUCTO = p.ID
					AND f.LEGAJO_EMPLEADO = e.LEGAJO
					AND e.ID_ROL = r.ID
					AND r.ID_PUESTO = pu.ID
					and YEAR(f.FECHA) in (2023,2024)
					AND (r.ROL LIKE '%RO' OR r.rol = 'ASESOR COMERCIAL')
					and df.PRECIO * df.CANTIDAD > (select avg(PRECIO)
									from DETALLE_FACTURAS)
					";

        public string ObtenerConsulta(string Consulta)
        {
            switch (Consulta)
            {
                case "sqlHrConductores":
                    return sqlHrConductores;
                case "CanalesComunicacion":
                    return CanalesComunicacion;
                case "DetalleProducto":
                    return DetalleProducto;
                case "GalponesMayorCapacidad":
                    return GalponesMayorCapacidad;
                case "DevolucionProducto":
                    return DevolucionProducto;
                case "FacturasDeClientes":
                    return FacturasDeClientes;
                case "DetalleDeFacturas":
                    return DetalleDeFacturas;
                default:
                    throw new ArgumentException("Consulta no reconocida");
            }
        }
    }
}
