using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ferromax.Models;

namespace ferromax.Data
{
    public class FerromaxContext : DbContext
    {
        public FerromaxContext(DbContextOptions<FerromaxContext> options) : base(options) { }
        public DbSet<Empleados> empleados { get; set; }
        public DbSet<Productos> productos { get; set; }
        public DbSet<Ventas> ventas { get; set; }
        public DbSet<Compras> compras { get; set; }
        public DbSet<Proveedor> proveedors { get; set; }
    }
}
