using Contacts.Infrastructure.Models;

namespace Contacts.Domain.Contacts.Models;
public class Contact : EntityBase<Guid>
{
    public string Name { get; private set; } = string.Empty;
    public ContactPhone Phone { get; private set; } = null!;
    public ContactEmail Email { get; private set; } = null!;

    public Contact() { }

    public Contact(string name, ContactPhone phone, ContactEmail email)
    {
        Name = name;
        Phone = phone;
        Email = email;
    }
}
