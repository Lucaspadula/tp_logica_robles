using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tp_logica_robles.Datos;
using tp_logica_robles.Presentacion;
using static tp_logica_robles.Presentacion.AcercadeForm;


namespace tp_logica_robles.Servicios
{
    public class ServicioConsultasAcercade
    {
             
                
        public void MostrarConsulta(AcercadeForm form, TipoAcercade tipoAcercade)
        {

            switch (tipoAcercade)
            {
                case TipoAcercade.Informacion:
                    form.LblTituloAcercade.Text = $"INFORMACION";
                    form.LblDescripcion.Text = "Este proyecto fue desarrollado durante el cursado de la Materia: Programación 1, a cargo del Ing. Botta.\r\n\r\n" +
    "Esta materia, perteneciente al cursado del 1er cuatrimestre, pretende que los estudiantes desarrollen habilidades y destrezas " +
    "para poder implementar una solución programática a una necesidad de información concreta, basándose en el paradigma orientado a objetos, " +
    "utilizando para ello C# como lenguaje de programación.\r\n\r\n" +
    "También se pretende que los estudiantes puedan establecer desde una aplicación visual un vínculo de conexión con una base de datos SQL Server " +
    "utilizando ADO.NET como tecnología de soporte. Para el logro de estos objetivos es que se planteó, a partir de un trabajo conjunto con la materia Datos 1, " +
    "la elaboración de un proyecto. En este caso, el mismo va a girar en torno a la Mueblería Robles.\r\n\r\n" +
    "La empresa ROBLES S.A. se dedica a la comercialización de muebles, posee varias sucursales en distintas provincias del país.\r\n" +
    "Cuenta con una amplia gama de productos nacionales e importados de alta calidad cuyo stock está depositado en los galpones que cada sucursal posee.\r\n" +
    "Estos productos se venden tanto al por mayor como al público en general.\r\n\r\n" +
    "El cliente puede presentarse personalmente en el local, donde un vendedor capacitado lo recibe y lo acompaña a hacer un recorrido en el amplio salón de ventas, " +
    "o bien acceder al catálogo en línea y asesorarse con un vendedor asistente por mensajería en la web.\r\n\r\n" +
    "Una vez que el cliente ha decidido qué comprar, el vendedor se encarga de verificar si el producto está disponible en el stock de la sucursal " +
    "y de proporcionar información detallada sobre el precio y las características del producto, formas de pago y envío.\r\n\r\n" +
    "Una vez conformada la compra por parte del cliente, el vendedor procede a registrar los detalles de la factura en el sistema de la empresa " +
    "y la actualización del stock, asegurándose de que todos los datos estén actualizados y sean precisos, confirmando la dirección del envío.\r\n\r\n" +
    "A partir de aquí, el cliente realiza el pago, ya sea personalmente en la caja, o bien por la plataforma de pago.\r\n" +
    "La empresa ROBLES S.A. acepta hasta tres formas de pago diferentes por factura y, dependiendo de la forma de pago, esta puede tener recargos.\r\n" +
    "Los detalles de cada forma de pago se registran en el sistema. Puede que algunas formas de pago tengan un recargo, " +
    "como por ejemplo el pago con tarjeta de crédito en cuotas.\r\n\r\n" +
    "Finalmente, el cliente recibe su producto junto con la factura y los detalles de la empresa de transporte encargada de la entrega.\r\n" +
    "Esta información se almacena en una base de datos centralizada y actualizada regularmente para garantizar la eficiencia " +
    "y la precisión de las operaciones comerciales de ROBLES S.A.";
                    break;
                case TipoAcercade.DatosContacto:
                    form.LblTituloAcercade.Text = $"DATOS DE CONTACTO";
                    form.LblDescripcion.Text = "Ante cualquier consulta o información adicional que se presente, los datos de contacto son los siguientes:\r\nBALLS FACUNDO. Legajo:412110.\r\nBINI TOLEDO MICAELA CANDELARIA. Legajo:412661.\r\nCARIDDI CINTIA. Legajo: 421263.\r\nDUARTE POLANCO AXEL MATIAS. Legajo: 421634.\r\nGLOWACKI MATIAS. Legajo: 421467.\r\nMALDONADO SARMIENTO NOLIS. Legajo: 421613.\r\nPADULA LUCAS. Legajo: 421261.";
                    break;
                case TipoAcercade.Version:
                    form.LblTituloAcercade.Text = $"VERSION";
                    form.LblDescripcion.Text = "Versión: 1.0.0.230625.";
                    break;

            }

        }

    }

}
