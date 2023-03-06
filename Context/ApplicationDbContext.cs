using Microsoft.EntityFrameworkCore;
using StudentManagement.Models;

namespace StudentManagement.Context
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> contextOptions)
            : base(contextOptions)
        {
        
        }  

        //Code- Approach
        public DbSet<Student> Students { get; set; }    

    }
}
