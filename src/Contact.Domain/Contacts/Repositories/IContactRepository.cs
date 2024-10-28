using Contacts.Domain.Contacts.Models;
using Contacts.Infrastructure.Repositories;

namespace Contacts.Domain.Contacts.Repositories;
public interface IContactRepository : IRepositoryBase<Contact>
{
    Task<IEnumerable<Contact>> GetByDDDAsync(string ddd);
}
