//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Task4.Models{
    public class WorkContext : DbContext{
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Project> Projects { get; set; }

        public WorkContext(DbContextOptions<WorkContext> options)
            : base(options)
        { }
    }
}
