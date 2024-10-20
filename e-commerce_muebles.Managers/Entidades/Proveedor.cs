using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce_muebles.Managers.Entidades
{
    public class Proveedor
    {
        public int id_proveedor { get; set; }
        public string nombre { get; set; }
        public string telefono { get; set; }
        public int direccion_id { get; set; }
    }
}
