using Contacts.Domain.Contacts.VOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Domain.Contacts.Services
{
    public interface IContactService
    {
        IList<ContactVO> List();
        IList<ContactVO> ListByDDD(string ddd);
        void Create(ContactVO vo);
        void Update(ContactVO vo);
        void Delete(Guid id);
    }
}
