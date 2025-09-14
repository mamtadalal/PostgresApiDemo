using Microsoft.EntityFrameworkCore;
using PostgresApiDemo.Models;
//using System.Data.Entity;
//using System.Data.Entity.Core;
//using Microsoft.EntityFrameworkCore.Npgsql;
//using Microsoft.EntityFrameworkCore.Tools;

namespace PostgresApiDemo.Data
    
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
    }

}
