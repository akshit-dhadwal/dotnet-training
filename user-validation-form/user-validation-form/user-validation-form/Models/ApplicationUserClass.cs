using Microsoft.EntityFrameworkCore;

namespace user_validation_form.Models
{
    public class ApplicationUserClass : DbContext
    {
        public ApplicationUserClass(DbContextOptions<ApplicationUserClass> options):base(options)
        {

        }
        public DbSet<UserClass> UserReg { get; set; }
    }
}
