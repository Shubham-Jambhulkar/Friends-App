using Friends.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Friends.Api.Data
{
    public class DataContext : DbContext
    {

        public DbSet<Value> Values { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
    }
}