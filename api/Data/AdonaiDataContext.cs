using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class AdonaiDataContext : DbContext
    {
        public AdonaiDataContext()
        {

        }

        public DbSet<Lead> Lead { get; set; }
    }
}