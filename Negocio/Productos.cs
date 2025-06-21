using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_logica_robles.Negocio
{
    public class Productos
    {
        int id;
        string nombre, descripcion;
        Categorias categoria;
        OrigenProductos origen;
        double precio;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public Categorias Categoria { get => categoria; set => categoria = value; }
        public OrigenProductos Origen { get => origen; set => origen = value; }
        public double Precio { get => precio; set => precio = value; }
    }
}
