using DataAccess.Entidades;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .HasOne(o => o.PaymentConfirmation)
                .WithOne(p => p.Order)
                .HasForeignKey<Order>(o => o.PaymentConfirmationId);

            modelBuilder.Entity<PaymentConfirmation>()
                .HasKey(pc => pc.PaymentConfirmationId);

            modelBuilder.Entity<User>()
                .HasKey(u => u.Id);

            modelBuilder.Entity<Shipping>()
                .HasKey(s => s.ShippingId);

            // Otros mapeos y configuraciones de entidades

            base.OnModelCreating(modelBuilder);
        }


        public DbSet<User> Users { get; set; } = default!;
        public DbSet<Category> Categorys { get; set; } = default!;
        public DbSet<Order> Orders { get; set; } = default!;
        public DbSet<Products> Products { get; set; } = default!;
        public DbSet<Cart> Carts { get; set; } = default!;
        public DbSet<PaymentConfirmation> PaymentConfirmations { get; set; } = default!;
        public DbSet<OrderItem> OrderItems { get; set; } = default!;
        public DbSet<Shipping> Shippings { get; set; } = default!;
    }
}
