using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCClasico.Models;


namespace MVCClasico.Context
{
    public class PortalDatabaseContext : DbContext
    {
        public
        PortalDatabaseContext(DbContextOptions<PortalDatabaseContext> options)
:       base(options)
        {
        }
        public DbSet<Alumno> Estudiantes { get; set; }
    }
}
