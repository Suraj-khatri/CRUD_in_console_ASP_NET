using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleEF
{
    public class Context : DbContext
    {
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-KVOQSDF\SQLEXPRESS;Database=SchoolDB;Trusted_Connection=True;");
        }
        public DbSet<Student> Students { get; set; }
       
    }
}
