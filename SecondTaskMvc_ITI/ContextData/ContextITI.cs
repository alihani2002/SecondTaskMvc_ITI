using Microsoft.EntityFrameworkCore;
using SecondTaskMvc_ITI.Models;

namespace SecondTaskMvc_ITI.ContextData
{
    public class ContextITI :DbContext
    {
        public ContextITI() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-JEJ8BBV;Database=MVC_task;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        public DbSet<Empolyee> Empolyee { get; set; }
        public DbSet<Office> Office { get; set; }
        public DbSet<Project> project { get; set; }
        public DbSet<Emp_Project> EmpolyeeProject { get; set; }
    }
}
