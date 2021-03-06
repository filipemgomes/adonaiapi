using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class AdonaiDataContext : DbContext
    {
        public AdonaiDataContext(DbContextOptions<AdonaiDataContext> options)
            : base(options)
        {

        }

        public DbSet<Lead> Lead { get; set; }
    }
}