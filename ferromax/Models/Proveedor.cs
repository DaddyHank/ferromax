using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ferromax.Models
{
    public class Proveedor
    {
        public int Id { get; set; }
        public string nombreProveedor { get; set; }
        public string productoProveedor { get; set; }
        public string nombreRepartidor { get; set; }
        public string apellidosRepartidor { get; set; }
        public int telefonoRepartidor { get; set; }
        public string direccionProveedor { get; set; }
    }
}
