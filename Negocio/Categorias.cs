using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace tp_logica_robles.Negocio
{
    public class Categorias
    {
        int id;
        string nombre;
        int id_sub_categoria;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Id_sub_categoria { get => id_sub_categoria; set => id_sub_categoria = value; }
    }
}
