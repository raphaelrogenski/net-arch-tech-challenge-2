using Contacts.Application.Contacts.Mappings;
using Contacts.Domain.Contacts.Models;
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
