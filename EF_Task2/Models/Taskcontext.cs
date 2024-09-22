using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Task2.Models
{
    internal class Taskcontext:DbContext
    {
        public virtual DbSet<catalog> Catalogs { get; set; }
        public virtual DbSet<news> News { get; set; }
        public virtual DbSet<author> Author { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=TaskDB;Trusted_connection=True;TrustServerCertificate=True;");
        }
    }
}
