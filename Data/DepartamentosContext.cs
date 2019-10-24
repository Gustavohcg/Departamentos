using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Departamentos.Models
{
    public class DepartamentosContext : DbContext
    {
        public DepartamentosContext (DbContextOptions<DepartamentosContext> options)
            : base(options)
        {
        }

        public DbSet<Departamentos.Models.Departments> Departments { get; set; }
    }
}
