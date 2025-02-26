using Microsoft.EntityFrameworkCore;
using ett1_web_api.Models;

namespace ett1_web_api.Data
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}
