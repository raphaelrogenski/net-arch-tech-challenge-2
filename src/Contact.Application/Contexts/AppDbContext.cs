using Contacts.Domain.Contacts.Models;
using Contacts.Infrastructure.Mappings;
using Microsoft.EntityFrameworkCore;

namespace Contacts.Application.Contexts;
public class AppDbContext : DbContext
{
    public DbSet<Contact> Contact { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ContactMapping());
        base.OnModelCreating(modelBuilder);
    }
}
