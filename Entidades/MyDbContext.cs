using DataAccess.Entidades;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DataAccess
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {


        }

        public DbSet<User> Users { get; set; } = default!;

        public DbSet<Shipping> Shipping { get; set; } = default!;
    }
}
