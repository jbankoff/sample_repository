using Microsoft.EntityFrameworkCore;
using SampleBlazorApp.Models;

namespace SampleBlazorApp.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Customer> Customers => Set<Customer>();
}
