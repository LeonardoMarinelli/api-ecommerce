using api_ecommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace api_ecommerce.Infraestructure.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Reservation> Reservations { get; set; }
}