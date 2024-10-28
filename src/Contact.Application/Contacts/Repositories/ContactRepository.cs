using Contacts.Application.Contexts;
using Contacts.Domain.Contacts.Models;
using Contacts.Domain.Contacts.Repositories;
using Contacts.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Contacts.Application.Contacts.Repositories;
public class ContactRepository(AppDbContext context) : RepositoryBase<Contact>(context), IContactRepository
{
    public async Task<IEnumerable<Contact>> GetByDDDAsync(string ddd)
    {
        return await _dbSet.Where(c => c.Phone.DDD == ddd).ToListAsync();
    }
}
