using Microsoft.EntityFrameworkCore;

namespace SchoolManagement.PersistenceDB.Database;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }
}
