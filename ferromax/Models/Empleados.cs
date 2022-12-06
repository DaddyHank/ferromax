using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ferromax.Models
{
    public class Empleados
    {
        public int Id { get; set; }
        public string nombresEmpleados { get; set; }
        public string apellidosEmpleados { get; set; }
        public int telefonoEmpleados { get; set; }
        public string emailEmpleados { get; set; }
    }
}
