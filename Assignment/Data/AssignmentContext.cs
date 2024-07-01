using Assignment.Models;
using System.Data.Entity;

namespace Assignment.Data
{
    public class AssignmentContext : DbContext
    {
        public AssignmentContext() : base("name=Connection")
        {
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Departments> Departments { get; set; }
    }
}
